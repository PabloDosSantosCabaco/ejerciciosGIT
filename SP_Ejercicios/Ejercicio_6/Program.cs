using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        Random number = new Random();
        bool finish = false;
        bool pausa = false;
        int contador = 0;
        int limitUp = 10;
        int limitDown = -10;
        private static readonly object l = new object();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread player1 = new Thread(() => {
                while (!p.finish)
                {
                    lock (l)
                    {
                        int n = 0;
                        if (!p.finish)
                        {
                            n = p.getNumber();
                            if((n==5 || n == 7) && p.pausa)
                            {
                                p.contador+=5;
                            }else if(n == 5 || n == 7)
                            {
                                p.contador++;
                                p.pausa = true;
                            }
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine("{0,3}", n);
                            if (n >= p.limitUp)
                            {
                                p.finish = true;
                                Console.SetCursorPosition(1, 15);
                                Console.WriteLine("Ha ganado el jugador 1");
                            }
                        }
                        Thread.Sleep(n);
                    }
                }
            });
            Thread player2 = new Thread(() => {
                while (!p.finish)
                {
                    lock (l)
                    {
                        int n = 0;
                        if (!p.finish)
                        {
                            n = p.getNumber();
                            if ((n == 5 || n == 7) && !p.pausa)
                            {
                                p.contador -= 5;
                            }
                            else if (n == 5 || n == 7)
                            {
                                p.contador--;
                                p.pausa = false;
                            }
                            Console.SetCursorPosition(1, 10);
                            Console.WriteLine("{0,3}", n);
                            if (n <= p.limitDown)
                            {
                                p.finish = true;
                                Console.SetCursorPosition(1, 15);
                                Console.WriteLine("Ha ganado el jugador 2");
                            }
                        }
                        Thread.Sleep(n);
                    }
                }
            });
            Thread display = new Thread(()=> {
                while (!p.finish)
                {
                    lock (l)
                    {
                        if (!p.pausa)
                        {
                            Console.SetCursorPosition(1, 5);
                            Console.WriteLine("Color Rojo");
                        }
                        else
                        {

                        }
                    }
                }
            });
            player2.Start();
            player1.Start();
            display.Start();
            Console.ReadKey();
        }

        public int getNumber()
        {
            return number.Next(1, 10);
        }
    }
}
