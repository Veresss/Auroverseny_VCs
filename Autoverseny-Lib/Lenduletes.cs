using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoverseny_Lib
{
    public class Lenduletes : Versenyzo
    {
        public Lenduletes(string nev, int pozicio, Mezony mezony) : base(nev, pozicio, mezony)
        {
            Tipus = "Lednületes";
        }
    }
}
