using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class korisnik
    {
        public korisnik()
        {
            komentar = new HashSet<komentar>();
            tema = new HashSet<tema>();
        }

        public int id { get; set; }
        public string email { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }

        public virtual doktor doktor { get; set; }
        public virtual pacijent pacijent { get; set; }
        public virtual ICollection<komentar> komentar { get; set; }
        public virtual ICollection<tema> tema { get; set; }
    }
}
