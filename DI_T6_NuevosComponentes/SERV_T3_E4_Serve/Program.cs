using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SERV_T3_E4_Serve
{
    class Program
    {
        bool running = false;
        bool clientConnected = false;
        int puerto = 31416;
        IPEndPoint ie;
        Socket s;
        List<string> palabras = new List<string>();
        List<Record> records = new List<Record>();
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        int maximoRecords = 10;

        static void Main(string[] args)
        {
            Program ej = new Program();
            ej.ie = new IPEndPoint(IPAddress.Any, ej.puerto);
            ej.s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ej.llenarPalabras();
            ej.llenarRecords();
            ej.openServe();
            while (ej.running)
            {
                Socket sClient = ej.s.Accept();
                Thread hilo = new Thread(()=> 
                    ej.newClient(sClient)
                );
                hilo.Start();
            }
        }

        public void openServe()
        {
            if (!running)
            {
                running = true;
                s.Bind(ie);
                s.Listen(2);
            }
        }
        public void closeServe()
        {
            if (running)
            {
                running = false;
                s.Close();
            }
        }

        public void newClient(Socket sClient)
        {
            clientConnected = true;
            ns = new NetworkStream(sClient);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            Console.WriteLine("Cliente conectado");
            while (clientConnected)
            {
                string peticion = sr.ReadLine();
                switch (peticion)
                {
                    case "word":
                        Console.WriteLine("He leido");
                        sw.WriteLine(getword());
                        break;
                    case "cierre":
                        Console.WriteLine("El cliente se ha desconectado");
                        clientConnected = false;
                        break;
                    case "record":
                        foreach(var recor in records)
                        {
                            sw.WriteLine(recor.Name);
                            sw.WriteLine(recor.Score);
                        }
                        sw.Flush();
                        break;
                }
                sw.Flush();

            }
        }

        public void llenarPalabras()
        {
            try
            {
                if (File.Exists(Environment.GetEnvironmentVariable("appdata") + "/palabrasAhorcado"))
                {
                    Console.WriteLine("Existe");
                    using (StreamReader sr = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "/palabrasAhorcado"))
                    {
                        while (sr.Peek() > -1)
                        {
                            palabras.Add(sr.ReadLine());
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "/palabrasAhorcado"))
                    {
                        Console.WriteLine("No existe");
                        foreach (var palabra in palabras)
                        {
                            sw.WriteLine(palabra);
                        }
                    }
                }
                palabras.Add("Hola");
            }
            catch (FileNotFoundException)
            {

            }
        }
        public void llenarRecords()
        {
            try
            {
                if (File.Exists(Environment.GetEnvironmentVariable("appdata") + "/recordsAhorcado"))
                {
                    using (StreamReader sr = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "/recordsAhorcado"))
                    {
                        while (sr.Peek() > -1 && records.Count < maximoRecords)
                        {
                            try
                            {
                                records.Add(new Record(sr.Read(), sr.ReadLine()));
                            }
                            catch (IOException)
                            {

                            }
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "/recordsAhorcado"))
                    {
                        Console.WriteLine("No existe");
                        foreach (var recor in records)
                        {
                            sw.WriteLine(recor);
                        }
                    }
                }
                records.Add(new Record());
            }
            catch (FileNotFoundException) { }
        }
        public string getword()
        {
            Random num = new Random();
            return palabras[num.Next(0, palabras.Count - 1)];
        }
        public void sendword(string word)
        {
            if (word.Trim().Length > 0)
            {
                palabras.Add(word);
            }
        }
        public List<Record> getrecords()
        {
            return records;
        }
        public void sendrecord(Record record)
        {
            if(records.Count < 10)
            {
                records.Add(record);
            }
            else
            if (records[records.Count - 1].Score < record.Score)
            {
                records.RemoveAt(records.Count - 1);
                records.Add(record);
            }
            sortRecords();
        }
        public void sortRecords()
        {
            int maxRec = 0;
            Record recaux = new Record();
            List<Record> aux = records;
            records.Clear();
            while (aux.Count > 0)
            {
                foreach(var rec in aux)
                {
                    if (rec.Score > maxRec)
                    {
                        maxRec = rec.Score;
                        recaux = rec;
                    }
                }
                records.Add(recaux);
                aux.Remove(recaux);
                maxRec = 0;
            }
        }
        public void closeserver(int clave)
        {
            saveData();
        }
        public void saveData()
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "/palabrasAhorcado"))
            {
                foreach (var palabra in palabras)
                {
                    sw.WriteLine(palabra);
                }
            }
            using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "/recordsAhorcado"))
            {
                foreach (var record in records)
                {
                    sw.WriteLine(record.Score);
                    sw.WriteLine(record.Name);
                }
            }
        }
    }
}
