using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Autoverseny_Lib
{
    public class Aggressziv : Versenyzo
    {
        public Aggressziv(string nev) : base(nev)
        {
            Tipus = "Aggresszív";
        }
    }
}
