using System;

namespace _47_Functions
{
    class Program
    {
        //Anonymous Functions
        delegate void TesteDelegate(string s, string i);

        static void Main(string[] args)
        {
            TesteDelegate testeDelegate = (x, i) =>
            {
                Console.WriteLine($"Hello {x}");
            };

            testeDelegate("Ian", "asd");

            MyClass myClass = new MyClass();
            myClass.IterateThroughNumbers(MyHome);
        }

        static void MyHome(int finalCount)
        {
            if (finalCount >=30000 && finalCount <700000)
                Console.WriteLine("That's a big number");
            else
                Console.WriteLine(finalCount);
        }
    }

    class MyClass
    {
        public delegate void MyDelegate(int passedCount);

        public void IterateThroughNumbers(MyDelegate myDelegate)
        {
            var count = 0;

            while (count < 1000000)
            {
                count++;
                myDelegate(count);
            }
        }
    }
}

