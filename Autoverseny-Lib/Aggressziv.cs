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
        public Aggressziv(string nev, int pozicio, Mezony mezony) : base(nev, pozicio, mezony)
        {
            Tipus = "Aggresszív";
        }
        public int SikertelenElozes { get; private set; } = 0;
        public override void VersenyzoKor(int versenyKor)
        {
            Tank -= 5;
            if (versenyKor % 2 == 0) Eloz();
            if (Tank < 10) Tankol();
        }
        public override void Eloz()
        {
            if (SikertelenElozes == 3 && Pozicio > 1)
            {
                Mezony[Pozicio + 1].Pozicio -= 1;
                Pozicio += 1;
            }
            else
            {
                SikertelenElozes += 1;
            }
        }
    }
}
