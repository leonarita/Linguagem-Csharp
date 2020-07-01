using System;
using System.IO;

namespace _49_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"files.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine("Hello world");
                    streamWriter.WriteLine("This is me");
                    streamWriter.WriteLine("I create this using C#");
                }
            }

            using (StreamReader streamReader = File.OpenText(path))
            {
                string textFound;

                while ((textFound = streamReader.ReadLine())!=null)
                {
                    Console.WriteLine(textFound);
                }
            }
        }
    }
}
