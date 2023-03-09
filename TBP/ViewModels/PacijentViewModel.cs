using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBP.ViewModels
{
    public class PacijentViewModel
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [DisplayName("Datum rođenja")]
        public DateTime DatumRodenja { get; set; }
        [DisplayName("Zdravstveno osiguranje")]
        public bool ZdravstvenoOsiguranje { get; set; }
        [DisplayName("Datum zadnje menstruacije")]
        public DateTime? DatumZadnjeMenstruacije { get; set; }
        [DisplayName("Datum predviđenog poroda")]
        public DateTime? DatumPredvidenogPoroda { get; set; }
    }
}
