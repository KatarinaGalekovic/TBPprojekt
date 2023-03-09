﻿using System;
using System.Collections.Generic;
using NpgsqlTypes;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class pregled
    {
        public int id { get; set; }
        public string biljeska_doktora { get; set; }
        public NpgsqlRange<DateTime> vrijeme { get; set; }
        public int? id_doktora { get; set; }
        public int? id_pacijenta { get; set; }

        public virtual doktor id_doktoraNavigation { get; set; }
        public virtual pacijent id_pacijentaNavigation { get; set; }
    }
}
