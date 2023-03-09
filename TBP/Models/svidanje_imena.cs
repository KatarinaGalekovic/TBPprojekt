using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class svidanje_imena
    {
        public int id_pacijenta { get; set; }
        public int id_imena { get; set; }

        public virtual ime_djeteta id_imenaNavigation { get; set; }
        public virtual pacijent id_pacijentaNavigation { get; set; }
    }
}
