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

namespace TBP.Forms
{
    public partial class BiljeskaForm : Form
    {
        biljeska Biljeska;
        public BiljeskaForm(int pacijentID)
        {
            Biljeska = new biljeska();
            Biljeska.id_pacijenta = pacijentID;
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cbPrikazatiDoktoru.Checked)
            {
                Biljeska.id_doktora = PacijentRepozitorij.DohvatiDoktora(Biljeska.id_pacijenta.Value).id;
            }

            Biljeska.opis = txtBoxOpis.Text;

            PacijentRepozitorij.DodajBilješku(Biljeska);
            this.Close();
        }
    }
}
