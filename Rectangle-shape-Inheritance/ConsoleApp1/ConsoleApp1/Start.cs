using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Start
    {
   
        public static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.SetX(12.0);
            r1.SetY(10.0);
            Console.WriteLine("R1 L: " + r1.GetX());
            Console.WriteLine("R1 W: " + r1.GetY());
            Console.WriteLine("R1 A: " + r1.GetArea());
            Console.WriteLine();

            Rectangle r2 = new Rectangle(10.0, 9.0);
            Console.WriteLine("R2 L: " + r2.GetX());
            Console.WriteLine("R2 W: " + r2.GetY());
            Console.WriteLine("R2 A: " + r2.GetArea());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
