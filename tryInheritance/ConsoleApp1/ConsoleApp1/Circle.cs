using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle : Shape
    {
        private double y;

        public Circle()
        {
            Console.WriteLine("Empty-Circle");
        }

        public Circle(double y) 
        {
            Console.WriteLine("Para-Circle");
            this.y = y;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetY()
        {
            return y;
        }

        public override double GetArea()
        {
            return GetY() * GetY() * 3.1416;
        }
    }
}
