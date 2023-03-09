using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class faza
    {
        public faza()
        {
            obveza = new HashSet<obveza>();
        }

        public int id { get; set; }
        public string naziv { get; set; }

        public virtual ICollection<obveza> obveza { get; set; }
    }
}
