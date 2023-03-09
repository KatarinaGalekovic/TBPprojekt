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

        public static List<pregled> DohvatiPregledePacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.Find(pacijentID).pregled.ToList();
            }
        }

        public static List<biljeska> DohvatiBilješkePacijentaZaDoktora(int pacijentID, int doktorID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.pacijent.Find(pacijentID).biljeska.Where(b=>b.id_doktora==doktorID).ToList();
            }
        }
    }
}
