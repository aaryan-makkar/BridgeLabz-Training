using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }

    
    class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear,
                      string name, string bio)
            : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Book Information ---");
            base.DisplayInfo();
            Console.WriteLine($"Author Name: {Name}");
            Console.WriteLine($"Author Bio: {Bio}");
        }
    }
}
