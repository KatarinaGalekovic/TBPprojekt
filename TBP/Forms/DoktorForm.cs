﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.Forms;
using TBP.Models;
using TBP.ViewModels;

namespace TBP
{
    public partial class DoktorForm : Form
    {
        doktor Doktor;
        public DoktorForm(doktor doktor)
        {
            Doktor = doktor;
            InitializeComponent();
            lblDobrodosli.Text = $"Dobrodošli, {doktor.idNavigation.ime}";
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewPacijenti.DataSource = DoktorRepozitorij.PacijentiOdDoktora(Doktor.id).Select(p => new PacijentViewModel
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

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            OdabirPacijentaForm odabirPacijentaForm = new OdabirPacijentaForm();
            odabirPacijentaForm.ShowDialog();
            if (odabirPacijentaForm.odabraniPacijent != null)
            {
                DoktorRepozitorij.DodajPacijentaDoktoru(odabirPacijentaForm.odabraniPacijent.id, Doktor.id);
                RefreshGrid();
            }
        }

        private void dataGridViewPacijenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PacijentViewModel odabraniPacijent = dataGridViewPacijenti.Rows[e.RowIndex].DataBoundItem as PacijentViewModel;

            OpisPacijenta opisPacijentaForm = new OpisPacijenta(PacijentRepozitorij.DohvatiPacijenta(odabraniPacijent.ID), Doktor);
            opisPacijentaForm.Show();
        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            ForumForm forumForm = new ForumForm(Doktor.idNavigation);
            forumForm.Show();
        }
    }
}
