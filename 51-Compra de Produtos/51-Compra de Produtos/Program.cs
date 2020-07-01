using System;

namespace _51_Compra_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();
        }

        static void Welcome ()
        {
            Console.WriteLine("\n\n\t\t\tWelcome to store! \n\n\tHere are the items that you can buy: " +
                "\n\t\tBook \n\t\tShirt \n\t\tComputer \n\nWhat would you like to buy? ");
        }

        static void PurchaseItem ()
        {
            var item = Console.ReadLine();

            switch(item)
            {
                case "Book":
                    var book = new Book();

                    book.Author = "JK Author";
                    book.Title = "The wizard of coding";
                    book.Price = 9.99f;

                    Console.WriteLine($"You purchase a computer {book.Title} by {book.Author} for ${book.Price}");

                    break;

                case "Shirt":
                    var shirt = new Shirt();

                    shirt.Size = "M";
                    shirt.Title = "Sports Shirt";
                    shirt.Price = 14.99f;

                    Console.WriteLine($"You purchase a computer {shirt.Title} {shirt.Size} for ${shirt.Price}");

                    break;

                case "Computer":
                    var computer = new Computer();

                    computer.Type = "PC";
                    computer.Title = "Surface Book Pro";
                    computer.Price = 1499.99f;

                    Console.WriteLine($"You purchase a computer {computer.Title} {computer.Type} for ${computer.Price}");

                    break;

                default:
                    break;
            }
        }
    }

    class BaseItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    class Book : BaseItem
    {
        public string Author { get; set; }
    }

    class Shirt : BaseItem
    {
        public string Size { get; set; }
    }

    class Computer : BaseItem
    {
        public string Type { get; set; }
    }
}
