using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle : Shape
    {
        private double y;

        public Triangle()
        {
            Console.WriteLine("Empty-Triangle");
        }

        public Triangle(double x, double y) : base(x)
        {
            Console.WriteLine("Para-Triangle");
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
            return GetX() * y*0.5;
        }
    }
}
