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
    public partial class PregledForm : Form
    {
        pregled Pregled;
        public PregledForm(int pacijentID, int doktorID)
        {
            Pregled = new pregled();
            Pregled.id_pacijenta= pacijentID;
            Pregled.id_doktora = doktorID;
            InitializeComponent();
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            DateTime pocetak = dateTimePickerVrijeme.Value;
            if (!int.TryParse(txtBoxTrajanje.Text, out int trajanje)) {
                MessageBox.Show("Molimo upišite ispravan broj minuta trajanja pregleda!");
                return;
            }
            Pregled.vrijeme = new NpgsqlTypes.NpgsqlRange<DateTime>(pocetak, pocetak.AddMinutes(trajanje));
            Pregled.biljeska_doktora = txtBoxBiljeska.Text;

            try
            {
                DoktorRepozitorij.DodajPregled(Pregled);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Greška!");
                return;
            }

            this.Close();
        }
    }
}
