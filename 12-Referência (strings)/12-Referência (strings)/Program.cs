using System;

namespace _12_Referência__strings_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            string dog = "chihuahua";
            string tinyDog = dog;
            dog = "dalmation";
            Console.WriteLine(dog);
            // Output: "dalmation"
            Console.WriteLine(tinyDog);
            // Output: "chihuahua"


            // Example 2
            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";
            System.Console.WriteLine(s1);
            // Output: "Hello World"
            System.Console.WriteLine(s2);
            // Output: "Hello"


            string a = "immutable";
            Object oa = new Object();
            string b = "immutable";
            Object ob = new Object();

            Console.WriteLine(a == b);
            Console.WriteLine(oa == ob);


            Console.Write("\n\nInsert any string: ");
            string abc = Console.ReadLine();

            if (String.IsNullOrEmpty(abc))
                Console.WriteLine("You didn't enter anything");
            else
                Console.WriteLine("Thank you for your submission!");


            string lyrics = "\n\nDollie, Dollie, bo-bollie,\n" + "Banana-fana fo-follie\n" + "Fee-fi-mo-mollie\n" + "Dollie!";
            lyrics = lyrics.Replace("ollie", "ana");
            Console.WriteLine(lyrics);

            Console.WriteLine("\n\n");
            string s = "Hello World";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Contains("o"));

            string ss = String.Empty;
            bool isEmpty = String.IsNullOrEmpty(ss);
            Console.WriteLine($"\n\n{isEmpty}");


            // Unassigned
            string sa;
            // Null
            string ss2 = null;
            // Empty string
            string s3 = "";
            // Also empty string
            string s4 = String.Empty;
            // This prints true
            Console.WriteLine(s3 == s4);
        }
    }
}
