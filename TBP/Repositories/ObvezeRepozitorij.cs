using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.Models;

namespace TBP.Repositories
{
    public static class ObvezeRepozitorij
    {
        public static List<faza> DohvatiSveFaze()
        {
            using(tbpContext ctx = new tbpContext())
            {
                return ctx.faza.ToList();
            }
        }

        public static List<obveza> DohvatiSveObvezeZaFazuZaPacijenta(int fazaID, int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.obveza.Where(o => o.id_faze == fazaID && (!o.id_pacijenta.HasValue || o.id_pacijenta.Value == pacijentID)).ToList();
            }

        }

        public static List<obavljena_obveza> DohvatiObavljeneObvezePacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.obavljena_obveza.Where(oo => oo.id_pacijenta == pacijentID).ToList();
            }
        }

        public static void OznaciObvezuObavljenom(int pacijentID, int obvezaID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.obavljena_obveza.Add(new obavljena_obveza() { id_pacijenta=pacijentID, id_obveze=obvezaID});
                ctx.SaveChanges();
            }
        }

        public static void OdznaciObvezuObavljenom(int pacijentID, int obvezaID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.obavljena_obveza.Remove(ctx.obavljena_obveza.FirstOrDefault(oo=>oo.id_pacijenta==pacijentID && oo.id_obveze==obvezaID));
                ctx.SaveChanges();
            }
        }

        public static void DodajNovuObvezuZaPacijenta(obveza obveza)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.obveza.Add(obveza);
                ctx.SaveChanges();
            }
        }
    }
}
