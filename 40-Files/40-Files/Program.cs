using System;
using System.IO;

namespace _40_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do arquivo: ");
            string arq = Console.ReadLine();

            if (!arq.Contains("."))
                arq += ".txt";

            int op;

            do
            {
                Console.WriteLine("\n\nConsidere as seguintes opções: \n\t1-Criação \n\t2-Leitura \n\t3-Escrita \n\t4-Informação \n\t5-Substituir \n\t0-Sair");
                op = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n");

                if (op == 0)
                    break;

                else if (op == 1)
                {
                    if (!File.Exists(arq))
                    {
                        //Create new file
                        File.Create(arq);
                    }

                    Console.WriteLine("Insira o que deseja escrever no arquivo: ");
                    string txt = Console.ReadLine();
                    File.WriteAllText(arq, txt);
                }

                else if (op == 2)
                {
                    //Open, Read - Method 1
                    string fileContent = File.ReadAllText(arq);
                    Console.WriteLine(fileContent);

                    //Open, Read - Method 1
                    /*          string[] lines = File.ReadAllLines(arq);
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    Console.WriteLine(lines[i]);
                                }
                    */
                }

                else if (op == 3)
                {
                    Console.WriteLine("Insira o que deseja escrever no arquivo: ");
                    string txt = Console.ReadLine();

                    File.AppendAllText(arq, txt);

                }

                else if (op == 4)
                {
                    FileInfo info = new FileInfo(arq);

                    Console.WriteLine(info.Directory);
                    Console.WriteLine(info.Extension);
                    Console.WriteLine(info.IsReadOnly);
                    Console.WriteLine(info.LastAccessTime);
                    Console.WriteLine(info.LastWriteTime);
                    Console.WriteLine(info.Length);
                    Console.WriteLine(info.Name);
                }

                else if (op == 5)
                {
                    //Replace
                    string fileContent = File.ReadAllText(arq);
                    string replaced = fileContent.Replace('a', 'b');

                    //Save file
                    File.WriteAllText("settings/mytextfile2.txt", replaced);
                    string[] newLines = { "\n", "wow", "this", "is", "cool" };
                    File.WriteAllLines("settings/mytextfile3.txt", newLines);

                    //Append file
                    File.AppendAllText("settings/mytextfile2.txt", replaced);
                    File.AppendAllLines("settings/mytextfile2.txt", newLines);
                }

                else
                {
                    Console.WriteLine("Comando inválido!");
                }
            }
            while (op != 0);
        }
    }
}
