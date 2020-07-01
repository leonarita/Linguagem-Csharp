using System;

namespace _39_Soma_simples
{
    class Program
    {
        //Aplicativo WPF

        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Valor 1: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Valor 2: ");
            int.TryParse(Console.ReadLine(), out n2);

            int s = n1 + n2;
            Console.WriteLine($"Você digitou {n1} e {n2}. A soma entre eles é {s}");

            Console.ReadKey();
        }
    }
}
