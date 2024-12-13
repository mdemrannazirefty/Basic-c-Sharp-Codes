using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wearable:");
            Wearable w = new Wearable(100, DateTime.Now, 50, 100);
            w.DisplayDetails();
            Console.WriteLine("Total Bill: "+w.CalculateTotalBill());


            Console.WriteLine();
            Console.WriteLine("Tablet:");
            Tablet t = new Tablet(20, DateTime.Now, 50, 100);
            t.DisplayDetails();
            Console.WriteLine("Total Bill: "+t.CalculateTotalBill());

            Console.ReadKey();
        }
    }

}
