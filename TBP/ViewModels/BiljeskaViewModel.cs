using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.ViewModels
{
    public class BiljeskaViewModel
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Opis { get; set; }
        [DisplayName("Za doktora")]
        public bool ZaDoktora { get; set; }
    }
}
