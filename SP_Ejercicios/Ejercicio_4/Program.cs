using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        bool fin = false;
        static readonly private object l = new object();
        Thread[] caballos = new Thread[5];
        Random number = new Random();
        int apuesta;
        int meta = 50;
        static void Main(string[] args)
        {
            Program p = new Program();
            for(int i=0; i<p.caballos.Length; i++)
            {
                int aux = i;
                p.caballos[i] = new Thread(() =>p.avanzar(aux));
            }
            for(int i=0; i<p.caballos.Length; i++)
            {
                p.caballos[i].Start();
            }
            lock (l)
            {
                Monitor.Wait(l);
                Console.SetCursorPosition(1, p.caballos.Length+5);
                Console.WriteLine("Carrera terminada");
                Console.ReadKey();
            }
        }
        public void dormir()
        {
            Thread.Sleep(number.Next(0,100));
        }
        public void avanzar(int caballo)
        {
            int pos = 0;
            while (!fin)
            {
                lock (l)
                {
                    if (!fin)
                    {
                        Console.SetCursorPosition(pos, caballo + 5);
                        pos += number.Next(1, 3);
                        for(int i=0; i<pos; i++)
                        {
                            Console.Write("*");
                        }
                        if (pos >= meta)
                        {
                            fin = true;
                            Console.SetCursorPosition(1, caballos.Length + 8);
                            Console.WriteLine("Ha ganado el caballo {0,2}",caballo);
                            Monitor.Pulse(l);
                        }
                        dormir();
                    }
                }
            }
        }
        public int solicitarApuesta()
        {
            bool correct = false;
            int opcion = 0;
            for(int i=0; i<caballos.Length; i++)
            {
                Console.WriteLine("{0,2})Caballo{0}", i);
            }
            do
            {
                Console.Write("Escoja un caballo: ");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    correct = true;
                    if(opcion<0 || opcion >= caballos.Length)
                    {
                        Console.WriteLine("Ese caballo no existe, escoja uno de la lista.");
                        correct = false;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número demasiado grande. Opcíon no válida.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("El valor introducido no es correcto.");
                }
            } while (!correct);
            return opcion;
        }
    }
}
