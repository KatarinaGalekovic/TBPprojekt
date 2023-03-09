using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.Models;

namespace TBP
{
    public static class KorisnikRepozitorij
    {
        public static korisnik PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            using(tbpContext ctx = new tbpContext())
            {
                return ctx.korisnik.Include(k => k.doktor).Include(k => k.pacijent).FirstOrDefault(k => k.korisnicko_ime == korisnickoIme && k.lozinka == lozinka);
            }
        }
    }
}
