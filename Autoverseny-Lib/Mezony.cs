using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverseny_Lib
{
    public class Mezony
    {
        List<Versenyzo> mezony = [];
        public Mezony(IEnumerable<Versenyzo> versenyzok)
        {
            mezony.AddRange(versenyzok);
        }
    }
}
