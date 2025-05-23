

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
