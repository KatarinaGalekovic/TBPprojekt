using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.ViewModels
{
    public class PregledViewModel
    {
        [Browsable(false)]
        public int ID { get; set; }
        [DisplayName("Početak")]
        public DateTime Pocetak { get; set; }
        [DisplayName("Trajanje (u min)")]
        public int Trajanje { get; set; }
        [DisplayName("Bilješka doktora")]
        public string BiljeskaDoktora { get; set; }
    }
}
