using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _37_Arquivos_Binários
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file;
            int op;

            do
            {
                Console.WriteLine("\n\n\nConsidere as seguintes opções: \n\t1-Escrita \n\t2-Leitura \n\t0-Sair \n\nInforme a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");

                if (op == 1)
                {
                    file = new FileStream("arquivo.dat", FileMode.Create);
                    BinaryWriter bw = new BinaryWriter(file);

                    Console.WriteLine("Informe algo a ser escrito no arquivo: ");
                    string texto = Console.ReadLine();

                    bw.Write(texto);
                    bw.Close();
                }
                else if (op == 2)
                {
                    file = new FileStream("arquivo.dat", FileMode.Open);
                    BinaryReader br = new BinaryReader(file);
                    Console.Write(br.ReadString());
                    Console.ReadKey();
                }
                else if (op == 0)
                    break;
                else
                    Console.WriteLine("Opção inválida!");
            }
            while (op != 0);
            
        }
    }
}
