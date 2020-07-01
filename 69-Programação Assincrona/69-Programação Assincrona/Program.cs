using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _69_Programação_Assincrona
{
    class Program
    {
        static Random? rnd;

        static void Main()
        {
            Console.WriteLine($"You rolled {GetDiceRoll().Result}");
        }

        private static async ValueTask<int> GetDiceRoll()
        {
            Console.WriteLine("...Shaking the dice...");
            int roll1 = await Roll();
            int roll2 = await Roll();
            return roll1 + roll2;
        }

        private static async ValueTask<int> Roll()
        {
            if (rnd == null)
                rnd = new Random();

            await Task.Delay(500);
            int diceRoll = rnd.Next(1, 7);
            return diceRoll;
        }
    }
}
