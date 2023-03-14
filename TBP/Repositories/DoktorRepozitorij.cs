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

        public static List<pacijent> PacijentiOdDoktora(int doktorID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.doktor_pacijent.Include(dp=>dp.id_pacijentaNavigation.idNavigation).Where(dp=>dp.id_doktora==doktorID && dp.vrijedece_vrijeme.UpperBoundInfinite).Select(dp => dp.id_pacijentaNavigation).ToList();
            }
        }

        public static List<doktor_pacijent> SviPrijasnjiDoktoriPacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.doktor_pacijent.Include(dp => dp.id_doktoraNavigation.idNavigation).Where(dp => dp.id_pacijenta == pacijentID && !dp.vrijedece_vrijeme.UpperBoundInfinite).ToList();
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

        public static doktor DoktorOdPacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.doktor_pacijent.Include(dp=>dp.id_doktoraNavigation.idNavigation).Where(dp => dp.id_pacijenta == pacijentID && dp.vrijedece_vrijeme.UpperBoundInfinite).Select(dp => dp.id_doktoraNavigation).FirstOrDefault();
            }
        }
    }
}
