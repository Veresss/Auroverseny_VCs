using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Autoverseny_Lib
{
    public class Ovatos : Versenyzo
    {
        public Ovatos(string nev) : base(nev)
        {
            Tipus = "Óvatos";
        }
    }
}
