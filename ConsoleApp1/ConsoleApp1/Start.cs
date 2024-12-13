using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Start
    {
        static void Main(string[] args)
        {
            StoryBook[] books = new StoryBook[3];

            books[0] = new StoryBook("Advanture", "Story", "EFTY", 20.0, 100, "Poem");
            books[1] = new StoryBook("Advanture", "Story", "EFTY", 50.0, 100, "Poem");
            books[2] = new StoryBook("Advanture", "Story", "EFTY", 70.0, 100, "Poem");

            books[0].AddQuantity(10);
            books[1].AddQuantity(20);
            books[2].AddQuantity(30);

            books[0].SellQuantity(30);
            books[1].SellQuantity(20);
            books[2].SellQuantity(10);

            foreach (StoryBook book in books)
            {
                if (book != null)
                {
                    Console.WriteLine();
                    book.ShowDetails();
                    Console.WriteLine();
                }
            }
            
            Console.ReadKey();
        }
    }
}

