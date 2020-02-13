using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static readonly private object l = new object();
        int valor = 0;
        int topLimit = 500;
        int botLimit = -500;
        bool arriba;
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread hilo1 = new Thread(() => {
                while (p.valor<p.topLimit) {
                    lock (l)
                    {
                        if (p.valor > p.botLimit)
                        {
                            p.incremento();
                            p.escribir();
                        }
                    } 
                }
            });
            Thread hilo2 = new Thread(() => {
                while (p.valor > p.botLimit)
                {
                    lock (l)
                    {
                        if (p.valor < p.topLimit)
                        {
                            p.decremento();
                            p.escribir();
                        }
                    }
                }
            });
            hilo1.Start();
            hilo2.Start();
            Console.ReadKey();
        }
        public void escribir()
        {
            if (arriba)
            {
                Console.SetCursorPosition(1, 1);
            }
            else
            {
                Console.SetCursorPosition(1, 20);
            }
            Console.WriteLine("{0,4}", valor);
        }
        public void incremento()
        {
            arriba = true;
            valor++;
        }
        public void decremento()
        {
            arriba = false;
            valor--;
        }
    }
}
