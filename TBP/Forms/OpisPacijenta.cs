using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.Forms;
using TBP.Models;
using TBP.ViewModels;

namespace TBP
{
    public partial class OpisPacijenta : Form
    {
        pacijent Pacijent;
        doktor Doktor;
        public OpisPacijenta(pacijent pacijent, doktor doktor)
        {
            InitializeComponent();
            Pacijent = pacijent;
            Doktor = doktor;
        }

        private void RefreshGrids()
        {
            dataGridViewPregledi.DataSource = PacijentRepozitorij.DohvatiPregledePacijentaZaDoktora(Pacijent.id, Doktor.id).Select(p => new PregledViewModel()
            {
                ID = p.id,
                Pocetak = p.vrijeme.LowerBound,
                Trajanje = (p.vrijeme.UpperBound - p.vrijeme.LowerBound).Minutes,
                BiljeskaDoktora = p.biljeska_doktora
            }).ToList();
            dataGridViewBiljeske.DataSource = PacijentRepozitorij.DohvatiBilješkePacijentaZaDoktora(Pacijent.id, Doktor.id).Select(b => new BiljeskaViewModel()
            {
                ID = b.id,
                Opis = b.opis,
                ZaDoktora = b.id_doktora.HasValue,
                Vrijeme = b.vrijeme_objave.Value
            }).ToList();
        }

        private void OpisPacijenta_Load(object sender, EventArgs e)
        {
            lblImeIPrezime.Text = Pacijent.idNavigation.ime + " " + Pacijent.idNavigation.prezime;
            lblDatumRodenja.Text = Pacijent.datum_rodenja.ToShortDateString();
            lblZdravstveno.Text = Pacijent.zdravstveno_osiguranje ? "Ima" : "Nema";
            lblMenstruacija.Text = Pacijent.datum_zadnje_menstruacije.HasValue ? Pacijent.datum_zadnje_menstruacije.Value.ToShortDateString() : "Nije navedeno";
            lblPorod.Text = Pacijent.predvideni_datum_poroda.HasValue ? Pacijent.predvideni_datum_poroda.Value.ToShortDateString() : "Nije navedeno";
            RefreshGrids();
        }

        private void btnNoviPregled_Click(object sender, EventArgs e)
        {
            PregledForm pregledForm = new PregledForm(Pacijent.id, Doktor.id);

            pregledForm.ShowDialog();
            RefreshGrids();
        }
    }
}
