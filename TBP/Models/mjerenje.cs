using System;
using System.Collections.Generic;
using NpgsqlTypes;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class mjerenje
    {
        public decimal tezina { get; set; }
        public int id_pacijenta { get; set; }
        public NpgsqlRange<DateTime> vrijedece_vrijeme { get; set; }

        public virtual pacijent id_pacijentaNavigation { get; set; }
    }
}
