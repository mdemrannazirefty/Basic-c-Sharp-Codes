using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Wearable : Gadget
    {
        public Wearable(int id, DateTime date, int stock, double price) : base(id, date, stock, price) { }

        public override double CalculateTotalBill()
        {
            double total = base.CalculateTotalBill();
            return total + (total * 0.08);
        }
    }
}
