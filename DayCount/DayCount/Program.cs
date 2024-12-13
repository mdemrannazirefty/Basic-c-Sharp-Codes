using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCount
{
    internal class Program
    {
        enum days { Sun, Mon, Tue, Wed, Thus, Fri, Sat };
        static void Main(string[] args)
        {
            int WeekDayStart = (int)days.Fri;

            Console.WriteLine("Day in Serial: {0}", (int)days.Fri);

            Console.ReadKey();
        }
    }
}
