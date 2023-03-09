using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class obveza
    {
        public obveza()
        {
            obavljena_obveza = new HashSet<obavljena_obveza>();
        }

        public int id { get; set; }
        public string opis { get; set; }
        public int? id_pacijenta { get; set; }
        public int? id_faze { get; set; }

        public virtual faza id_fazeNavigation { get; set; }
        public virtual pacijent id_pacijentaNavigation { get; set; }
        public virtual ICollection<obavljena_obveza> obavljena_obveza { get; set; }
    }
}
