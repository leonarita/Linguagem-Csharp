using System;
using System.IO;

namespace Instagram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool va = false;
            int a = 0;

            string[] ing = File.ReadAllLines("following.txt");
            string[] ers = File.ReadAllLines("followers.txt");

            Console.WriteLine("Pessoas que não te seguem de volta:");

            using (StreamWriter fi = File.CreateText("unfollowers.txt"))
            {
                foreach (string i in ing)
                {
                    if (i.Equals("Verificado"))
                        continue;

                    va = false;

                    foreach (string j in ers)
                    {
                        if (i.Equals(j))
                        {
                            va = true;
                        }
                    }

                    if (i.Contains("Foto do perfil de") && !va)
                    {
                        Console.WriteLine();
                        fi.WriteLine();
                        continue;
                    }
                    if (!va)
                    {
                        Console.WriteLine("\t " + i);
                        fi.WriteLine(i);
                        a++;
                    }
                }
            }

            Console.WriteLine($"\n\n\t\t\t{a / 2} pessoas não te seguem de volta");
            Console.ReadKey();

            a = 0;

            Console.WriteLine("\n\n\nPessoas que você não segue de volta:");

            using (StreamWriter fi = File.CreateText("you_dont_follow_back.txt"))
            {
                foreach (string i in ers)
                {
                    if (i.Equals("Verificado"))
                        continue;

                    va = false;

                    foreach (string j in ing)
                    {
                        if (i.Equals(j))
                        {
                            va = true;
                        }
                    }

                    if (i.Contains("Foto do perfil de") && !va)
                    {
                        Console.WriteLine();
                        fi.WriteLine();
                        continue;
                    }
                    if (!va)
                    {
                        Console.WriteLine("\t " + i);
                        fi.WriteLine(i);
                        a++;
                    }
                }
            }            

            Console.WriteLine($"\n\n\t\t\tVocê não segue {a / 2} pessoas de volta");
            Console.ReadKey();
        }
    }
}
