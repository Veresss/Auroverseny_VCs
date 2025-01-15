using Autoverseny_Lib;

string[] elsoSor = File.ReadAllLines("versenyzok.txt").First().Split(" ");
int korokSzama = int.Parse(elsoSor[0]);
int versenyzokSzama = int.Parse(elsoSor[1]);
Mezony mezony = new(VersenyzokBeolvas("versenyzok.txt"));
Console.WriteLine(mezony);
Console.WriteLine(korokSzama);
Console.WriteLine(versenyzokSzama);

Console.WriteLine();
IEnumerable<Versenyzo> VersenyzokBeolvas(string fajlnev)
{
    foreach (var item in File.ReadAllLines(fajlnev).Skip(1))
    {
        string[] adatSor = item.Split(" ");
        int kategoria = int.Parse(adatSor[1]);
        string nev = adatSor[0];
        if (kategoria == 1)
        {
            yield return new Aggressziv(nev); 
        }
        if (kategoria == 2)
        {
            yield return new Lenduletes(nev);
        }
        if (kategoria == 3)
        {
            yield return new Veszelyes(nev);
        }
        if (kategoria == 4)
        {
            yield return new Ovatos(nev);
        }
    }
}