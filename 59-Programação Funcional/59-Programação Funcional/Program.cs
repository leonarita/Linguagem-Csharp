using System;
using System.Collections.Generic;
using System.Linq;

namespace _59_Programação_Funcional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            // map
            List<int> result = new List<int> { };
            result = numbers.Select(x => x + 3).ToList();

            foreach (int i in result)
                Console.Write(i + " ");
            Console.Write("\n");

            // filter
            List<int> Lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> ListaMaiorIgual5 = GetEmployeesWithAtLeastNSickdays(Lista, 5);

            foreach (int i in ListaMaiorIgual5)
                Console.Write(i + " ");
            Console.Write("\n");

            // reduce
            var sum1 = numbers.Aggregate((x, y) => x + y);
            var sum2 = numbers.Sum();
            Console.WriteLine(sum1 + " " + sum2);
        }

        public static List<int> GetEmployeesWithAtLeastNSickdays(List<int> employees, int n)
        {
            return employees.Where(employees => employees >= n).ToList();
        }
    }
}
