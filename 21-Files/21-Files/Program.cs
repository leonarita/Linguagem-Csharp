using System;
using System.IO;

namespace _21_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do arquivo: ");
            string arq = Console.ReadLine();

            Console.WriteLine("\n\nConsidere as seguintes opções: \n\t1-Criação \n\t2-Leitura \n\t3-Escrita");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            if (op == 1)
            {
                TextWriter texto = new StreamWriter(arq);

                Console.WriteLine("Insira o que deseja escrever no arquivo: ");
                string txt = Console.ReadLine();
                texto.WriteLine(txt);

                texto.Close();
            }

            else if (op == 2)
            {
                TextReader texto = new StreamReader(arq);

                Console.WriteLine(texto.ReadLine());
                Console.WriteLine(texto.ReadLine());

                texto.Close();
            }

            else if (op == 3)
            {
                TextWriter texto = File.AppendText(arq);

                Console.WriteLine("Insira o que deseja escrever no arquivo: ");
                string txt = Console.ReadLine();
                texto.WriteLine(txt);

                texto.Close();
            }
        }
    }
}
