using System;
using System.Collections.Generic;
using System.Linq;

namespace _48_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBooks = new List<Book>
            {
                new Book() { Title="Advanced C#", Price=9.99 },
                new Book() { Title="OOP width C#", Price=14.99 },
                new Book() { Title="C# for Beginners", Price=19.99 },
                new Book() { Title="Complete ASP.NET Core", Price=29.99 }
            };

            //Without LINQ
            foreach (var book in myBooks)
            {
                if (book.Title.Contains("C#"))
                    Console.WriteLine(book.Title);
            }
            Console.WriteLine("\n\n");

            //With LINQ
            var myNewBooks = myBooks.Where(b => b.Title.Contains("C#"))
                .OrderBy(b => b.Title).Select(b => b.Price);

            foreach (var book in myNewBooks)
                Console.WriteLine(book);
        }
    }
}
