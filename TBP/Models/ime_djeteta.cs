using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class ime_djeteta
    {
        public ime_djeteta()
        {
            svidanje_imena = new HashSet<svidanje_imena>();
        }

        public int id { get; set; }
        public string ime { get; set; }
        public char spol { get; set; }
        public int? id_pacijenta { get; set; }

        public virtual pacijent id_pacijentaNavigation { get; set; }
        public virtual ICollection<svidanje_imena> svidanje_imena { get; set; }
    }
}
