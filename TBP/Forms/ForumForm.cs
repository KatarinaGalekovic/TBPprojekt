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
    public partial class ForumForm : Form
    {
        korisnik Korisnik;
        public ForumForm(korisnik korisnik)
        {
            Korisnik = korisnik;
            InitializeComponent();
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxTeme.DataSource = ForumRepozitorij.DohvatiSveTeme();
        }

        private void btnNovaTema_Click(object sender, EventArgs e)
        {
            NovaTemaForm novaTemaForm = new NovaTemaForm(Korisnik);
            novaTemaForm.ShowDialog();
            RefreshListBox();
        }

        private void listBoxTeme_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTeme.SelectedItem == null)
                return;

            tema tema = listBoxTeme.SelectedItem as tema;

            TemaForm temaForm = new TemaForm(tema, Korisnik);
            temaForm.Show();
        }
    }
}
