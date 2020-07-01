using System;

namespace _65_Ponteiros
{
    class Program
    {
        // Para compilar ponteiro: Propriedades do .cdproj >> Compilar >> Permitir modo não seguro

        unsafe static void Main()
        {
            int i = 5;

            // Unsafe method: uses address-of operator (&).
            SquarePtrParam(&i);
            Console.WriteLine(i + "\n");

            TesteString();
        }

        // Unsafe method: takes pointer to int.
        unsafe static void SquarePtrParam(int* p)
        {
            *p *= *p;
        }

        public unsafe static void TesteString()
        {
            string value = "This is the first sentence" + ".";
            fixed (char* start = value)
            {
                value = String.Concat(value, "This is the second sentence. ");
                fixed (char* current = value)
                {
                    Console.WriteLine(start == current);
                }
            }
        }
    }
}
