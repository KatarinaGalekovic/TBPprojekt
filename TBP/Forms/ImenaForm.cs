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
    public partial class ImenaForm : Form
    {
        pacijent Pacijent;
        List<int> svaSvidanjaImena;
        List<int> m_itemIndexes;
        public ImenaForm(pacijent pacijent)
        {
            Pacijent = pacijent;
            InitializeComponent();
        }

        private void ImenaForm_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            m_itemIndexes = new List<int>();
            svaSvidanjaImena = ImenaRepozitorij.DohvatiSvaSvidanjaPacijenta(Pacijent.id).Select(si=>si.id_imena).ToList();
            List<ime_djeteta> svaImena = ImenaRepozitorij.DohvatiSvaImenaPacijenta(Pacijent.id).OrderBy(i=>!svaSvidanjaImena.Contains(i.id)).ThenBy(i=>i.spol).ThenBy(i=>i.ime).ToList();
            listBoxImena.DataSource = svaImena;
            listBoxImena.ClearSelected();

            for (int i = 0; i < svaImena.Count; i++)
            {
                if (svaSvidanjaImena.Contains(svaImena[i].id))
                    m_itemIndexes.Add(i);
            }
            
        }

        private void btnNovoIme_Click(object sender, EventArgs e)
        {
            string imeDjeteta = txtBoxNovoIme.Text.Trim();
            if (imeDjeteta == String.Empty)
                return;

            ImenaRepozitorij.DodajNovoIme(new ime_djeteta() { id_pacijenta = Pacijent.id, ime = imeDjeteta, spol = rbM.Checked ? 'M' : 'Ž' });

            txtBoxNovoIme.Clear();
            RefreshListBox();
        }

        private void btnOznaciIme_Click(object sender, EventArgs e)
        {
            if (listBoxImena.SelectedItem == null)
                return;

            ime_djeteta imeDjeteta = listBoxImena.SelectedItem as ime_djeteta;

            try
            {
                if (svaSvidanjaImena.Contains(imeDjeteta.id))
                {
                    ImenaRepozitorij.OdznaciImeSvidaMiSe(Pacijent.id, imeDjeteta.id);
                    m_itemIndexes.Remove(listBoxImena.SelectedIndex);
                }
                else
                {
                    ImenaRepozitorij.OznaciImeSvidaMiSe(Pacijent.id, imeDjeteta.id);
                    m_itemIndexes.Add(listBoxImena.SelectedIndex);
                }
            }
            catch
            {
                return;
            }


            listBoxImena.Invalidate(listBoxImena.GetItemRectangle(listBoxImena.SelectedIndex));
            RefreshListBox();
        }

        private void listBoxImena_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool coloring = m_itemIndexes.Contains(e.Index);
            if (coloring)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State, e.ForeColor, Color.Green);
            }


            e.DrawBackground();

            if (e.Index == -1)
                return;

            ime_djeteta imeDjeteta = listBoxImena.Items[e.Index] as ime_djeteta;
            string item = imeDjeteta.spol + "  " + imeDjeteta.ime;
            e.Graphics.DrawString(item, e.Font, coloring ? Brushes.White : Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void listBoxImena_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImena.SelectedItem == null)
                return;

            ime_djeteta imeDjeteta = listBoxImena.SelectedItem as ime_djeteta;

            if (svaSvidanjaImena.Contains(imeDjeteta.id))
            {
                btnOznaciIme.Text = "Odznači";
            }
            else
            {
                btnOznaciIme.Text = "Označi sa 'sviđa mi se'";
            }
        }
    }
}
