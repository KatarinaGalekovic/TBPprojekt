using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.ViewModels
{
    public class KomentarViewModel
    {
        [Browsable(false)]
        public int ID { get; set; }
        [DisplayName("Vrijeme komentiranja")]
        public DateTime VrijemeKomentiranja { get; set; }
        public string Komentator { get; set; }
        public string Komentar { get; set; }
    }
}
