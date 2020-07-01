using System;

namespace _6_Métodos_com_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool success = Int32.TryParse("10602", out number);
            // number is 10602 and success is true

            int number2;
            bool success2 = Int32.TryParse(" !!! ", out number2);
            // number2 is null and success2 is false

            string statement = "GARRRR";
            string murmur = Whisper(statement, out bool marker);
            Console.WriteLine(murmur);

            //string murmu = Whisper(statement, out marker:true);   --> erro
        }

        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }
    }
}
