using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> ItemListe = new List<Item>();

            Book Herr_der_Nacht = new Book(50.00m, 1, "Herr der Nacht", "Author1", "5678a", Category.Child);
            Newspaper Heute = new Newspaper(10.99m, 2, "Heute", new DateTime(2020, 9, 15));
            AudioBook Audible = new AudioBook(5.99m, 3, "Drei???", "Author2", "54321b", 60, Category.Thriller);

            Console.WriteLine(Herr_der_Nacht.ToString());
            Console.WriteLine(Heute.ToString());
            Console.WriteLine(Audible.ToString());


            Console.ReadKey();
        }
    }
}
