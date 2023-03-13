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

namespace TBP.Forms
{
    public partial class PacijentForm : Form
    {
        pacijent Pacijent;
        public PacijentForm(pacijent pacijent)
        {
            Pacijent = pacijent;
            InitializeComponent();
        }

        private void PacijentForm_Load(object sender, EventArgs e)
        {
            lblDobrodosli.Text = $"Dobrodošli, {Pacijent.idNavigation.ime}";
            RefreshGrids();
            RefreshMjerenja();
        }

        private void RefreshGrids()
        {
            dataGridViewPregledi.DataSource = PacijentRepozitorij.DohvatiPregledePacijenta(Pacijent.id).Select(p=>new PregledViewModel()
            {
                ID=p.id,
                Pocetak=p.vrijeme.LowerBound,
                Trajanje=(p.vrijeme.UpperBound-p.vrijeme.LowerBound).Minutes,
                BiljeskaDoktora=p.biljeska_doktora
            }).ToList();
            dataGridViewBiljeske.DataSource = PacijentRepozitorij.DohvatiBilješkePacijenta(Pacijent.id).Select(b=>new BiljeskaViewModel()
            {
                ID=b.id,
                Opis=b.opis,
                ZaDoktora=b.id_doktora.HasValue
            }).ToList(); 
        }

        private void RefreshMjerenja()
        {
            mjerenje zadnjeMjerenje = PacijentRepozitorij.ZadnjeMjerenje(Pacijent.id);
            

            if (zadnjeMjerenje == null)
            {
                lblMjerenje.Text = "Još nije evidentirano ni jedno mjerenje";
                return;
            }

            decimal prvaTezina = PacijentRepozitorij.PrvoMjerenje(Pacijent.id).tezina;
            decimal zadnjaTezina = zadnjeMjerenje.tezina;

            lblMjerenje.Text = zadnjaTezina.ToString() + " kg    ";


            decimal razlika = Math.Abs(decimal.Round(prvaTezina - zadnjaTezina, 2));
            decimal postotak = Convert.ToInt32((razlika / prvaTezina) * 100);
            if (prvaTezina > zadnjaTezina)
            {
                lblMjerenje.Text += $"Smršavili ste za {razlika} kg ({postotak}%) od početka mjerenja.";
            }
            else if(prvaTezina < zadnjaTezina)
            {
                lblMjerenje.Text += $"Dobili ste {razlika} kg ({postotak}%) od početka mjerenja.";
            }
        }

        private void btnNovoMjerenje_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBoxMjerenje.Text, out decimal mjerenje))
                return;
            try
            {
                PacijentRepozitorij.NovoMjerenje(new mjerenje() { tezina=mjerenje, id_pacijenta=Pacijent.id});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Greška!");
            }
            txtBoxMjerenje.Clear();
            RefreshMjerenja();
        }

        private void btnDodajBiljesku_Click(object sender, EventArgs e)
        {
            BiljeskaForm biljeskaForm = new BiljeskaForm(Pacijent.id);
            biljeskaForm.ShowDialog();
            RefreshGrids();
        }

        private void btnObveze_Click(object sender, EventArgs e)
        {
            ObvezeForm obvezeForm = new ObvezeForm(Pacijent);
            obvezeForm.Show();
        }

        private void btnImenadjece_Click(object sender, EventArgs e)
        {
            ImenaForm imenaForm = new ImenaForm(Pacijent);
            imenaForm.Show();
        }
    }
}
