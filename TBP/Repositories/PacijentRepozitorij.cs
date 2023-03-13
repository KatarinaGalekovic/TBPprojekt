using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.Models;

namespace TBP
{
    public static class PacijentRepozitorij
    {
        public static List<pacijent> SviPacijenti()
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.ToList();
            }
        }

        public static pacijent DohvatiPacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.Include(p=>p.idNavigation).FirstOrDefault(p=>p.id==pacijentID);
            }
        }

        public static List<pregled> DohvatiPregledePacijentaZaDoktora(int pacijentID, int doktorID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.Include(p=>p.pregled).FirstOrDefault(p=>p.id==pacijentID).pregled.Where(p=>p.id_doktora==doktorID).ToList();
            }
        }

        public static List<pregled> DohvatiPregledePacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.Include(p => p.pregled).FirstOrDefault(p => p.id == pacijentID).pregled.ToList();
            }
        }

        public static List<biljeska> DohvatiBilješkePacijentaZaDoktora(int pacijentID, int doktorID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.biljeska.Where(b => b.id_doktora == doktorID && b.id_pacijenta == pacijentID).ToList();
            }
        }

        public static List<biljeska> DohvatiBilješkePacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.Where(p => p.id == pacijentID).Select(p => p.biljeska).FirstOrDefault().ToList();
            }
        }

        public static void NovoMjerenje(mjerenje mjerenje)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.Database.ExecuteSqlRaw(
                    $"INSERT INTO mjerenje(id_pacijenta, tezina) VALUES ({mjerenje.id_pacijenta}, {mjerenje.tezina})");
            }
        }

        public static mjerenje ZadnjeMjerenje(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.mjerenje.FirstOrDefault(m=>m.id_pacijenta==pacijentID && m.vrijedece_vrijeme.UpperBoundInfinite);
            }
        }

        public static mjerenje PrvoMjerenje(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.mjerenje.Where(m => m.id_pacijenta == pacijentID).OrderBy(m=>m.vrijedece_vrijeme).FirstOrDefault();
            }
        }


        public static doktor DohvatiDoktora(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.doktor_pacijent.Include(dp => dp.id_doktoraNavigation).Include(dp => dp.id_pacijentaNavigation).Where(dp => dp.id_pacijenta == pacijentID && dp.vrijedece_vrijeme.UpperBoundInfinite).Select(dp=>dp.id_doktoraNavigation).FirstOrDefault();
            }
        }

        public static void DodajBilješku(biljeska biljeska)
        {
            using(tbpContext ctx = new tbpContext())
            {
                ctx.biljeska.Add(biljeska);
                ctx.SaveChanges();
            }
        }
    }
}
