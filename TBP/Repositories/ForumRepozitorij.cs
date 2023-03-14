using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.Models;

namespace TBP.Repositories
{
    public static class ForumRepozitorij
    {
        public static void OtvoriNovuTemu(tema tema)
        {
            using(tbpContext ctx = new tbpContext())
            {
                ctx.tema.Add(tema);
                ctx.SaveChanges();
            }
        }

        public static List<tema> DohvatiSveTeme()
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.tema.Include(t=>t.id_korisnikaNavigation).OrderByDescending(t=>t.vrijeme_objave).ToList();
            }
        }

        public static void DodajKomentar(komentar komentar)
        {
            using (tbpContext ctx = new tbpContext())
            {
                ctx.komentar.Add(komentar);
                ctx.SaveChanges();
            }
        }

        public static List<komentar> DohvatiKomentareZaTemu(int temaID)
        {
            using (tbpContext ctx = new tbpContext())
            {
                return ctx.komentar.Include(k=>k.id_korisnikaNavigation).Where(k => k.id_teme == temaID).OrderByDescending(k=>k.vrijeme_objave).ToList();
            }
        }
    }
}
