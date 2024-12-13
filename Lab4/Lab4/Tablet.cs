using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Tablet : Gadget
    {
        public Tablet(int id, DateTime date, int stock, double price) : base(id, date, stock, price) { }

        public override double CalculateTotalBill()
        {
            double total = base.CalculateTotalBill();
            if (Price > 800)
            {
                total *= (1 - 0.06);
            }
            return total + (total * 0.12);
        }
    }
}
