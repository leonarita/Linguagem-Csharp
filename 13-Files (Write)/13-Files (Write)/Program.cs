using System;
using System.IO;

namespace _13_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1: Escreve uma linha para o novo arquivo

        //  using (StreamWriter writer = new StreamWriter ("C:\\dados\\macoratti.txt", true))   
            using (StreamWriter writer = new StreamWriter("macoratti.txt", true))
            {
                writer.WriteLine("Macoratti .net");
            }

            // 2: Anexa uma linha ao arquivo

        //  using (StreamWriter writer = new StreamWriter(@"C:\dados\macoratti.txt", true))
            using (StreamWriter writer = new StreamWriter("macoratti.txt", true))
            {
                writer.WriteLine("Quase tudo para Visual Basic");
            }

            // Usamos um tipo var que mais simples
            using (var writer = new StreamWriter("macoratti.txt"))
            {
                // Percorre o laço
                for (int i = 0; i < 10; i++)
                {   // Escreve uma string formatada no arquivo
                    writer.Write("{0:0.0} ", i);
                }
            }
        }
    }
}
