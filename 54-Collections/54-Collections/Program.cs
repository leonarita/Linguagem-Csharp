using System;
using System.Collections.Generic;

namespace _54_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Pop();

            foreach (var i in pilha)
            {
                Console.WriteLine(i);
            }

            Dictionary<int, string> dicionario = new Dictionary<int, string>();
            dicionario.Add(1, "something");
            dicionario.Add(2, "anything");
            dicionario.Add(9, "nothing?");

            foreach (var i in dicionario)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }

            //Nested Lists
            List<List<int>> myTable = new List<List<int>>();
            myTable.Add(new List<int> { 1, 2, 3 });
            myTable.Add(new List<int> { 4, 5 });
            myTable.Add(new List<int> { 6, 7, 8, 9 });

            foreach (var i in myTable)
            {
                Console.WriteLine("**********************");

                foreach (var j in i)
                    Console.WriteLine(j);
            }
        }
    }
}
