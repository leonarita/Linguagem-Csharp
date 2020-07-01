using System;

//  dotnet run

namespace _1_Introdução
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            string i = Console.ReadLine();
            int idade = Convert.ToInt32(i);

            if (idade >= 18)
                Console.WriteLine($"{nome}, você pode comprar o que quiser!");
            else
                Console.WriteLine($"{nome}, você é de menor! Espere mais {18 - idade} anos");

            bool key = false;

            string[] array = new string[] { "Ana", "Julia", "Leo" };
            //string[] array = new string[3] { "Ana", "Julia", "Leo" };

            foreach (string test in array)
            {
                if (nome == test)
                {
                    key = true;
                    break;
                }
            }

            Console.WriteLine((key == true) ? "Você já foi registrado anteriormente" : "Seja bem vindo");

            /*  ARRAY :  .Length  .IndexOf()  .Sort()  .Find()
             *  STRING : .Length  .IndexOf()  .ToUpper .ToLower()   .Substring()
             *  MATH :   .Sqrt    .Floor      .Min     .Abs         .Pow            .Max        .Ceiling
             */
        }
    }
}
