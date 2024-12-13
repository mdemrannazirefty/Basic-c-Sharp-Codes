using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Gadget
    {
        public int ID;
        public DateTime Date;
        public int Stock ;
        public double Price;

        public Gadget(int id, DateTime date, int stock, double price)
        {
            ID = id;
            Date = date;
            Stock = stock;
            Price = price;
        }
        public void setID(){ID = ID;}
        public int getID() { return ID; }
        public void setDataTime() {  Date = DateTime.Now; }
        public DateTime getDate() { return Date; }
        public void setStoke() {  Stock = Stock; }
        public int getStock() { return Stock; }
        public void setPrice() { Price = Price; }
        public double getPrice() { return Price; }


        public virtual double CalculateTotalBill()
        {
            return Price * Stock;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Date: "+Date);
            Console.WriteLine("Stock: "+Stock);
            Console.WriteLine("Price: "+Price);
        }
    }
}
