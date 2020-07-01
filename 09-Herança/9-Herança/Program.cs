using System;

//Na herança, uma classe herda os membros de outra classe.
namespace _9_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine(s.Describe());

            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());

            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());
        }
    }

    static class Tools
    {   private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateLicensePlate()
        {   Random rand = new Random();
            string licensePlate = "";
            for (int i = 0; i < 8; i++)
                licensePlate += chars[rand.Next(chars.Length)];
            return licensePlate;
        }
    }

    interface IAutomobile
    {   string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }

    //Podemos formar um membro em uma superclasse sem definir sua implementação usando abstract.
    abstract class Vehicle
    {
        public string LicensePlate
        { get; private set; }

        public double Speed
        { get; protected set; }     //Podemos restringir o acesso a uma superclasse e suas subclasses usando protected.

        public int Wheels
        { get; protected set; }     //Podemos restringir o acesso a uma superclasse e suas subclasses usando protected.

        public Vehicle(double speed)
        {   Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
        }

        public virtual void SpeedUp()   //Podemos substituir um membro da superclasse usando virtual (super classe) e override (sub classe)
        {   Speed += 5;
        }

        public virtual void SlowDown()  //Podemos substituir um membro da superclasse usando virtual (super classe) e override (sub classe)
        {   Speed -= 5;
        }

        public void Honk()
        {   Console.WriteLine("HONK!");
        }

        public abstract string Describe();
    }

    class Bicycle : Vehicle
    {
        public Bicycle(double speed) : base(speed)  //base: chama o construtor da superclasse, acesando seus membros.
        {   Wheels = 2; }

        public override void SpeedUp()      //Podemos substituir um membro da superclasse usando virtual (super classe) e override (sub classe)
        {   Speed += 5;

            if (Speed > 15)
                Speed = 15;
        }

        public override void SlowDown()     //Podemos substituir um membro da superclasse usando virtual (super classe) e override (sub classe)
        {   Speed -= 5;

            if (Speed < 0)
                Speed = 0;
        }

        public override string Describe()
        {   return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";    }
    }

    class Sedan : Vehicle, IAutomobile
    {
        public Sedan(double speed) : base(speed)      //base: chama o construtor da superclasse, acesando seus membros.
        {   Wheels = 4; }

        //Podemos substituir um membro da superclasse usando virtual (super classe) e override (sub classe)
        public override string Describe()
        { return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}."; }
    }

    class Truck : Vehicle, IAutomobile
    {
        public double Weight
        { get; }

        public Truck(double speed, double weight) : base(speed)
        {   Weight = weight;

            if (weight < 400)
                Wheels = 8;
            else
                Wheels = 12;
        }

        //Podemos substituir um membro da superclasse usando virtual (super classe) e override (sub classe)
        public override string Describe()
        {   return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";  }

    }
}
