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
            dataGridViewPregledi.DataSource = PacijentRepozitorij.DohvatiPregledePacijenta(Pacijent.id);
            dataGridViewBiljeske.DataSource = PacijentRepozitorij.DohvatiBilješkePacijentaZaDoktora(Pacijent.id, Doktor.id);
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
    }
}
