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

            Triangle t1 = new Triangle();
            t1.SetX(12.0);
            t1.SetY(5.0);
            Console.WriteLine("T1 H: " + t1.GetX());
            Console.WriteLine("T1 W: " + t1.GetY());
            Console.WriteLine("T1 A: " + t1.GetArea());
            Console.WriteLine();

            Triangle t2 = new Triangle(10.0, 9.0);
            Console.WriteLine("T2 H: " + t1.GetX());
            Console.WriteLine("T2 W: " + t1.GetY());
            Console.WriteLine("T2 A: " + t1.GetArea());
            Console.WriteLine();

            Square s1 = new Square();
            s1.SetY(5.0);
            Console.WriteLine("S1 H: " + s1.GetY());
            Console.WriteLine("S1 A: " + s1.GetArea());
            Console.WriteLine();

            Square s2 = new Square(6.0);
            Console.WriteLine("S2 H: " + s1.GetY());
            Console.WriteLine("S2 A: " + s1.GetArea());
            Console.WriteLine();

            Circle c1 = new Circle(5.0);
            //s1.SetY(5.0);
            Console.WriteLine("C1 H: " + c1.GetY());
            Console.WriteLine("C1 A: " + c1.GetArea());
            Console.WriteLine();

            


            Console.ReadKey();
        }
    }
}
