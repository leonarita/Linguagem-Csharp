using System;

namespace _70_Ponteiros
{
    class Program
    {
        // Operadores:   &   *   ->   +   -   ++   --   ==   !=   <   >   <=   >=
        public static void Main()
        {
            int op=0;

            unsafe
            {
                int* p = &op;
                (*p)++;
                Console.WriteLine($"Iniciando variável p, cujo endereço é {(long)&p}, valendo {*p} apontando para o endereço {(long)p}");
            }

            do
            {
                Console.WriteLine("\n\n\nConsidere as seguintes opções: \n\t1-Sizeof \n\t2-stackalloc \n\t0-Sair");
                Console.Write("\n\nInforme a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());

                if (op==1)
                {
                    Console.WriteLine(sizeof(byte));  // output: 1
                    Console.WriteLine(sizeof(double));  // output: 8

                    DisplaySizeOf<Point>();  // output: Size of Point is 24
                    DisplaySizeOf<decimal>();  // output: Size of System.Decimal is 16

                    unsafe
                    {
                        Console.WriteLine(sizeof(Point*));  // output: 8
                    }
                }

                else if (op == 2)
                {
                    //Example 1
                    unsafe
                    {
                        int length = 3;
                        int* numbers = stackalloc int[length];
                        for (var i = 0; i < length; i++)
                        {
                            numbers[i] = i;
                        }
                    }

                    //Example 2
                    Span<int> number = stackalloc[] { 1, 2, 3, 4, 5, 6 };
                    var ind = number.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
                    Console.WriteLine(ind);  // output: 1

                    //Example 3
                    int len = 1000;
                    Span<byte> buffer = len <= 1024 ? stackalloc byte[len] : new byte[len];

                    //Example 4
                    int l = 3;
                    Span<int> n = stackalloc int[l];
                    for (var i = 0; i < l; i++)
                    {
                        n[i] = i;
                    }
                }

                else if (op==3)
                {
                    FixedSpanExample();
                }
            }
            while (op != 0);
        }

        unsafe private static void FixedSpanExample()
        {
            int[] PascalsTriangle = {
                  1,
                1,  1,
              1,  2,  1,
            1,  3,  3,  1,
          1,  4,  6,  4,  1,
        1,  5,  10, 10, 5,  1
    };

            Span<int> RowFive = new Span<int>(PascalsTriangle, 10, 5);

            fixed (int* ptrToRow = RowFive)
            {
                // Sum the numbers 1,4,6,4,1
                var sum = 0;
                for (int i = 0; i < RowFive.Length; i++)
                {
                    sum += *(ptrToRow + i);
                }
                Console.WriteLine(sum);
            }
        }

        static unsafe void DisplaySizeOf<T>() where T : unmanaged
        {
            Console.WriteLine($"Size of {typeof(T)} is {sizeof(T)}");
        }
    }

    public struct Point
    {
        public Point(byte tag, double x, double y) => (Tag, X, Y) = (tag, x, y);

        public byte Tag { get; }
        public double X { get; }
        public double Y { get; }
    }
}
