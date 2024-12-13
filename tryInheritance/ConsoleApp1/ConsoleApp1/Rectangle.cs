using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle:Shape
    {
        private double y;

        public Rectangle()
        {
            Console.WriteLine("Empty-Rectangle");
        }

        public Rectangle(double x, double y) : base(x)
        {
            Console.WriteLine("Para-Rectangle");
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
            return GetX() * y;
        }
    }
}
