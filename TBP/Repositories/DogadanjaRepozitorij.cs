using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.Models;

namespace TBP.Repositories
{
    public static class DogadanjaRepozitorij
    {

        public static List<dogadanja> DohvatiSvaDogadanja()
        {
            using(tbpContext ctx = new tbpContext())
            {
                return ctx.dogadanja.OrderBy(d=>d.tjedan).ToList();
            }
        }
    }
}
