using System;

namespace _7_Classe_e_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {   Forest f = new Forest("Congo", "Tropical");
            f.Trees = 0;

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            f.Grow();

            Forest r = new Forest("Rendlesham");
            Console.WriteLine(r.Biome);

            Console.WriteLine(Forest.TreeFacts);
               //Ao usar métodos estáticos, chama-se os métodos pela classe (não pelo objeto)
        }
    }

    class Forest
    {
        //Fields
        public int age;
        private string biome;
        private static int forestsCreated;
        private static string treeFacts;

        //Constructors (can be overloading too)
        public Forest(string name, string biome)
        {   this.Name = name;
            this.Biome = biome;
            Age = 0;
        }

        public Forest(string name) : this(name, "Unknown")
        {   Console.WriteLine("Biome not specified. Value defaulted to 'Unknown'.");
        }

            //Construtores estáticos inicializam atributos estáticos
        static Forest()
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  " +
                "purifying water.\r\n  mitigating natural hazards such as floods.\n";
            ForestsCreated = 0;

        }

        //Properties (can be automatic)
        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {   get { return biome; }
            set
            {
                if (value == "Tropical" || value == "Temperate" || value == "Boreal")
                {   biome = value;
                }
                else
                {   biome = "Unknown";
                }
            }
        }

        public int Age                              //public int Age {  get;    private set; }
        {   get { return age; } 
            private set { age = value; } 
        }

        public static int ForestsCreated
        {   get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        public static string TreeFacts
        {   get { return treeFacts; }
        }

        //Methods
        public int Grow()
        {   Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {   Trees -= 20;
            Age += 1;
            return Trees;
        }

            //Métodos estáticos acessam somente atributos estáticos
        public static void PrintTreeFacts()
        {   Console.WriteLine(TreeFacts);
        }

            //Há a possibilidade de criar classes estáticas : static class abc { }

    }
}
