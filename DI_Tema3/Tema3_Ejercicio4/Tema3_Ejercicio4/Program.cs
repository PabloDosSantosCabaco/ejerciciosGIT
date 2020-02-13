using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            gestionador(args);
        }
        public static void gestionador(params string[] nums)
        {
            List<int> numeros = new List<int>();
            bool correct = true;
            for (int i = 1; i < nums.Length; i++)
            {
                correct = comprobarEntero(nums[i]);
                if (!correct)
                {
                    break;
                }
                else
                {
                    numeros.Add(Convert.ToInt32(nums[i]));
                }
            }
            switch (nums[0])
            {
                case "+":
                    Console.WriteLine("Hola");
                    Console.WriteLine(suma(numeros));
                    break;
                case "*":
                    Console.WriteLine(mult(numeros));
                    break;
                default:
                    Console.WriteLine("Nada");
                    break;
            }
            Console.ReadKey();
        }
        public static bool comprobarEntero(string dato)
        {
            try
            {
                Convert.ToInt32(dato);
            }
            catch (FormatException)
            {
                return false;
            }catch(OverflowException)
            {
                return false;
            }
            return true;
        }
        public static int mult(List<int> nums)
        {
            int a = 1;
            for (int i = 0; i < nums.Count; i++)
                a *= nums[i];
            return a;
        }
        public static int suma(List<int> nums)
        {
            int a = 0;
            for (int i = 0; i < nums.Count; i++)
                a += nums[i];
            return a;
        }
    }
}
