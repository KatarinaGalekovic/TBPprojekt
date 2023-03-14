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
    public partial class PrijasnjiDoktoriForm : Form
    {
        public PrijasnjiDoktoriForm(pacijent pacijent)
        {
            InitializeComponent();
            dataGridViewDoktori.DataSource = DoktorRepozitorij.SviPrijasnjiDoktoriPacijenta(pacijent.id).Select(d=>new PijasnjiDoktorViewModel()
            {
                ID= d.id_doktoraNavigation.id,
                Ime = d.id_doktoraNavigation.idNavigation.ime + " " + d.id_doktoraNavigation.idNavigation.prezime,
                Od = d.vrijedece_vrijeme.LowerBound,
                Do = d.vrijedece_vrijeme.UpperBound
            }).ToList();
        }
    }
}
