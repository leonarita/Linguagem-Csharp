using FsCheck;
using System;
using System.Collections.Generic;

namespace _58_IEnumerable
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Exibe a potência de 2 elevado ao expoente 8
            foreach (int i in Potencia(2, 8))
                Console.Write("{0} ", i);

            var numeros = Numeros(0, 10);
            foreach (int num in numeros)
                Console.WriteLine(num);

            var palavras = ConverteParaCaixaBaixa("Adoro Banana");
            foreach (string pal in palavras)
                Console.Write("{0} ", pal);

            Console.ReadKey();
        }

        public static IEnumerable<int> Potencia(int numero, int exponente)
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * numero;
                yield return resultado;
            }
        }

        public static IEnumerable<int> Numeros(int inicio, int fim)
        {
            for (int i = inicio; i <= fim; i++)
                yield return i;
        }

        public static IEnumerable<string> ConverteParaCaixaBaixa(string frase)
        {
            foreach (var palavra in frase.Split(' '))
            {
                yield return palavra.ToLower();
            }
        }

        public static IEnumerable<T> Where<T> (this IEnumerable<T> ts, Func<T, bool> predicate)
        {
            foreach (T t in ts) 
                if (predicate(t))
                    yield return t;
        }
    }
}
