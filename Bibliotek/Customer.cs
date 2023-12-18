using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Bøker> bokliste { get; set; }
        public List<Bøker> mineBøker {  get; set; }
        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
            mineBøker = new List<Bøker>();

            bokliste = new List<Bøker>
            {
                new Bøker("To Kill a Mockingbird", "Harper Lee", 1960, 1),
                new Bøker("1984", "George Orwell",  1949, 2),
                new Bøker("The Great Gatsby", "F. Scott Fitzgerald",  1925, 3),
                new Bøker("The Catcher in the Rye", " J.D. Salinger ",  1951, 4),
                new Bøker("The Lord of the Rings", "J.R.R. Tolkien",  1954, 5)
            };     
        }

        public void ShowBooks()
        {
            foreach (var bok in bokliste)
            {
                Console.WriteLine($"Tittel: {bok.Title}, Forfatter: {bok.Author}, Utgivelsesår: {bok.Released}, ID nummer: {bok.ID}.");
                
            }
        }

        public void ShowMyBooks()
        {
            foreach(var bok in mineBøker)
            {
                Console.WriteLine($"Tittel: {bok.Title}, Forfatter: {bok.Author}, Utgivelsesår: {bok.Released}, ID nummer: {bok.ID}.");
            }          
        }

        public void LoanBooks()
        {
            Console.WriteLine("Hvilken bok vil du låne idag? Tast inn riktig ID nummer!");
            foreach (var bok in bokliste)
            {
                Console.WriteLine($"Tittel: {bok.Title}, Forfatter: {bok.Author}, Utgivelsesår: {bok.Released}, ID nummer: {bok.ID}.");
            }
            int valg = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Bøker selectedBook = bokliste.Find(bok => bok.ID == valg);

            if (selectedBook != null)
            {
                mineBøker.Add(selectedBook);
                bokliste.Remove(selectedBook);
                foreach (var bok in mineBøker)
                {
                    Console.WriteLine($"Tittel: {bok.Title}, Forfatter: {bok.Author}, Utgivelsesår: {bok.Released}, ID nummer: {bok.ID}.");
                }
            }
            else
            {
                Console.WriteLine("Feil ID");
            }
        }

        public void ReturnBooks()
        {
            Console.WriteLine("Hvilken bok vil du levere tilbake idag? Tast inn riktig ID nummer!");
            foreach (var bok in mineBøker)
            {
                Console.WriteLine($"Tittel: {bok.Title}, Forfatter: {bok.Author}, Utgivelsesår: {bok.Released}, ID nummer: {bok.ID}.");
            }
            int valg = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Bøker selectedBook = bokliste.Find(bok => bok.ID == valg);

            if (selectedBook != null)
            {             
                mineBøker.Remove(selectedBook);
                bokliste.Add(selectedBook);

                foreach (var bok in mineBøker)
                {
                    Console.WriteLine($"Tittel: {bok.Title}, Forfatter: {bok.Author}, Utgivelsesår: {bok.Released}, ID nummer: {bok.ID}.");
                }
            }         
        }
    }
}
