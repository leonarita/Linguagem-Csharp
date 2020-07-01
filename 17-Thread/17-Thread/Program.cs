using System;
using System.Diagnostics;
using System.Threading;

namespace _17_Thread
{
    class Program
    {
        // Simple threading scenario:  Start a static method running on a second thread.
        public class ThreadExample
        {
            // The ThreadProc method is called when the thread starts.
            // It loops ten times, writing to the console and yielding the rest of its time slice each time, and then ends.
            public static void ThreadProc()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("ThreadProc: {0}", i);
                    // Yield the rest of the time slice.
                    Thread.Sleep(0);
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Considere as seguintes opções: \n\t1-Thread simples \n\t2-Iniciando um thread \n\t3-Recuperando objetos \n\t4-Primeiro e segundo plano");
                Console.WriteLine("\nInforme a opção desejada: ");
                int op = int.Parse(Console.ReadLine());

                Console.WriteLine("Main thread: Start a second thread.");

                if (op == 1)
                {
                    // The constructor for the Thread class requires a ThreadStart delegate that represents the method to be executed on the thread. 
                    // C# simplifies the creation of this delegate.
                    Thread t = new Thread(new ThreadStart(ThreadProc));

                    // Start ThreadProc.  Note that on a uniprocessor, the new thread does not get any processor time until the main thread 
                    // is preempted or yields.  Uncomment the Thread.Sleep that follows t.Start() to see the difference.
                    t.Start();
                    //Thread.Sleep(0);

                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("Main thread: Do some work.");
                        Thread.Sleep(0);
                    }

                    Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
                    t.Join();
                    Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
                    Console.ReadLine();
                }

                else if (op == 2)
                {
                    var th = new Thread(ExecuteInForeground);
                    th.Start();
                    Thread.Sleep(1000);
                    Console.WriteLine("Main thread ({0}) exiting...", Thread.CurrentThread.ManagedThreadId);
                }

                else if (op == 3)
                {
                    ThreadPool.QueueUserWorkItem(ShowThreadInformation);
                    var th1 = new Thread(ShowThreadInformation);
                    th1.Start();
                    var th2 = new Thread(ShowThreadInformation);
                    th2.IsBackground = true;
                    th2.Start();
                    Thread.Sleep(500);
                    ShowThreadInformation(null);
                }

                else if (op == 4)
                {
                    var th = new Thread(ExecuteForeground);
                    th.IsBackground = true;
                    th.Start();
                    Thread.Sleep(1000);
                    Console.WriteLine("Main thread ({0}) exiting...", Thread.CurrentThread.ManagedThreadId);
                }

                else
                {
                    Console.WriteLine("Opção inválida!!!");
                }
            }

            private static void ExecuteInForeground()
            {
                DateTime start = DateTime.Now;
                var sw = Stopwatch.StartNew();
                Console.WriteLine("Thread {0}: {1}, Priority {2}", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                
                do
                {
                    Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds", Thread.CurrentThread.ManagedThreadId, sw.ElapsedMilliseconds / 1000.0);
                    Thread.Sleep(500);
                } 
                while (sw.ElapsedMilliseconds <= 5000);

                sw.Stop();
            }

            static Object obj = new Object();
            private static void ShowThreadInformation(Object state)
            {
                lock (obj)
                {
                    var th = Thread.CurrentThread;
                    Console.WriteLine("Managed thread #{0}: ", th.ManagedThreadId);
                    Console.WriteLine("   Background thread: {0}", th.IsBackground);
                    Console.WriteLine("   Thread pool thread: {0}", th.IsThreadPoolThread);
                    Console.WriteLine("   Priority: {0}", th.Priority);
                    Console.WriteLine("   Culture: {0}", th.CurrentCulture.Name);
                    Console.WriteLine("   UI culture: {0}", th.CurrentUICulture.Name);
                    Console.WriteLine();
                }
            }

            private static void ExecuteForeground()
            {
                DateTime start = DateTime.Now;
                var sw = Stopwatch.StartNew();
                Console.WriteLine("Thread {0}: {1}, Priority {2}", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
                
                do
                {
                    Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds", Thread.CurrentThread.ManagedThreadId, sw.ElapsedMilliseconds / 1000.0);
                    Thread.Sleep(500);
                } 
                while (sw.ElapsedMilliseconds <= 5000);
                
                sw.Stop();
            }
        }
    }
}
