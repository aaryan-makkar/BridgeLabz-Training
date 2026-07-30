using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ClassesAndObjects
{
    internal class Book
    {
        public string title;
        public string author;
        public double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Book Details: ");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
