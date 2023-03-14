using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.ViewModels
{
    internal class PijasnjiDoktorViewModel
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Ime { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
    }
}
