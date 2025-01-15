using Autoverseny_Lib;

int korokSzama;
int versenyzokSzama;
Mezony mezony = new(VersenyzokBeolvas("versenyzok.txt"));

IEnumerable<Versenyzo> VersenyzokBeolvas(string fajlnev)
{
    string[] elsoSor= File.ReadAllLines(fajlnev).First().Split(" ");
    korokSzama = int.Parse(elsoSor[0]);
    versenyzokSzama = int.Parse(elsoSor[1]);
    foreach (var item in File.ReadAllLines(fajlnev))
    {
        string[] adatSor = item.Split(" ");
        int kategoria = int.Parse(adatSor[0]);
        string nev = adatSor[1];
        if (kategoria == 1)
        {
            yield return new Aggressziv(nev);
        }
        if (kategoria == 2)
        {
            yield return new Aggressziv(nev);
        }
        if (kategoria == 3)
        {
            yield return new Aggressziv(nev);
        }
        if (kategoria == 4)
        {
            yield return new Aggressziv(nev);
        }

    }
}