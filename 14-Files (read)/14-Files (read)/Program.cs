using System;
using System.IO;

namespace _14_Files__read_
{
    class Program
    {
        static void Main(string[] args)
        {
            // usando a instrução using os recursos são liberados após a conclusão da operação
            string linhas;

            using (StreamReader reader = new StreamReader("macoratti.txt"))
            {   linhas = reader.ReadLine(); }
            Console.WriteLine(linhas);

            string arquivo = @"C:\dados\macoratti.txt";

            if (File.Exists(arquivo))
            {   try
                {   using (StreamReader sr = new StreamReader(arquivo))
                    {   String linha;

                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                            Console.WriteLine(linha);
                    }
                }
                catch (Exception ex)
                {   Console.WriteLine(ex.Message);  }
            }
            else
            {   Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }
            Console.ReadKey();
        }
    }
}
