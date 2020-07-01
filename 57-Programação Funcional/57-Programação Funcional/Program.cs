using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.ParallelEnumerable;

namespace _57_Programação_Funcional
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isMod2 = x => x % 2 == 0;
            var list = Enumerable.Range(1, 10);
            var evenNumbers = list.Where(isMod2);

            var list2 = MultpilicationFormatter.Format1(Enumerable.Range(1, 10).ToList());
            var list3 = MultpilicationFormatter.Format2(Enumerable.Range(1, 10).ToList());

            foreach (var item in list2)
                Console.WriteLine(item);

            Console.WriteLine("\n");
            foreach (var item in list3)
                Console.WriteLine(item);

            Console.ReadLine();
        }

        // Função lambda
        public static int CalculateElapsedDays(DateTime from, DateTime now) => (now - from).Days;
/*
        public int Divide(int numerator, int denominator)
        {
           return numerator / denominator;
        }
*/
    }

    public static class Extensions
    {
        public static int MultiplyBy2(this int value) => value * 2;
    }

    public static class MultpilicationFormatter
    {
        static int counter;

        // Função Pura -> não muda o estado global
        static int Double(int i) => i * 2;

        // Função Impura -> muda o estado global
        static string Counter(int val) => $"{++counter} x 2 = {val}";

        // Funções puras e impuras não paralelizam bem quando estão juntas.
        public static List<string> Format2 (List<int> list)
            => list.Select(Extensions.MultiplyBy2).Select(Counter).ToList();

        // Usando Zip e Range, essa função torna-se pura
        public static List<string> Format1(List<int> list)
            => list.AsParallel().Select(Extensions.MultiplyBy2).Zip(Range(1, list.Count), (val, counter) => $"{counter} x 2 = {val}").ToList();
    }
}
