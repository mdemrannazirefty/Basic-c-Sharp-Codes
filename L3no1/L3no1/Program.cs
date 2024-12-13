using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3no1
{
    internal class Program
    {
        public int id;
        public string name;
        public double cgpa;

        public void setId(int i)
        {
            id = i;
        }
        public void setName(string n)
        {
            name=n;
        }
        public void setCgpa(double c)
        {
            cgpa = c;
        }
        
        public int getId() 
        { 
            return id;
        }
        public String getName()
        {
            return name;
        }
        public double getCgpa() 
        { 
            return cgpa;
        }
        
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.setName("EFTY");
            p.setCgpa(4.0);
            p.setId(802);
            Console.WriteLine("ID Is: "+p.getId());
            Console.WriteLine("NAME IS: "+p.getName());
            Console.WriteLine("CGPA Is: "+p.getCgpa());

            Console.ReadLine();
        }
    }
}
