using System;

namespace _50_Permissão_para_jogar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRuning = true;

            while (isRuning)
            {
                string name;
                int age;

                Console.WriteLine("Welcome!! What's your name? ");
                name = Console.ReadLine();

                Console.WriteLine($"Hello, {name}! What's yout age? ");
                age = Convert.ToInt32(Console.ReadLine());

                switch (age)
                {
                    case var myAge when myAge < 18:
                        Console.WriteLine("You are too young to be playing this game, go home!");
                        break;

                    case var myAge when myAge < 70 && myAge >= 17:
                        Console.WriteLine("Thanks for entering your information");
                        break;

                    case var myAge when myAge >=70:
                        Console.WriteLine("You are very old no offense");
                        break;

                    default:
                        Console.WriteLine("How did you het this response???????");
                        break;
                }

                Console.WriteLine("Do you want to run this again? ");
                string isRunningResponse = Console.ReadLine().ToLower();

                if (isRunningResponse == "no")
                    isRuning = false;
            }
        }
    }
}
