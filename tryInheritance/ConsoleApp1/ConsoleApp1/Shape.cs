using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shape
    {
        private double x;

        public Shape()
        {
            Console.WriteLine("Empty-Shape");
        }

        public Shape(double x)
        {
            Console.WriteLine("Para-Shape");
            this.x = x;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public double GetX()
        {
            return x;
        }

        public virtual double GetArea()
        {
            return -1;
        }
    }
}
