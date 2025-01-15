namespace Autoverseny_Lib
{
    public class Versenyzo
    {
        public Versenyzo(string nev, int pozicio, Mezony mezony)
        {
            Nev = nev;
            Tank = 100;
            Pozicio = pozicio;
            Mezony = mezony;
        }
        public int Tank { get; protected set; }
        public string Nev { get; init; }
        public string Tipus { get; init; }
        public int Pozicio { get; set; }
        public Mezony Mezony { get; init; }
        public virtual void Eloz()
        {
        }
        public virtual void VersenyzoKor(int versenyKor)
        {
        }
        public void Tankol()
        {
            Tank = 100;
            if (Mezony.VersenyzokSzama < 5) Pozicio = Mezony.VersenyzokSzama;
            else Pozicio -= 5;
        }
        public override string ToString()
        {
            return $"Név: {Nev}, Típus: {Tipus}";
        }
    }
}
