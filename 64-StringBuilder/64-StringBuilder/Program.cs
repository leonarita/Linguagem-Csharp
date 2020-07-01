using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _64_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste1();
            Console.WriteLine("\n");
            Teste2();
            Console.WriteLine("\n");
            Teste3();
            Console.WriteLine("\n");
            Teste4();
            Console.WriteLine("\n");
            Teste5();
            Console.WriteLine("\n");
        }

        public static void Teste1()
        {
            StringBuilder sb = new StringBuilder("This is the beginning of a sentence, ");

            sb.Replace("the beginning of ", "").Insert(sb.ToString().IndexOf("a ") + 2,  "complete ").Replace(",", ".");
            Console.WriteLine(sb.ToString());
        }

        public static void Teste2()
        {
            Random rnd = new Random();
            string[] tempF = { "47.6F", "51.3F", "49.5F", "62.3F" };
            string[] tempC = { "21.2C", "16.1C", "23.5C", "22.9C" };
            string[][] temps = { tempF, tempC };

            StringBuilder sb = new StringBuilder();
            var f = new StringBuilderFinder(sb, "F");
            var baseDate = new DateTime(2013, 5, 1);
            String[] temperatures = temps[rnd.Next(2)];
            bool isFahrenheit = false;
            foreach (var temperature in temperatures)
            {
                if (isFahrenheit)
                    sb.AppendFormat("{0:d}: {1}\n", baseDate, temperature);
                else
                    isFahrenheit = f.SearchAndAppend(String.Format("{0:d}: {1}\n",
                                                     baseDate, temperature));
                baseDate = baseDate.AddDays(1);
            }
            if (isFahrenheit)
            {
                sb.Insert(0, "Average Daily Temperature in Degrees Fahrenheit");
                sb.Insert(47, "\n\n");
            }
            else
            {
                sb.Insert(0, "Average Daily Temperature in Degrees Celsius");
                sb.Insert(44, "\n\n");
            }
            Console.WriteLine(sb.ToString());
        }

        public class StringBuilderFinder
        {
            private StringBuilder sb;
            private String text;

            public StringBuilderFinder(StringBuilder sb, String textToFind)
            {
                this.sb = sb;
                this.text = textToFind;
            }

            public bool SearchAndAppend(String stringToSearch)
            {
                sb.Append(stringToSearch);
                return stringToSearch.Contains(text);
            }
        }

        public static void Teste3()
        {
            // Create a StringBuilder object with 4 successive occurrences of each character in the English alphabet. 
            StringBuilder sb = new StringBuilder();

            for (ushort ctr = (ushort)'a'; ctr <= (ushort)'z'; ctr++)
                sb.Append(Convert.ToChar(ctr), 4);

            // Create a parallel string object.
            String sbString = sb.ToString();
            
            // Determine where each new character sequence begins.
            String pattern = @"(\w)\1+";
            MatchCollection matches = Regex.Matches(sbString, pattern);

            // Uppercase the first occurrence of the sequence, and separate it from the previous sequence by an underscore character.
            for (int ctr = matches.Count - 1; ctr >= 0; ctr--)
            {
                Match m = matches[ctr];
                sb[m.Index] = Char.ToUpper(sb[m.Index]);
                if (m.Index > 0) sb.Insert(m.Index, "_");
            }

            // Display the resulting string.
            sbString = sb.ToString();
            int line = 0;
            
            do
            {
                int nChars = line * 80 + 79 <= sbString.Length ? 80 : sbString.Length - line * 80;
                Console.WriteLine(sbString.Substring(line * 80, nChars));
                line++;
            }
            while (line * 80 < sbString.Length);
        }

        public static void Teste4()
        {
            // Create a StringBuilder object with 4 successive occurrences of each character in the English alphabet. 
            StringBuilder sb = new StringBuilder();

            for (ushort ctr = (ushort)'a'; ctr <= (ushort)'z'; ctr++)
                sb.Append(Convert.ToChar(ctr), 4);

            // Iterate the text to determine when a new character sequence occurs.
            int position = 0;
            Char current = '\u0000';
            
            do
            {
                if (sb[position] != current)
                {
                    current = sb[position];
                    sb[position] = Char.ToUpper(sb[position]);

                    if (position > 0)
                        sb.Insert(position, "_");

                    position += 2;
                }
                else
                {
                    position++;
                }
            } 
            while (position <= sb.Length - 1);

            // Display the resulting string.
            String sbString = sb.ToString();
            int line = 0;

            do
            {
                int nChars = line * 80 + 79 <= sbString.Length ? 80 : sbString.Length - line * 80;
                Console.WriteLine(sbString.Substring(line * 80, nChars));
                line++;
            } 
            while (line * 80 < sbString.Length);
        }

        public static void Teste5()
        {
            // Create a StringBuilder object with 4 successive occurrences of each character in the English alphabet. 
            StringBuilder sb = new StringBuilder();

            for (ushort ctr = (ushort)'a'; ctr <= (ushort)'z'; ctr++)
                sb.Append(Convert.ToChar(ctr), 4);

            // Convert it to a string.
            String sbString = sb.ToString();

            // Use a regex to uppercase the first occurrence of the sequence, and separate it from the previous sequence by an underscore.
            string pattern = @"(\w)(\1+)";

            sbString = Regex.Replace(sbString, pattern, m => (m.Index > 0 ? "_" : "") + m.Groups[1].Value.ToUpper() + m.Groups[2].Value);

            // Display the resulting string.
            int line = 0;

            do
            {
                int nChars = line * 80 + 79 <= sbString.Length ?
                                    80 : sbString.Length - line * 80;
                Console.WriteLine(sbString.Substring(line * 80, nChars));
                line++;
            } 
            while (line * 80 < sbString.Length);
        }
    }
}
