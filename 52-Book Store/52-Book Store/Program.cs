using System;
using System.Collections.Generic;

namespace _52_Book_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isShopping = true;
            List<Book> myBooks = new List<Book>();

            Console.WriteLine("\n\n\t\t\tWelcome to the Book Store!");

            while (isShopping)
            {
                Book book = new Book();

                Console.WriteLine("\n\n\tWhat book would you like to buy? ");
                book.Title = Console.ReadLine();
                book.Price = Convert.ToDouble(Console.ReadLine());

                myBooks.Add(book);

                Console.WriteLine("\n\n\tWould you like to remove a book? ");
                var removeBook = Console.ReadLine().ToLower();

                if (removeBook == "yes")
                {
                    Console.WriteLine("\n\t\tWhat book would you like to remove");
                    var bookToBeRemoved = Console.ReadLine();

                    Book actual = new Book();

                    foreach (var b in myBooks)
                    {
                        if (b.Title.Contains(bookToBeRemoved))
                            actual = b;
                    }

                    myBooks.Remove(actual);
                }

                Console.WriteLine("\n\nDo you want to keep shopping? ");
                var choice = Console.ReadLine().ToLower();

                if (choice == "no")
                {
                    var total = 0.00;
                    isShopping = false;

                    Console.WriteLine("\n\nHere are yout books:");

                    foreach(var b in myBooks)
                    {
                        Console.WriteLine("\t" + b.Title + " - R$" + b.Price);
                        total += b.Price;
                    }
                    Console.WriteLine($"Your total is R${total}");
                }
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
