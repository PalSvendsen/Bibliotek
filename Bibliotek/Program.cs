using Bibliotek;

class Program
{
    static void Main()
    {
        Customer customer = new Customer("Pål", 34);
        Bøker bøker = new Bøker("To Kill a Mockingbird", "Harper Lee", 1960, 1);

        while (true) 
        { 
        Console.WriteLine("Velkommen til biblioteket!");
        Console.WriteLine("Hva kan jeg hjelpe  deg med idag?");
        Console.WriteLine("1. Sjekk tilgjengelige bøker");
        Console.WriteLine("2. Mine bøker");
        Console.WriteLine("3. Låne bøker");
        Console.WriteLine("4. Lever tilbake bøker");
        Console.WriteLine("5. Avslutt");

        string valg = Console.ReadLine();

        switch (valg)
        {
            case "1":
                    Console.Clear();
                    customer.ShowBooks();
                break;
                case "2":
                    Console.Clear();
                    customer.ShowMyBooks();
                break;
                case "3":
                    Console.Clear();
                    customer.LoanBooks();
                break;
                case "4":
                    Console.Clear();
                    customer.ReturnBooks();
                break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Takk for besøket!");
                    Environment.Exit(0);
                break;
        }
    }
}
}