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
using TBP.ViewModels;

namespace TBP
{
    public partial class OdabirPacijentaForm : Form
    {
        public pacijent odabraniPacijent;
        public OdabirPacijentaForm()
        {
            InitializeComponent();
        }

        private void OdabirPacijentaForm_Load(object sender, EventArgs e)
        {
            dataGridViewPacijenti.DataSource = PacijentRepozitorij.SviPacijenti().Select(p => new PacijentViewModel
            {
                ID = p.id,
                Ime = p.idNavigation.ime,
                Prezime = p.idNavigation.prezime,
                DatumRodenja = p.datum_rodenja,
                DatumPredvidenogPoroda = p.predvideni_datum_poroda,
                DatumZadnjeMenstruacije = p.datum_zadnje_menstruacije,
                ZdravstvenoOsiguranje = p.zdravstveno_osiguranje
            }).ToList();
        }


        private void dataGridViewPacijenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            odabraniPacijent = PacijentRepozitorij.DohvatiPacijenta((dataGridViewPacijenti.Rows[e.RowIndex].DataBoundItem as PacijentViewModel).ID);
            this.Close();
        }
    }
}
