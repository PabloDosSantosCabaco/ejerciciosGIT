using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Empleado 1","Básico","12345678",24,670,"666555444");
            Directivo dir = new Directivo("Directivo 1","Mandamás","87654321",32,"Contabilidad",20);
            EmpleadoEspecial empEsp = new EmpleadoEspecial("Empleado 2","Especial","13246587",33, 800,"456789123");
            bool salir = false;
            int opcion = 0;

            do
            {
                Console.WriteLine("*****Menú*****");
                Console.WriteLine("**************");
                Console.WriteLine("1.Visualizar los datos del directivo.");
                Console.WriteLine("2.Visualizar datos Empleado.");
                Console.WriteLine("3.Visualizar datos Empleado Especial.");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }catch(FormatException err)
                {
                    Console.WriteLine("Incorrect value.");
                }
                switch (opcion)
                {
                    case 1:
                        dir.getInfo();
                        break;
                    case 2:
                        emp.getInfo();
                        break;
                    case 3:
                        empEsp.getInfo();
                        break;
                    case 4:
                        CalcularPasta(dir);
                        break;
                    default:
                        Console.WriteLine("Valor incorrecto.");
                        break;
                }
            } while (!salir);
        }
        public static void CalcularPasta(IPastaGansa algo)
        {
            double dinero;
            Console.WriteLine("¿Cuánto dinero ingresa su empresa?");
            dinero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(algo.ganasPasta(dinero));
        }
    }
    

    interface IPastaGansa
    {
        double ganasPasta(double benefits);
    }
    abstract class Persona
    {
        private string nombre, apellidos, dni, letrasDni = "TRWAGMYFPDXBNJZSQVHLCKE";
        private int edad, dniNumerico;
        public Persona(string nombre, string apellidos, string dni, int edad) 
        {
            this.Edad = edad;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        public Persona() : this("", "", "", 0){ 
        }

        public abstract double hacienda();
     
        public virtual void getInfo()
        {
            Console.WriteLine("*************Info*************");
            Console.WriteLine("Name: {0}", this.Nombre);
            Console.WriteLine("Surname: {0}", this.Apellidos);
            Console.WriteLine("Age: {0}", this.Edad);
            Console.WriteLine("DNI: {0}", this.Dni);
        }
        public virtual void setInfo()
        {
            Console.WriteLine("*****Data entry*****");
            Console.Write("New Name: ");
            this.Nombre = Console.ReadLine();
            Console.Write("New Surname: ");
            this.Apellidos = Console.ReadLine();
            Console.Write("New Age: ");
            this.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("New DNI: ");
            this.Dni = Console.ReadLine();

        }
        public int Edad
        {
            set
            {
                if (value <= 0)
                {
                    edad = 0;
                }
                else
                {
                    edad = value;
                }
            }
            get
            {
                return this.edad;
            }
        }
        public string Dni
        {
            set
            {
                if (value.Length == 8 && Int32.TryParse(value, out this.dniNumerico)) {
                    this.dni = value;
                }
                else
                {
                    this.dni = "0";
                    this.dniNumerico = 0;
                    Console.WriteLine("Dni inválido");
                }
            }
            get
            {
                return this.dni + letrasDni[dniNumerico % 23];
            }
        }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
    }
    class Empleado  : Persona
    {
        private double salario, irpf;
        private string tlfn;
       

        public Empleado(string nombre, string apellidos, string dni, int edad, double salario, string tlfn) : base(nombre,apellidos,dni,edad)
        {
            this.Salario = salario;
            this.Tlfn = tlfn;
        }
        public Empleado() : this("", "", "", 0, 0, "")
        {

        }

        public override void setInfo()
        {
            base.setInfo();
            Console.Write("New Salary: ");
            this.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("New Number Phone: ");
            this.Tlfn = Console.ReadLine();
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("Salary: {0}", this.Salario);
            Console.WriteLine("IRPF: {0}", this.IRPF);
            Console.WriteLine("Number Phone: {0}", this.Tlfn);
        }
        public override double hacienda()
        {
            return this.IRPF * this.Salario / 100;
        }
        public double Salario
        {
            set
            {
                this.salario = value;
                if (value < 600)
                {
                    this.irpf =  0.07;
                }else if (value <= 3000)
                {
                    this.irpf = 0.15;
                }
                else
                {
                    this.irpf =  0.2;
                }
            }
            get
            {
                return this.salario;
            }
        }
        public double IRPF {
            get
            {
                return this.irpf;
            }
        }
        public string Tlfn
        {
            set
            {
                int tlfnNum;
                try
                {
                    if (value.Length == 9 && Int32.TryParse(value, out tlfnNum))
                    {
                        this.tlfn = value;
                    }
                    else
                    {
                        Console.WriteLine("Number phone is not correct. Please, try again.");
                    }
                }catch (Exception ex)
                {

                }
                
            }
            get
            {
                return "+34 "+this.tlfn;
            }
        }
    }
    class Directivo : Persona, IPastaGansa
    {
        private string depart;
        private double benefit;
        private int employees;
        public static double ingresos;

        public Directivo(string nombre, string apellidos, string dni, int edad, string depart, int employees) : base(nombre, apellidos, dni, edad)
        {
            this.Depart = depart;
            this.Employees = employees;
            this.Ingresos = 1000;
        }
        public Directivo() : this("", "", "", 0, "", 0)
        {

        }
        public static Directivo operator -- (Directivo dir)
        {
            if(dir.Benefit <= 1)
            {
                dir.Benefit = 0;
            }
            else
            {
                dir.Benefit = dir.Benefit - 1;
            }
            return dir;
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("Departament: {0}", this.Depart);
            Console.WriteLine("Benefit: {0}", this.Benefit);
            Console.WriteLine("Employees: {0}", this.Employees);
            Console.WriteLine("IGanasPasta: {0}", ganasPasta(this.Benefit));
            Console.WriteLine("Hacienda: {0}", this.hacienda());
        }
        public override void setInfo()
        {
            base.setInfo();
            Console.Write("New Departament: ");
            this.Depart = Console.ReadLine();
            Console.Write("New Employees: ");
            this.Employees = Convert.ToInt32(Console.ReadLine());
        }

        public double ganasPasta(double beneficios)
        {
            if (this.Ingresos < 0)
            {
                Directivo nuevoDir = this;
                nuevoDir--;
                return 0;
            }
                return this.Ingresos * beneficios/100;
        }
        
        public override double hacienda()
        {
            return ganasPasta(this.Benefit) * 0.3;
        }
        public double Benefit { get; set; }
        public double Ingresos { get; set; }
        public string Depart { set; get; }
        public int Employees
        {
            set
            {
                this.employees = value;
                if (value <= 10)
                {
                    this.Benefit = 2;
                }else if (value <= 50)
                {
                    this.Benefit = 3.5;
                }
                else
                {
                    this.Benefit = 4;
                }
            }
            get
            {
                return this.employees;
            }
        }
    }
    class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public EmpleadoEspecial(string nombre, string apellidos, string dni, int edad, double salario, string tlfn) : base(nombre, apellidos, dni, edad, salario, tlfn)
        {

        }
        public EmpleadoEspecial() : this("", "", "", 0, 0, "")
        {
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("GanasPasta: {0}", this.ganasPasta(0));
            Console.WriteLine("Hacienda: {0}", this.hacienda());
        }
        public double ganasPasta(double benefits)
        {
            return benefits * 0.5;
        }
        public override double hacienda()
        {
            return base.hacienda() + (ganasPasta(Directivo.ingresos) * 0.1);
        }
    }
}
