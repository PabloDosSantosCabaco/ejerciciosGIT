using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ejercicio2
{
    enum asignaturas
    {
        AccesoADatos,
        DesarrolloDeInterfaces,
        Empresa,
        GestiónDeEmpresa
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<int> indicesAprobados = new List<int>();
            string[] alumnos = new string[] { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "A11", "A12" };
            Aula aula = new Aula();
            bool salir = false;
            int opcion = 0;
            int max = 0, min = 0;
            do
            {
                Console.WriteLine("1.Calcular media de la tabla.");
                Console.WriteLine("2.Media alumno.");
                Console.WriteLine("3.Media asignatura.");
                Console.WriteLine("4.Notas de un alumno.");
                Console.WriteLine("5.Notas de una asignatura.");
                Console.WriteLine("6.Máxima y mínima de un alumno.");
                Console.WriteLine("7.Tabla de aprobados.");
                Console.WriteLine("8.Ver tabla completa.");
                Console.WriteLine("9.Salir");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect value");
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("La media global es de {0}", aula.mediaGlobal());
                        break;
                    case 2:
                        opcion = mostrarAlumnos(alumnos);
                        if (opcion >= 0)
                        {
                            Console.WriteLine("La media del alumno {0} es de {1}", alumnos[opcion], aula.mediaAlumno(opcion));
                        }
                        break;
                    case 3:
                        opcion = mostrarAsignaturas();
                        if (opcion >= 0)
                        {
                            Console.WriteLine("La media de la asignatura {0} es de {1}", Enum.GetNames(typeof(asignaturas))[opcion], aula.mediaAignatura(opcion));
                        }
                        break;
                    case 4:
                        opcion = mostrarAlumnos(alumnos);
                        if (opcion >= 0)
                        {
                            for (int i = 0; i < aula.verNotasAlumno(opcion).Length; i++)
                            {
                                Console.WriteLine("{1}: {0}", aula.verNotasAlumno(opcion)[i], Enum.GetName(typeof(asignaturas), i));
                            }
                        }
                        break;
                    case 5:
                        opcion = mostrarAsignaturas();
                        if (opcion >= 0)
                        {
                            for (int i = 0; i < aula.verNotasAsignatura(opcion).Length; i++)
                            {
                                Console.WriteLine("{1}: {0}", aula.verNotasAsignatura(opcion)[i], alumnos[i]);
                            }
                        }
                        break;
                    case 6:
                        opcion = mostrarAlumnos(alumnos);
                        if (opcion >= 0)
                        {
                            aula.notaMaxMin(opcion, ref max, ref min);
                            Console.WriteLine("La nota máxima del alumno {0} es de {1} y su nota mínima es de {2}.", alumnos[opcion], max, min);
                        }
                        break;
                    case 7:
                        for (int i = 0; i < Enum.GetValues(typeof(asignaturas)).Length; i++)
                        {
                            Console.Write("\t" + Enum.GetName(typeof(asignaturas), i).Substring(0, 5));
                        }
                        Console.WriteLine();
                        int[,] aux = aula.tablaAprobados(ref indicesAprobados);
                        for (int i = 0; i < aux.GetLength(0); i++)
                        {
                            Console.Write(alumnos[indicesAprobados[i]] + "\t");
                            for (int j = 0; j < aux.GetLength(1); j++)
                            {
                                Console.Write(aux[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        for (int i = 0; i < Enum.GetValues(typeof(asignaturas)).Length; i++)
                        {
                            Console.Write("\t" + Enum.GetName(typeof(asignaturas), i).Substring(0, 5));
                        }
                        Console.WriteLine();
                        for (int i = 0; i < aula.Notas.GetLength(0); i++)
                        {
                            Console.Write(alumnos[i] + "\t");
                            for (int j = 0; j < aula.Notas.GetLength(1); j++)
                            {
                                Console.Write(aula.Notas[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 9:
                        salir = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Incorrect value. Please, choose a number of the list.");
                        break;
                }

            } while (!salir);
        }
        public static int mostrarAsignaturas()
        {
            int opcion;
            Console.WriteLine("Escoja una asignatura:");
            for (int i = 0; i < Enum.GetValues(typeof(asignaturas)).Length; i++)
            {
                Console.WriteLine("{0}.{1}", i, Enum.GetNames(typeof(asignaturas))[i]);
            }
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion < 0 || opcion > Enum.GetValues(typeof(asignaturas)).Length - 1)
            {
                Console.WriteLine("Valor incorrecto. Escoja uno de la lista por favor.");
                return -1;
            }
            return opcion;
        }
        public static int mostrarAlumnos(String[] alumnos)
        {
            int opcion;
            Console.WriteLine("Escoja un alumno:");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("{0}.{1}", i, alumnos[i]);
            }
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion < 0 || opcion > alumnos.Length - 1)
            {
                Console.WriteLine("Valor incorrecto. Escoja uno de la lista por favor.");
                return -1;
            }
            return opcion;
        }

    }
    class Aula
    {

        int[,] notas = new int[12, 4];
        public Aula()
        {
            llenarTable();
        }
        public double mediaGlobal()
        {
            double media = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    media += notas[i, j];
                }
            }
            media = media / notas.Length;

            return media;
        }
        public double mediaAlumno(int alumno)
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                media += notas[i, alumno];
            }
            media = media / notas.GetLength(0);
            return media;
        }
        public double mediaAignatura(int asignatura)
        {
            double media = 0;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                media += notas[asignatura, i];
            }
            media = media / notas.GetLength(1);
            return media;
        }
        public int[] verNotasAlumno(int alumno)
        {
            int[] notasAlumno = new int[notas.GetLength(1)];
            for (int i = 0; i < notasAlumno.Length; i++)
            {
                notasAlumno[i] = notas[alumno, i];
            }
            return notasAlumno;
        }
        public int[] verNotasAsignatura(int asignatura)
        {
            int[] notasAsignatura = new int[notas.GetLength(0)];
            for (int i = 0; i < notasAsignatura.Length; i++)
            {
                notasAsignatura[i] = notas[i, asignatura];
            }
            return notasAsignatura;
        }
        public void notaMaxMin(int alumno, ref int max, ref int min)
        {
            int notaMax = 0;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (notas[alumno, i] > notaMax) notaMax = notas[alumno, i];
            }
            max = notaMax;
            int notaMin = 10;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (notas[alumno, i] < notaMin) notaMin = notas[alumno, i];
            }
            min = notaMin;
        }
        public int[,] tablaAprobados(ref List<int> indicesAprobados)
        {
            indicesAprobados = new List<int>();
            int contador = 0, contadorAprobados = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] >= 5)
                    {
                        contador++;
                    }
                }
                if (contador >= notas.GetLength(1))
                {
                    contadorAprobados++;
                }
                contador = 0;
            }
            int[,] alumnosAprobados = new int[contadorAprobados, notas.GetLength(1)];
            contadorAprobados = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] >= 5)
                    {
                        contador++;
                    }
                }
                if (contador >= notas.GetLength(1))
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        alumnosAprobados[contadorAprobados, j] = notas[i, j];
                    }
                    indicesAprobados.Add(i);
                    contadorAprobados++;
                }
                contador = 0;
            }
            return alumnosAprobados;
        }
        public void llenarTable()
        {
            Random number = new Random();
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    int nota = number.Next(30, 101);
                    notas[i, j] = calculaNota(nota);
                }
            }
        }
        public int calculaNota(int num)
        {
            switch (num)
            {
                case int n when (n <= 5):
                    return 0;
                case int n when (n <= 10):
                    return 1;
                case int n when (n <= 15):
                    return 2;
                case int n when (n <= 25):
                    return 3;
                case int n when (n <= 40):
                    return 4;
                case int n when (n <= 55):
                    return 5;
                case int n when (n <= 70):
                    return 6;
                case int n when (n <= 80):
                    return 7;
                case int n when (n <= 90):
                    return 8;
                case int n when (n <= 95):
                    return 9;
                default:
                    return 10;
            }
        }
        public int[,] Notas
        {
            get
            {
                return this.notas;
            }
            set
            {
                llenarTable();
            }
        }
    }
}
