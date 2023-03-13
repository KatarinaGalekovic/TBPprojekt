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
    public partial class DogadanjaForm : Form
    {
        int trenutniIndeks = 0;
        List<dogadanja> svaDogadanja;
        public DogadanjaForm()
        {
            svaDogadanja = DogadanjaRepozitorij.DohvatiSvaDogadanja();
            InitializeComponent();
        }

        private void DogadanjaForm_Load(object sender, EventArgs e)
        {
            RefreshTekst();
        }

        private void RefreshTekst()
        {
            dogadanja trenutnaDogadanja = svaDogadanja[trenutniIndeks];
            lblTjedan.Text = trenutnaDogadanja.tjedan.ToString() + ". tjedan";


            lblTekst.Text = "Majka:\n" + trenutnaDogadanja.tekst_majka + "\n\nDijete:\n" + trenutnaDogadanja.tekst_dijete;

            if (trenutniIndeks == 0)
                btnPrije.Enabled = false;
            else
                btnPrije.Enabled = true;

            if (trenutniIndeks == svaDogadanja.Count - 1)
                btnPoslije.Enabled = false;
            else
                btnPoslije.Enabled = true;
        }

        private void btnPrije_Click(object sender, EventArgs e)
        {
            trenutniIndeks--;
            RefreshTekst();
        }

        private void btnPoslije_Click(object sender, EventArgs e)
        {
            trenutniIndeks++;
            RefreshTekst();
        }
    }
}
