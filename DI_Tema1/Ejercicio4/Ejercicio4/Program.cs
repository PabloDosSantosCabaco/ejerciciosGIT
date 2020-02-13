using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {

        static void Main(string[] args)
        {
            bool exit = false, all = false;
            int opcion = 0;
            do
            {
                Console.WriteLine("SuperMegaMenuMultiplataform");
                Console.WriteLine("****************************");
                Console.WriteLine("1.SuperMegaGame 1");
                Console.WriteLine("2.SuperMegaGame 2");
                Console.WriteLine("3.SuperMegaGame 3");
                Console.WriteLine("4.One for All");
                Console.WriteLine("5.Exit");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    all = false;
                    switch (opcion)
                    {
                        case 1://Repetir la opción en cada una
                            juego1();
                            if (repetir()) goto case 1;
                            if (all) goto case 2;
                            break;
                        case 2:
                            juego2();
                            if (repetir()) goto case 2;
                            if (all) goto case 3;
                            break;
                        case 3:
                            juego3();
                            if (repetir()) goto case 3;
                            break;
                        case 4:
                            all = true;
                            goto case 1;
                            break;
                        case 5:
                            exit = true;
                            salir();
                            break;
                        default:
                            Console.WriteLine("Incorrect value. Please, choose a number of the list.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Incorrect value. Please, choose a number of the list.");
                }
            } while (!exit);
        }
        public static bool repetir()
        {
            int opcion = 0;

            Console.WriteLine("¿Go you wanna play again?");
            Console.WriteLine("1.YASSS\n2.Nah...");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1) return true;
            else return false;
        }
        public static void salir()
        {
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
        public static void juego1(int limitValue=6)
        {
            int dice = 10, points = 0, numero = 0, support;     
            int limit = limitValue;
            bool repeat;
            Random number = new Random();
            Console.WriteLine("Introduce a number between {0} and {1}", 1, limit);
            do {
                repeat = false;
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero <= 1 || numero > limit)
                    {
                        throw new FormatException();
                    }
                } catch (FormatException)
                {
                    repeat = true;
                    Console.WriteLine("Invalid value, introduce a integer number higher than 1 and lower than {0}.",limit);
                }
            } while (repeat);
            Console.WriteLine("******************************");
            for(int i = 0; i<dice; i++)
            {
                support = number.Next(1, limit);
                Console.Write("{0}  ", support);
                if(support == numero)
                {
                    points++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("Número de aciertos: {0}", points);
            Console.WriteLine();
        }
        public static void juego2(){
            Random randomNumberVector = new Random();
            int vidas = 5, min = 0, max = 100, randomNumber = randomNumberVector.Next(min, max+1), intento=0;
            bool acierto = false;
            while (vidas >= 1 && !acierto){
                do
                {
                    Console.Write("Introduce a number between 1 and 100: ");
                    try
                    {
                        intento = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect value. Please, introduce a number between {0} and {1}.",min,max);
                    }
                } while (acierto);
                if (intento == randomNumber){
                    acierto = true;
                }else if (intento > randomNumber){
                    Console.WriteLine("Incorrect. The number is lower than {0}", intento);
                }else{
                    Console.WriteLine("Incorrect. The number is higher than {0}", intento);
                }
                if (!acierto)
                {
                    vidas--;
                }
            }
            if (vidas > 0)
            {
                Console.WriteLine("Congratulations! You win!");
            }
            else
            {
                Console.WriteLine("You lose... The number was {0}", randomNumber);
            }
        }
        public static void juego3()
        {
            int limit = 14;
            Random randomNumberVector = new Random();
            for (int i=0; i<limit; i++)
            {
                Console.Write("{0}  ", getValueQuiniela(randomNumberVector.Next(1, 101)));
                if ((i+1)%5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
           
        }
        public static char getValueQuiniela(int number)
        {
            switch (number)
            {
                case int n when (n<=60):
                    return '1';
                case int n when (n>60 && n<=85):
                    return 'x';
                case int n when (n>85 && n<=100):
                    return '2';
            }
            return '0';
        }
    }
}
