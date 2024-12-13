using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public string id;
            public string add;
            public string cgp;
            public string dep;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            Console.WriteLine("Enter 1st student name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter 1st student ID: ");
            string id1 = Console.ReadLine();
            Console.WriteLine("Enter 1st student Address: ");
            string add1 = Console.ReadLine();
            Console.WriteLine("Enter 1st student CGP: ");
            string cgp1 = Console.ReadLine();
            Console.WriteLine("Enter 1st student Dep: ");
            string dep1 = Console.ReadLine();

            Console.WriteLine("Enter 2nd student name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter 2nd student ID: ");
            string id2 = Console.ReadLine();
            Console.WriteLine("Enter 2nd student Address: ");
            string add2 = Console.ReadLine();
            Console.WriteLine("Enter 2nd student CGP: ");
            string cgp2 = Console.ReadLine();
            Console.WriteLine("Enter 2nd student Dep: ");
            string dep2 = Console.ReadLine();

            

            Console.WriteLine("1ST STUDENT INFO:");
            Console.WriteLine("Name: " +s1.name);
            Console.WriteLine("ID: " +s1.id);
            Console.WriteLine("ADDRESS: " +s1.add);
            Console.WriteLine("CGP: " +s1.cgp);
            Console.WriteLine("DEPT: " +s1.dep);

            Console.WriteLine("2nd STUDENT INFO:");
            Console.WriteLine("Name: " +s2.name);
            Console.WriteLine("ID: " +s2.id);
            Console.WriteLine("ADDRESS: " +s2.add);
            Console.WriteLine("CGP: " +s2.cgp);
            Console.WriteLine("DEPT: " +s2.dep);
            Console.ReadKey();


        }
    }
}
