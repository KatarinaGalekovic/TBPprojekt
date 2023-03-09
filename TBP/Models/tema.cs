using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class tema
    {
        public tema()
        {
            komentar = new HashSet<komentar>();
        }

        public int id { get; set; }
        public string naslov { get; set; }
        public string sadrzaj { get; set; }
        public DateTime vrijeme_objave { get; set; }
        public int? id_korisnika { get; set; }

        public virtual korisnik id_korisnikaNavigation { get; set; }
        public virtual ICollection<komentar> komentar { get; set; }
    }
}
