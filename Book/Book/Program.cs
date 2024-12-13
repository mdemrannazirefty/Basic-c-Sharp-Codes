using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class StoryBook
    {
        private string isbn;
        private string bookTitle;
        private string authorName;
        private double price;
        private int availableQuantity;
        private string category;
        private static double discountRate;

        public StoryBook()
        {
            Console.WriteLine("Default StoryBook");
        }

        public StoryBook(string isbn, string bookTitle, string authorName, double price, int availableQuantity, string category)
        {
            this.isbn = isbn;
            this.bookTitle = bookTitle;
            this.authorName = authorName;
            this.price = price;
            this.availableQuantity = availableQuantity;
            this.category = category;
        }

        public static void SetDiscountRate(double rate)
        {
            discountRate = rate;
        }

        public static double GetDiscountRate()
        {
            return discountRate;
        }

        public void SetISBN(string isbn)
        {
            this.isbn = isbn;
        }

        public void SetBookTitle(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        public void SetAuthorName(string authorName)
        {
            this.authorName = authorName;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetAvailableQuantity(int availableQuantity)
        {
            this.availableQuantity = availableQuantity;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        public string GetISBN()
        {
            return isbn;
        }

        public string GetBookTitle()
        {
            return bookTitle;
        }

        public string GetAuthorName()
        {
            return authorName;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetAvailableQuantity()
        {
            return availableQuantity;
        }

        public string GetCategory()
        {
            return category;
        }

        public void AddQuantity(int amount)
        {
            availableQuantity += amount;
            Console.WriteLine("After add book: " + availableQuantity);
        }

        public void SellQuantity(int amount)
        {
            if (availableQuantity >= amount)
            {
                availableQuantity -= amount;
                Console.WriteLine("After Sell book: " + availableQuantity);
            }
            else
            {
                Console.WriteLine("Not enough.");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("ISBN is: " + isbn);
            Console.WriteLine("Titleis: " + bookTitle);
            Console.WriteLine("Author is: " + authorName);
            Console.WriteLine("Price is: " + price);
            Console.WriteLine("Available Quantity is: " + availableQuantity);
            Console.WriteLine("Category is: " + category);
        }
    }
}
