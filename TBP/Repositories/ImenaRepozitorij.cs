using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.Models;

namespace TBP.Repositories
{
    public static class ImenaRepozitorij
    {
        public static List<svidanje_imena> DohvatiSvaSvidanjaPacijenta(int pacijentID)
        {
            using(tbpContext ctx = new tbpContext())
            {
                return ctx.svidanje_imena.Where(si=>si.id_pacijenta==pacijentID).ToList();
            }
        }

        public static List<ime_djeteta> DohvatiSvaImenaPacijenta(int pacijentID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.ime_djeteta.Where(si => !si.id_pacijenta.HasValue || si.id_pacijenta.Value == pacijentID).ToList();
            }
        }

        public static void OznaciImeSvidaMiSe(int pacijentID, int imeID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.svidanje_imena.Add(new svidanje_imena() { id_imena=imeID, id_pacijenta=pacijentID});
                ctx.SaveChanges();
            }
        }

        public static void OdznaciImeSvidaMiSe(int pacijentID, int imeID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.svidanje_imena.Remove(ctx.svidanje_imena.FirstOrDefault(si=>si.id_pacijenta==pacijentID && si.id_imena==imeID));
                ctx.SaveChanges();
            }
        }

        public static void DodajNovoIme(ime_djeteta imeDjeteta)
        {
            using (tbpContext ctx = new tbpContext())
            {
                if (ctx.ime_djeteta.FirstOrDefault(id => id.ime == imeDjeteta.ime) != null)
                    return;
                ctx.ime_djeteta.Add(imeDjeteta);
                ctx.SaveChanges();
            }
        }
    }
}
