using System;
using System.Threading;

namespace _56_Multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nConcisdere as seguintes opções: \n\t1-Testar thread \n\t2-Testar tread com lock \n\t3-Usar lock com monitor type");
            Console.Write("\n\nInsira a opção desejada: ");
            int op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("======MultiThreads======");
            Printer p = new Printer();
            Thread[] Threads = new Thread[3];

            if (op == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
                    Threads[i].Name = "threadFilha " + i;
                }
            }

            //A palavra-chave lock obriga-nos a especificar um token (uma referência de objeto) que deve ser adquirido por uma thread para entrar no escopo do lock.
            //Quando estamos tentando bloquear um método em nível de instância, podemos simplesmente passar a referência a essa instância. 
            //(Nós podemos usar esta palavra-chave para bloquear o objeto atual) 

            //Uma vez que a thread entra em um escopo de bloqueio, o sinal de trava (objeto de referência) é inacessível por outros segmentos, 
            //até que o bloqueio seja liberado ou o escopo do bloqueio seja encerrado.
            else if (op == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Threads[i] = new Thread(new ThreadStart(p.PrintNumbers_UsandoLock));
                    Threads[i].Name = "threadFilha " + i;
                }
            }

            //Método Monitor.Enter () é o destinatário final do token da thread. Precisamos escrever todo o código do escopo de bloqueio dentro de um bloco try. 
            //A cláusula finally assegura que o token de thread seja liberada (usando o método Monitor.Exit () , independentemente de qualquer exceção de runtime)
            else if (op == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Threads[i] = new Thread(new ThreadStart(p.PrintNumbers_UsandoMonitorType));
                    Threads[i].Name = "threadFilha " + i;
                }
            }

            foreach (Thread t in Threads)
                t.Start();

            Console.ReadLine();
        }
    }

    class Printer
    {
        public void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }

        public void PrintNumbers_UsandoLock()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
        }

        public void PrintNumbers_UsandoMonitorType()
        {
            Monitor.Enter(this);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
