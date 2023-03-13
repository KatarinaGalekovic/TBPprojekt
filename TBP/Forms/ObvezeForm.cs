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
    public partial class ObvezeForm : Form
    {
        pacijent Pacijent;
        int trenutniIndeks = 0;
        List<faza> sveFaze;
        List<int> sveObavljeneObveze;
        List<int> m_itemIndexes;
        public ObvezeForm(pacijent pacijent)
        {
            Pacijent = pacijent;
            sveFaze = ObvezeRepozitorij.DohvatiSveFaze();
            InitializeComponent();
        }

        private void ObvezeForm_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }


        private void RefreshListBox()
        {
            m_itemIndexes = new List<int>();
            List<obveza> sveObveze = ObvezeRepozitorij.DohvatiSveObvezeZaFazuZaPacijenta(sveFaze[trenutniIndeks].id, Pacijent.id);
            sveObavljeneObveze = ObvezeRepozitorij.DohvatiObavljeneObvezePacijenta(Pacijent.id).Select(oo=>oo.id_obveze).ToList();
            listBoxObveze.DataSource = sveObveze;
            listBoxObveze.ClearSelected();

            for(int i=0;i<sveObveze.Count;i++)
            {
                if (sveObavljeneObveze.Contains(sveObveze[i].id))
                    m_itemIndexes.Add(i);
            }
            if (trenutniIndeks == 0)
                btnPrije.Enabled = false;
            else
                btnPrije.Enabled = true;

            if(trenutniIndeks == sveFaze.Count - 1)
                btnPoslije.Enabled = false;
            else
                btnPoslije.Enabled = true;

            lblFaza.Text = sveFaze[trenutniIndeks].naziv;
        }

        private void btnPrije_Click(object sender, EventArgs e)
        {
            trenutniIndeks--;
            RefreshListBox();
        }

        private void btnPoslije_Click(object sender, EventArgs e)
        {
            trenutniIndeks++;
            RefreshListBox();
        }

        private void btnOznaciObavljeno_Click(object sender, EventArgs e)
        {
            if(listBoxObveze.SelectedItem==null)
                return;

            obveza obveza = listBoxObveze.SelectedItem as obveza;

            try
            {
                if (sveObavljeneObveze.Contains(obveza.id))
                {
                    ObvezeRepozitorij.OdznaciObvezuObavljenom(Pacijent.id, obveza.id);
                    m_itemIndexes.Remove(listBoxObveze.SelectedIndex);
                }
                else
                {
                    ObvezeRepozitorij.OznaciObvezuObavljenom(Pacijent.id, obveza.id);
                    m_itemIndexes.Add(listBoxObveze.SelectedIndex);
                }
            } catch
            {
                return;
            }

            
            listBoxObveze.Invalidate(listBoxObveze.GetItemRectangle(listBoxObveze.SelectedIndex));
            RefreshListBox();
        }

        private void listBoxObveze_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool coloring = m_itemIndexes.Contains(e.Index);
            if (coloring)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State, e.ForeColor, Color.Green);
            }


            e.DrawBackground();

            string item = (listBoxObveze.Items[e.Index] as obveza).opis;
            e.Graphics.DrawString(item, e.Font,  coloring ? Brushes.White : Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void listBoxObveze_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxObveze.SelectedItem == null)
                return;

            obveza obveza = listBoxObveze.SelectedItem as obveza;

            if (sveObavljeneObveze.Contains(obveza.id))
            {
                btnOznaciObavljeno.Text = "Odznači kao obavljeno";
            }
            else
            {
                btnOznaciObavljeno.Text = "Označi kao obavljeno";
            }
        }

        private void btnDodajObvezu_Click(object sender, EventArgs e)
        {
            string opisObveze = txtBoxNovaObveza.Text.Trim();
            if (opisObveze == String.Empty)
                return;
            obveza novaObveza = new obveza();
            novaObveza.id_faze = sveFaze[trenutniIndeks].id;
            novaObveza.id_pacijenta = Pacijent.id;
            novaObveza.opis = opisObveze;

            ObvezeRepozitorij.DodajNovuObvezuZaPacijenta(novaObveza);
            txtBoxNovaObveza.Clear();
            RefreshListBox();
        }
    }
}
