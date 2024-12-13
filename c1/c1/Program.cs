using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("MD. EMRAN NAZIR EFTY");

            int i = 10, j = 20, sum=i+j;
            Console.WriteLine("Sum Ans is: " + sum);
            int div = j / i;
            Console.WriteLine("Divide Ans is: " +div);
            int a = -5 + 8 * 6;
            int b = (55 + 9) % 9;
            int c = 20 + -3 * 5 / 8;
            int d = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("A ans is: "+a);
            Console.WriteLine("B ans is: "+b);
            Console.WriteLine("C ans is: "+c);
            Console.WriteLine("D ans is: "+d);
            Console.WriteLine("Enter 2 Number: ");
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("2 Number is: "+e ,"And"+f);
            int add = e + f;
            int mul = e * f;
            int sub = e - f;
            double div2 = e / f;
            int rem = e % f;

            Console.WriteLine("Add is: "+add);
            Console.WriteLine("Mul is: "+mul);
            Console.WriteLine("Sub is: "+sub);
            Console.WriteLine("Div is: "+div2);
            Console.WriteLine("Rem is: "+rem);

            double x = (25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5);
            Console.WriteLine("Ans: " + x);
            double width = 5.5, height = 8.5;
            double area = width * height;
            double per=2*(width*height);

            Console.WriteLine("Area is: " + area);
            Console.WriteLine("Perimeter is: " + per);

            int firsti = 25, secondi = 39;
            if(firsti < secondi)
            {
                Console.WriteLine("25<39");
            }
            else if (firsti > secondi)
            {
                Console.WriteLine("25!=39");
            }
            else { }
            Console.WriteLine("Enter String: ");
            string s=Console.ReadLine();
            char[] chars = s.ToCharArray();
            Console.WriteLine("Rev is: " + s);



            Console.ReadKey();
        }
    }
}
