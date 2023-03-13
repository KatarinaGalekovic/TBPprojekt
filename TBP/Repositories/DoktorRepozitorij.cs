using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.Models;
using TBP.ViewModels;

namespace TBP
{
    public static class DoktorRepozitorij
    {
        public static void DodajPacijentaDoktoru(int pacijentID, int doktorID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.Database.ExecuteSqlRaw(
                    $"INSERT INTO doktor_pacijent(id_doktora,id_pacijenta) VALUES ({doktorID}, {pacijentID})");
            }
        }

        public static List<PacijentViewModel> PacijentiOdDoktora(int doktorID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.doktor_pacijent.Where(dp=>dp.id_doktora==doktorID && dp.vrijedece_vrijeme.UpperBoundInfinite).Select(dp => dp.id_pacijentaNavigation).Select(p=>new PacijentViewModel
                {
                    ID = p.id,
                    Ime = p.idNavigation.ime,
                    Prezime = p.idNavigation.prezime,
                    DatumRodenja = p.datum_rodenja,
                    DatumPredvidenogPoroda = p.predvideni_datum_poroda,
                    DatumZadnjeMenstruacije = p.datum_zadnje_menstruacije,
                    ZdravstvenoOsiguranje = p.zdravstveno_osiguranje
                }).ToList();
            }
        }

        public static void DodajPregled(pregled pregled)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.pregled.Add(pregled);
                ctx.SaveChanges();
            }
        }
    }
}
