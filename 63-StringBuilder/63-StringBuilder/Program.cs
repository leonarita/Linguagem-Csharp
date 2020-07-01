using System;
using System.Text;

namespace _63_StringBuilder
{
    class Program
    {
        public static void Main()
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

        static void Teste1()
        {
            // Create a StringBuilder that expects to hold 50 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder sb = new StringBuilder("ABC", 50);

            // Append three characters (D, E, and F) to the end of the StringBuilder.
            sb.Append(new char[] { 'D', 'E', 'F' });

            // Append a format string to the end of the StringBuilder.
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            // Insert a string at the beginning of the StringBuilder.
            sb.Insert(0, "Alphabet: ");

            // Replace all lowercase k's with uppercase K's.
            sb.Replace('k', 'K');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
        }

        public static void Teste2()
        {
            StringBuilder sb = new StringBuilder();
            ShowSBInfo(sb);
            sb.Append("This is a sentence.");
            ShowSBInfo(sb);
            for (int ctr = 0; ctr <= 10; ctr++)
            {
                sb.Append("This is an additional sentence.");
                ShowSBInfo(sb);
            }
        }

        private static void ShowSBInfo(StringBuilder sb)
        {
            foreach (var prop in sb.GetType().GetProperties())
            {
                if (prop.GetIndexParameters().Length == 0)
                    Console.Write("{0}: {1:N0}    ", prop.Name, prop.GetValue(sb));
            }
            Console.WriteLine();
        }

        public static void Teste3()
        {
            string value = "An ordinary string";
            int index = value.IndexOf("An ") + 3;
            int capacity = 0xFFFF;

            // Instantiate a StringBuilder from a string.
            StringBuilder sb1 = new StringBuilder(value);
            ShowSBInfo2(sb1);

            // Instantiate a StringBuilder from string and define a capacity.  
            StringBuilder sb2 = new StringBuilder(value, capacity);
            ShowSBInfo2(sb2);

            // Instantiate a StringBuilder from substring and define a capacity.  
            StringBuilder sb3 = new StringBuilder(value, index, value.Length - index, capacity);
            ShowSBInfo2(sb3);
        }

        public static void ShowSBInfo2(StringBuilder sb)
        {
            Console.WriteLine("\nValue: {0}", sb.ToString());

            foreach (var prop in sb.GetType().GetProperties())
            {
                if (prop.GetIndexParameters().Length == 0)
                    Console.Write("{0}: {1:N0}    ", prop.Name, prop.GetValue(sb));
            }

            Console.WriteLine();
        }

        public static void Teste4()
        {
            StringBuilder sb = new StringBuilder("A StringBuilder object");
            ShowSBInfo3(sb);

            // Remove "object" from the text.
            string textToRemove = "object";
            int pos = sb.ToString().IndexOf(textToRemove);

            if (pos >= 0)
            {
                sb.Remove(pos, textToRemove.Length);
                ShowSBInfo3(sb);
            }

            // Clear the StringBuilder contents.
            sb.Clear();
            ShowSBInfo3(sb);
        }

        public static void ShowSBInfo3(StringBuilder sb)
        {
            Console.WriteLine("\nValue: {0}", sb.ToString());

            foreach (var prop in sb.GetType().GetProperties())
            {
                if (prop.GetIndexParameters().Length == 0)
                    Console.Write("{0}: {1:N0}    ", prop.Name, prop.GetValue(sb));

            }
            Console.WriteLine();
        }

        public static void Teste5()
        {
            // Create a StringBuilder object with no text.
            StringBuilder sb = new StringBuilder();

            // Append some text.
            sb.Append('*', 10).Append(" Adding Text to a StringBuilder Object ").Append('*', 10);
            sb.AppendLine("\n");
            sb.AppendLine("Some code points and their corresponding characters:");

            // Append some formatted text.
            for (int ctr = 50; ctr <= 60; ctr++)
            {
                sb.AppendFormat("{0,12:X4} {1,12}", ctr, Convert.ToChar(ctr));
                sb.AppendLine();
            }

            // Find the end of the introduction to the column.
            int pos = sb.ToString().IndexOf("characters:") + 11 + Environment.NewLine.Length;

            // Insert a column header.
            sb.Insert(pos, String.Format("{2}{0,12:X4} {1,12}{2}", "Code Unit", "Character", "\n"));

            // Convert the StringBuilder to a string and display it.      
            Console.WriteLine(sb.ToString());
        }
    }
}
