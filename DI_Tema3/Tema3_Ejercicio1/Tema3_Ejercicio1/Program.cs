using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ordenadores = new Hashtable();
            bool salir = false, error;
            int opcion = 0;
            do
            {
                error = false;
                Console.WriteLine("1.Introducir datos.");
                Console.WriteLine("2.Mostrar colección.");
                Console.WriteLine("3.Mostrar elemento.");
                Console.WriteLine("9.Salir.");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, choose an option of the list.");
                    error = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please, choose an option of the list.");
                    error = true;
                }
                if (!error)
                {
                    switch (opcion)
                    {
                        case 1:
                            anhadirPC(ordenadores);
                            break;
                        case 2:
                            mostrarColeccion(ordenadores);
                            break;
                        case 3:
                            mostrarElemento(ordenadores);
                            break;
                        case 9:
                            salir = true;
                            Console.WriteLine("Bye");
                            break;
                        default:
                            Console.WriteLine("Error. Incorrect value.");
                            break;
                    }
                }
            } while (!salir);
            Console.ReadLine();
        }
        public static void mostrarElemento(Hashtable coleccion)
        {
            Console.Write("Introduce pc's IP: ");
            string newIp = Console.ReadLine();
            if (coleccion.ContainsKey(newIp))
            {
                Console.WriteLine("Ip's element: {0}\n Memory's element: {1}",newIp,coleccion[newIp]);
            }
            else
            {
                Console.WriteLine("This element doesn't exists in the actual colection.");
            }
        }
        public static void mostrarColeccion(Hashtable ordenadores)
        {
            foreach(DictionaryEntry elemento in ordenadores)
            {
                Console.WriteLine("***Elemento***");
                Console.WriteLine("IP: {0}", elemento.Key);
                Console.WriteLine("Memory: {0}", elemento.Value);
                Console.WriteLine("**************");
            }
        }
        public static void anhadirPC(Hashtable ordenadores)
        {
            string ip = "";
            int memoria = 0;
            try
            {
                Console.Write("Introduce pc's IP: ");
                ip = Console.ReadLine();
                if (ordenadores.ContainsKey(ip))
                {
                    Console.WriteLine("This IP already exists.");
                    return;
                }
                if (!comprobarIP(ip))
                {
                    Console.WriteLine("Invalid value for an IP.");
                    return;
                }
                try
                {
                    Console.Write("Introduce RAM memory in GB: ");
                    memoria = Convert.ToInt32(Console.ReadLine());
                    if (memoria < 0)
                    {
                        throw new NegativeException();
                    }
                    ordenadores.Add(ip, memoria);
                }
                catch (NegativeException)
                {
                    Console.WriteLine("Negative memory isn't possible...");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Tas pasao de memoria.");
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Incorrect values. Memory must to be upper than 0.");
            }          
        }
        public static bool comprobarIP(string ip)
        {
            string[] campos = ip.Split('.');
            if (campos.Length != 4){
                return false;
            }
            for(int i=0; i<4; i++)
            {
                if(Convert.ToInt32(campos[i])< 0 || Convert.ToInt32(campos[i]) > 255)
                {
                    return false;
                }
            }
            return true;
        }
    }
   
}
