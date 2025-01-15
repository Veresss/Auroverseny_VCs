namespace Autoverseny_Lib
{
    public class Versenyzo
    {
        public Versenyzo(string nev)
        {
            Nev = nev;
            Tank = 100;
        }
        public int Tank { get; protected set; }
        public string Nev { get; init; }
        public string Tipus { get; init; }
        public void Elozes()
        {

        }
        public void Kor()
        {
            Tank -= 5;
        }
        public override string ToString()
        {
            return $"Név: {Nev}, Típus: {Tipus}";
        }
    }
}
