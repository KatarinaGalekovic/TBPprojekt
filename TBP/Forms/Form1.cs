using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.Models;

namespace TBP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioBtnPacijent_CheckedChanged(object sender, EventArgs e)
        {
            panelRegistracijaPacijent.Visible = true;
            panelRegistracijaDoktor.Visible = false;
        }

        private void radioBtnDoktor_CheckedChanged(object sender, EventArgs e)
        {
            panelRegistracijaDoktor.Visible = true;
            panelRegistracijaPacijent.Visible = false;
        }

        private void lblRegistracija_Click(object sender, EventArgs e)
        {
            gbRegistracija.Visible = true;
            gbPrijava.Visible = false;
        }

        private void lblPrijava_Click(object sender, EventArgs e)
        {
            gbPrijava.Visible = true;
            gbRegistracija.Visible = false;
        }

        private void btnRegistraraj_Click(object sender, EventArgs e)
        {
            using (tbpContext ctx = new tbpContext())
            {
                korisnik noviKorisnik = new korisnik();
                noviKorisnik.ime = txtBoxIme.Text;
                noviKorisnik.prezime = txtBoxPrezime.Text;
                noviKorisnik.email = txtBoxEmail.Text;
                noviKorisnik.korisnicko_ime = txtBoxKorisnickoIme.Text;
                noviKorisnik.lozinka = txtBoxLozinka.Text;
                if (radioBtnPacijent.Checked)
                {
                    pacijent noviPacijent = new pacijent();
                    noviPacijent.datum_rodenja = dateRodenja.Value;
                    if(dateZadnjeMenstruacije.Checked)
                        noviPacijent.datum_zadnje_menstruacije = dateZadnjeMenstruacije.Value;
                    if(datePredvidenogPoroda.Checked)
                        noviPacijent.predvideni_datum_poroda = datePredvidenogPoroda.Value;
                    noviPacijent.zdravstveno_osiguranje = rbZdravstvenoDa.Checked;

                    noviPacijent.idNavigation = noviKorisnik;

                    ctx.pacijent.Add(noviPacijent);
                }
                else if (radioBtnDoktor.Checked)
                {
                    doktor noviDoktor = new doktor();
                    noviDoktor.adresa_ordinacije = txtBoxAdresaOrdinacije.Text;

                    noviDoktor.idNavigation = noviKorisnik;
                    ctx.doktor.Add(noviDoktor);
                }

                try {
                    ctx.SaveChanges();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.InnerException.Message, "Greška");
                    return;
                }

                MessageBox.Show("Uspješno ste se registrirali!", "Uspjeh!");
            }
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtBoxPrijavaKorisnickoIme.Text;
            string lozinka = txtBoxPrijavaLozinka.Text;

            korisnik trazeniKorisnik = KorisnikRepozitorij.PrijaviKorisnika(korisnickoIme, lozinka);

            if (trazeniKorisnik != null)
            {
                txtBoxPrijavaKorisnickoIme.Clear();
                txtBoxPrijavaLozinka.Clear();

                this.Hide();
                if (trazeniKorisnik.doktor != null)
                {
                    doktor trazeniDoktor = trazeniKorisnik.doktor;

                    DoktorForm doktorForm = new DoktorForm(trazeniDoktor);

                    doktorForm.FormClosed += (a, b) => { this.Show(); };
                    doktorForm.Show();
                }
                else
                {
                    pacijent trazeniPacijent = trazeniKorisnik.pacijent;
                }
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka. Molimo pokušajte ponovno.", "Greška");
                txtBoxPrijavaLozinka.Clear();
            }
        }
    }
}
