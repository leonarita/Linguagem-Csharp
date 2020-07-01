using System;
using System.Collections.Generic;

namespace _46_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Example<int> myExample = new Example<int>();

            myExample.myList = new List<int>();

            myExample.myList.Add(1);
            myExample.myList.Add(2);
            myExample.myList.Add(3);

            myExample.myList.Remove(2);

            foreach (var item in myExample.myList)
                Console.WriteLine(item);
        }

        class Example<T>
        {
            public List<T> myList
            {
                set;
                get;
            }
        }
    }
}
