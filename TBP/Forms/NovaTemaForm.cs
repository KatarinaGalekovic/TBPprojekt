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

namespace TBP.Forms
{
    public partial class NovaTemaForm : Form
    {
        korisnik Korisnik;
        public NovaTemaForm(korisnik korisnik)
        {
            Korisnik = korisnik;
            InitializeComponent();
        }

        private void btnOtvoriTemu_Click(object sender, EventArgs e)
        {
            string naslovTeme = txtBoxNaslov.Text;
            string tekstTeme = txtBoxTekst.Text;
            try
            {
                ForumRepozitorij.OtvoriNovuTemu(new tema() { id_korisnika = Korisnik.id, naslov = naslovTeme, sadrzaj = tekstTeme });
            } catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return;
            }
            this.Close();
        }
    }
}
