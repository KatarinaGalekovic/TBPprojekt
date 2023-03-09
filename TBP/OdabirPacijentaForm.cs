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
    public partial class OdabirPacijentaForm : Form
    {
        public pacijent odabraniPacijent;
        public OdabirPacijentaForm()
        {
            InitializeComponent();
        }

        private void OdabirPacijentaForm_Load(object sender, EventArgs e)
        {
            dataGridViewPacijenti.DataSource = PacijentRepozitorij.SviPacijenti();
        }


        private void dataGridViewPacijenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            odabraniPacijent = dataGridViewPacijenti.Rows[e.RowIndex].DataBoundItem as pacijent;
            this.Close();
        }
    }
}
