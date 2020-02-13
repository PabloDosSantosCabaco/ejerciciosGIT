using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static int counter = 0;
        static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            MyTimer t = new MyTimer(increment);
            t.Intervalo = 1000;
            string op = "";
            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            } while (op == "1");
        }

        class MyTimer
        {
            private readonly object l = new object();
            public delegate void MyDelegate();
            private int intervalo;
            bool finish = false;
            bool wait = true;
            public int Intervalo { get; set; }
            Thread hilo;
            public MyTimer(MyDelegate func)
            {
                hilo = new Thread(()=> {
                    while (!finish)
                    {
                        Thread.Sleep(Intervalo);
                        lock (l)
                        {
                            if (wait)
                            {
                                Monitor.Wait(l);
                            }
                            else
                            {
                                func();
                            }
                        }
                    }
                });
                hilo.Start();
            }
            public void start()
            {
                wait = false;
                lock (l)
                {
                    Monitor.Pulse(l);
                }
            }
            public void stop()
            {
                wait = true;
            }
        }
    }
}
