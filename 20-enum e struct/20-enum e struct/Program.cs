using System;

namespace _20_enum_e_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENUM
            PontoCardeal dir = PontoCardeal.Leste;
            Console.WriteLine("Ponto Cardeal: " + (int)dir + "-" + dir);

            ListaPontos();

            Console.WriteLine("\n");

            //STRUCT

            Horario1 agora;
            agora.hora = 10;
            agora.minuto = 20;
            agora.segundo = 30;
            Console.WriteLine("Horáio: {0}:{1}:{2}", agora.hora, agora.minuto, agora.segundo);

            Horario2 now = new Horario2(11, 25, 00);
            Console.WriteLine("Agora são {0} horas", now.Hora());

            Horario2 copia = now;
            Console.WriteLine("Agora são {0} horas", copia.Hora());
        }

        enum PontoCardeal : byte { Norte=10, Sul, Leste, Oeste };
        //enum PontoCardeal { Norte=10, Sul, Leste, Oeste };

        static void ListaPontos()
        {
            PontoCardeal pt = PontoCardeal.Norte;

            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(pt);
                pt++;
            }
            Console.WriteLine(pt);
        }

        struct Horario1
        {
            public int hora, minuto, segundo;
        }

        struct Horario2
        {
            private int hora, minuto, segundo;

            public Horario2(int h, int m, int s)
            {
                this.hora = h % 24;
                this.minuto = m % 60;
                this.segundo = s % 60;
            }

            public int Hora()
            {
                return this.hora;
            }
        }
    }
}
