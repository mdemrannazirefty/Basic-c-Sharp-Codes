using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square : Shape
    {
        private double y;

        public Square()
        {
            Console.WriteLine("Empty-Square");
        }

        public Square(double y) 
        {
            Console.WriteLine("Para-Square");
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
            return GetY() * GetY();
        }
    }
}
