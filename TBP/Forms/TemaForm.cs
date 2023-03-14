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
using TBP.Repositories;
using TBP.ViewModels;

namespace TBP.Forms
{
    public partial class TemaForm : Form
    {
        korisnik Korisnik;
        tema Tema;
        public TemaForm(tema tema, korisnik korisnik)
        {
            Korisnik = korisnik;
            Tema = tema;
            InitializeComponent();
            lblNaslov.Text = Tema.naslov;
            lblTekst.Text = Tema.sadrzaj;
            lblVrijemeObjave.Text = Tema.vrijeme_objave.ToString();
            lblKreatorTeme.Text = Tema.id_korisnikaNavigation.ime + " " + Tema.id_korisnikaNavigation.prezime;
            RefreshKomentare();
        }

        private void RefreshKomentare()
        {
            dataGridViewKomentari.DataSource = ForumRepozitorij.DohvatiKomentareZaTemu(Tema.id).Select(k => new KomentarViewModel()
            {
                ID = k.id,
                VrijemeKomentiranja = k.vrijeme_objave,
                Komentar = k.tekst,
                Komentator = k.id_korisnikaNavigation.ime + " " + k.id_korisnikaNavigation.prezime
            }).ToList();
        }

        private void btnKomentiraj_Click(object sender, EventArgs e)
        {
            string tekst = txtBoxKomentar.Text.Trim();
            if (tekst == String.Empty)
                return;
            try
            {
                ForumRepozitorij.DodajKomentar(new komentar { id_korisnika = Korisnik.id, id_teme = Tema.id, tekst = tekst });
            }
            catch
            {
                MessageBox.Show("Dogodila se greška");
            }
            RefreshKomentare();
            txtBoxKomentar.Clear();
        }
    }
}
