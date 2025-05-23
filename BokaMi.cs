/*
 Klasse: Kall klassen Book. Den skal representere en bok med følgende informasjon:
Tittel (en tekststreng)
Forfatter (en tekststreng)
Antall sider (et heltall)

En privat boolean som indikerer om boken er utlånt eller ikke (startverdi: ikke utlånt)
Konstruktør: Lag en konstruktør som tar inn tittel, forfatter og antall sider som parametere. 
Den skal sette de private feltene for disse og initialisere boken som ikke utlånt.
Egenskaper og metoder:

Lag offentlige egenskaper (properties) for å hente tittel, forfatter og antall sider, 
men disse skal være skrivebeskyttet (kun get, ikke set).

Lag en offentlig metode LoanBook som markerer boken som utlånt hvis den ikke allerede er det.
Hvis boken allerede er utlånt, skal metoden gi en feilmelding (f.eks. ved å skrive til konsollen).

Lag en offentlig metode ReturnBook som markerer boken som ikke utlånt hvis den er utlånt. 
Hvis boken allerede er returnert, skal metoden gi en melding om det.

Lag en offentlig metode GetBookInfo som returnerer en tekststreng med informasjon om boken, 
inkludert tittel, forfatter, antall sider og om boken er utlånt eller ikke.
 */

namespace Books;

public class BokaMi
{
    private string Title { get; }
    private string Author { get; }
    private int Pages { get; }
    private bool Loaned = false;

    public BokaMi(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\n\nBoktittel: {Title}\nForfatter: {Author}\nAntall sider: {Pages}");
        if (Loaned)
        {
            Console.WriteLine("Boka er lånt ut");
        }
        else
        {
            Console.WriteLine("Boka kan lånes");
        }
    }

    public void Loan()
    {
        if (Loaned)
        {
            Console.WriteLine("Boka er allerede lånt ut.");
        }
        else{
            Loaned = true;
            Console.WriteLine($"Du har nå lånt boka {Title}");
        }
    }

    public void Return()
    {
        if (!Loaned)
        {
            Console.WriteLine("Boka er allerede levert.");
        }
        else{
            Loaned = false;
            Console.WriteLine($"Du har nå levert boka {Title}");
        }
    }
}