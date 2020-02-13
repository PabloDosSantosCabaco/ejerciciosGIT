using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SERV_T3_E3_Serve
{
    class Program
    {
        public IPEndPoint ie;
        public int puerto = 31416;
        public Socket s;
        public bool running;
        public bool countStart = false;
        public Random rand = new Random();
        List<StreamWriter> clientes = new List<StreamWriter>();
        static readonly private object l = new object();

        static void Main(string[] args)
        {
            Program ej = new Program();
            ej.ie = new IPEndPoint(IPAddress.Any, ej.puerto);
            ej.s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ej.openServe();
            while (ej.running)
            {
                Socket sCliente = ej.s.Accept();
                Thread hilo = new Thread(() =>
                    ej.newClient(sCliente)
                );
                hilo.Start();
                if (ej.clientes.Count >= 2 && !ej.countStart)
                {
                    lock (l)
                    {
                        ej.countStart = true;
                        Thread temporizador = new Thread(() =>
                            ej.temporizador()
                        );
                        temporizador.Start();
                    }
                }
            }
        }
        public void temporizador()
        {
            int tiempo = 10;
            while (tiempo > 0)
            {
                Thread.Sleep(1000);
                lock (l)
                {
                    if (tiempo >= 0)
                    {
                        sendToClients($"El juego comenzará en {tiempo} segundos.");
                        tiempo--;
                    }
                }
            }
        }
        public void jugar()
        {

        }
        public void sendToClients(string cad)
        {
            lock (l)
            {
                foreach (var sw in clientes)
                {
                    sw.WriteLine(cad);
                }
            }
        }
        public void newClient(Socket sCliente)
        {
            lock (l) { 
                int num = rand.Next(0, 100);
                bool conectado = true;
                IPEndPoint ieClient = (IPEndPoint)sCliente.RemoteEndPoint;
                NetworkStream ns = new NetworkStream(sCliente);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                clientes.Add(sw);
            }
        }
        public void openServe()
        {
            running = true;
            s.Bind(ie);
            s.Listen(10);
        }
        public void closeServe()
        {
            running = false;
            s.Close();
        }
    }
}
