using System;
using System.Collections.Generic;
using System.Linq;

namespace _26_LINQ
{
    class Program
    {
        class Line
        {
            public string[] Words;
            public int Value;
            public Line(string[] Words, int Value)
            {
                this.Words = Words; this.Value = Value;
            }
        }

        class StarbuzzData
        {
            public string Name { get; set; }
            public Drink FavoriteDrink { get; set; }
            public int MoneySpent { get; set; }
            public int Visits { get; set; }
        }
        enum Drink
        {
            BoringCoffee, ChocoRockoLatte, TripleEspresso,
            ZestyLemonChai, DoubleCappuccino, HalfCafAmericano,
            ChocoMacchiato, BananaSplitInACup,
        }

        class Purchase
        {
            public int Issue
            { get; set; }
            public decimal Price
            { get; set; }
        }

        class Comic
        {
            public string Name { get; set; }
            public int Issue { get; set; }
        }

        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal> {
                { 6, 3600M },
                { 19, 500M },
                { 36, 650M },
                { 57, 13525M },
                { 68, 250M },
                { 74, 75M },
                { 83, 25.75M },
                { 97, 35.25M },
                };
        }

        private static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic> {
                new Comic { Name = "Johnny America vs. the Pinko", Issue = 6 },
                new Comic { Name = "Rock and Roll (limited edition)", Issue = 19 },
                new Comic { Name = "Woman’s Work", Issue = 36 },
                new Comic { Name = "Hippie Madness (misprinted)", Issue = 57 },
                new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
                new Comic { Name = "Black Monday", Issue = 74 },
                new Comic { Name = "Tribal Tattoo Madness", Issue = 83 },
                new Comic { Name = "The Death of an Object", Issue = 97 },
                };
        }

        static IEnumerable<Purchase> FindPurchases()
        {
            List<Purchase> purchases = new List<Purchase>() {
                new Purchase() { Issue = 68, Price = 225M },
                new Purchase() { Issue = 19, Price = 375M },
                new Purchase() { Issue = 6, Price = 3600M },
                new Purchase() { Issue = 57, Price = 13215M },
                new Purchase() { Issue = 36, Price = 660M },
                };
            return purchases;
        }

        static void Main(string[] args)
        {
            Line[] lines = {
                            new Line( new string[] { "eating", "carrots,", "but", "enjoy", "Horses" } , 1),
                            new Line( new string[] { "zebras?", "hay", "Cows", "bridge.", "bolted" } , 2),
                            new Line( new string[] { "fork", "dogs!", "Engine", "and" }, 3 ) ,
                            new Line( new string[] { "love", "they", "apples.", "eating" }, 2 ) ,
                            new Line( new string[] { "whistled.", "Bump" }, 1 )
                            };

            var words = from line in lines
                        group line by line.Value
                        into wordGroups
                        orderby wordGroups.Key
                        select wordGroups;

            var twoGroups = words.Take(2);

            foreach (var group in twoGroups)
            {
                int i = 0;
                foreach (var inner in group)
                {
                    i++;
                    if (i == group.Key)
                    {
                        var poem = from word in inner.Words
                                    orderby word descending
                                    select word + " ";

                        foreach (var word in poem)
                            Console.Write(word);
                    }
                }
            }

            Console.WriteLine("\n\n");

            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            IEnumerable<Purchase> purchases = FindPurchases();

            var results = from comic in comics
                          join purchase in purchases
                          on comic.Issue equals purchase.Issue
                          orderby comic.Issue ascending
                          select new { comic.Name, comic.Issue, purchase.Price };
                          decimal gregsListValue = 0;
                          decimal totalSpent = 0;

            foreach (var result in results)
            {
                gregsListValue += values[result.Issue];
                totalSpent += result.Price;
                Console.WriteLine("Issue #{0} ({1}) bought for {2:c}", result.Issue, result.Name, result.Price);
            }

            Console.WriteLine("\n\n");
        }
    }
}
