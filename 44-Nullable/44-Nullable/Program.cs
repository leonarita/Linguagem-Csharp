using System;

namespace _44_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permite a atribuição de null à variável
            DateTime? currentDate = null;

            if (currentDate != null)
                Console.WriteLine("It's not null: " + currentDate.Value);
            else
                Console.WriteLine("It's null: " + currentDate.GetValueOrDefault());
        }
    }
}
