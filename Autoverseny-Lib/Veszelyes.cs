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
        public Veszelyes(string nev) : base(nev)
        {
            Tipus = "Veszélyes";
        }
    }
}
