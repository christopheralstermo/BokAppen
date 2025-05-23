namespace Books;

public class MinApp
{
    List<BokaMi> bokLista = new List<BokaMi>
    {
        new BokaMi("En bok om det rare", "Chris", 340),
        new BokaMi("En bok om det fine", "Chros", 343),
        new BokaMi("En bok om det lille", "Chras", 320),
        new BokaMi("En bok om det store", "Chrus", 350),
    };

    BokaMi enBok = new BokaMi("En bok om det enkle", "Roar", 340);
    public void Run()
    {
        foreach (var bok in bokLista)
        {
            bok.ShowInfo();
            bok.Loan();
        }

        Console.WriteLine();
        Console.WriteLine();
        bokLista[2].ShowInfo();
    }
}