using System;

namespace _8_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine($"Sedan with license plate {s.LicensePlate} and {s.Wheels} wheels, driving at {s.Speed} km/h.");
            s.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {s.Speed}");

            Sedan s2 = new Sedan(70);
            Console.WriteLine($"Sedan with license plate {s2.LicensePlate} and {s2.Wheels} wheels, driving at {s2.Speed} km/h.");
            s2.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {s2.Speed}");

            Truck t = new Truck(45, 500);
            Console.WriteLine($"Truck with license plate {t.LicensePlate} and {t.Wheels} wheels, driving at {t.Speed} km/h.");
            t.SpeedUp();
            Console.WriteLine($"Truck's faster speed: {t.Speed}");

        }
    }

    static class Tools
    {
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateLicensePlate()
        {   Random rand = new Random();
            string licensePlate = "";
            for (int i = 0; i < 8; i++)
                licensePlate += chars[rand.Next(chars.Length)];
            return licensePlate;
        }
    }

    //as interfaces são úteis para garantir certas funcionalidades em várias classes (as interfaces possuem propriedades e métodos somente!)
    interface IAutomobile
    {   string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }

    //Classe que implementa a interface
    class Sedan : IAutomobile
    {
        public string LicensePlate
        { get; }

        public double Speed
        { get; private set; }

        public int Wheels
        { get; }

        public Sedan(double speed)
        {   Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }

        public void Honk()
        {   Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {   Speed += 5;
        }

        public void SlowDown()
        {   Speed -= 5;
        }
    }

    class Truck : IAutomobile
    {
        public string LicensePlate
        { get; }

        public double Speed
        { get; private set; }

        public int Wheels
        { get; }

        public double Weight
        { get; }

        public Truck (double speed, double weight)
        {   Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Weight = weight;

            if (weight < 400)
                Wheels = 8;
            else
                Wheels = 12;
        }

        public void Honk()
        {   Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {   Speed += 5;
        }

        public void SlowDown()
        {   Speed -= 5;
        }
    }

}
