using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Autoverseny_Lib
{
    public class Veszelyes : Versenyzo
    {
        public Veszelyes(string nev, int pozicio, Mezony mezony) : base(nev, pozicio, mezony)
        {
            Tipus = "Veszélyes";
        }
    }
}
