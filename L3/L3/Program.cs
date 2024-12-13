using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L3
{
    internal class Program
    {
        private int accountNumber;
        private String accountHolderName;
        private double balance;

        public void setAccountNumber(int an)
        { 
            accountNumber = an; 
        }
        public void setAccountHolderName(String ahn) 
        {
            accountHolderName = ahn;
        }
        public void SetBalance(double b)
        { 
            balance = b; 
        }
        public int getAccountNumber() 
        {
            return accountNumber;
        }
        public String getAccountHolderName() 
        { 
            return accountHolderName;
        }
        public double getBalance() 
        {
            return balance;
        }

        public void showDetails() 
        {
            Console.Write("Enter Account Number: ");
            setAccountNumber(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter Account Holder Name: ");
            setAccountHolderName(Console.ReadLine());
            Console.Write("Enter Account Balance: ");
            SetBalance(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("*************** Account Details *************");
            Console.WriteLine("ACCOUNT NUMBER: " + getAccountNumber());
            Console.WriteLine("HOLDER NAME: " + getAccountHolderName());
            Console.WriteLine("BALANCE: " + getBalance());
        }


        public static void Main(string[] args)
        {
            Program p=new Program();
            p.showDetails();

            Console.ReadKey();
        }
    }
}
