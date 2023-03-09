using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class pacijent
    {
        public pacijent()
        {
            biljeska = new HashSet<biljeska>();
            doktor_pacijent = new HashSet<doktor_pacijent>();
            ime_djeteta = new HashSet<ime_djeteta>();
            mjerenje = new HashSet<mjerenje>();
            obavljena_obveza = new HashSet<obavljena_obveza>();
            obveza = new HashSet<obveza>();
            pregled = new HashSet<pregled>();
            svidanje_imena = new HashSet<svidanje_imena>();
        }

        public int id { get; set; }
        public DateTime? datum_zadnje_menstruacije { get; set; }
        public DateTime? predvideni_datum_poroda { get; set; }
        public DateTime datum_rodenja { get; set; }
        public bool zdravstveno_osiguranje { get; set; }

        public virtual korisnik idNavigation { get; set; }
        public virtual ICollection<biljeska> biljeska { get; set; }
        public virtual ICollection<doktor_pacijent> doktor_pacijent { get; set; }
        public virtual ICollection<ime_djeteta> ime_djeteta { get; set; }
        public virtual ICollection<mjerenje> mjerenje { get; set; }
        public virtual ICollection<obavljena_obveza> obavljena_obveza { get; set; }
        public virtual ICollection<obveza> obveza { get; set; }
        public virtual ICollection<pregled> pregled { get; set; }
        public virtual ICollection<svidanje_imena> svidanje_imena { get; set; }
    }
}
