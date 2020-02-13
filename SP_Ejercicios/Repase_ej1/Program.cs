using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repase_ej1
{
    public delegate void MyDelegate();
    class Program
    {
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }
        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
            new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        }

        public static void MenuGenerator(String[] opciones, MyDelegate[] deleg)
        {
            if (opciones.Length != deleg.Length)
            {
                return;
            }
            for(int i=0; i<opciones.Length; i++)
            {
                Console.WriteLine((i+1)+")"+opciones[i]);
            }
            int opcion;
            bool correct;
            do
            {
                correct = false;
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    correct = true;
                    if(opcion<1 || opcion > opciones.Length)
                    {
                        Console.WriteLine("Esta opción no existe. Escoja una existente.");
                        correct = false;
                    }
                    else
                    {
                        deleg[opcion-1]();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor incorrecto. Escoja una de las opciones del menú.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número demaisado grande.");
                }
            } while (!correct);
        }
    }
}
