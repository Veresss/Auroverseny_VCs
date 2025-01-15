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
        public void Kor()
        {
            Tank -= 5;
        }
    }
}
