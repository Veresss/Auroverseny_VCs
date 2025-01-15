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
        public Mezony(IEnumerable<Versenyzo> versenyzok, int versenyzokSzama)
        {
            mezony.AddRange(versenyzok);
            VersenyzokSzama = versenyzokSzama;
        }
        public int VersenyKor { get; protected set; } = 1;
        public int VersenyzokSzama { get; init; }
        public void MezonyKor()
        {
            mezony.ForEach(m => 
            { 
                m.VersenyzoKor(VersenyKor); 
            });
        }
        public override string ToString()
        {
            return String.Join("\n", mezony);
        }
        public Versenyzo this[int pozicio]
        {
            get
            {
                return mezony.Find(x => x.Pozicio == pozicio);
            }
        }
    }
}
