using System;

namespace _3_Métodos
{
    class Program
    {
        static void Main (string[] args)
        {
            VisitPlanets (numberOfPlanets: 2, name: "Batata");
            Console.WriteLine("\n\n");

            VisitPlanets();
            Console.WriteLine("\n\n");
        }

        static void VisitPlanets (string adjective = "brave", string name = "Cosmonaut", int numberOfPlanets = 0, double gForce = 4.2)
        {
            Console.WriteLine($"\tWelcome back, {adjective} {name}.");
            Console.WriteLine($"\t\tYou visited {numberOfPlanets} new planets...");
            Console.WriteLine($"\t\t\t...while experiencing a g-force of {gForce} g!");
        }
    }
}
