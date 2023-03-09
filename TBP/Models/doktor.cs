using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class doktor
    {
        public doktor()
        {
            biljeska = new HashSet<biljeska>();
            doktor_pacijent = new HashSet<doktor_pacijent>();
            pregled = new HashSet<pregled>();
        }

        public int id { get; set; }
        public string adresa_ordinacije { get; set; }

        public virtual korisnik idNavigation { get; set; }
        public virtual ICollection<biljeska> biljeska { get; set; }
        public virtual ICollection<doktor_pacijent> doktor_pacijent { get; set; }
        public virtual ICollection<pregled> pregled { get; set; }
    }
}
