﻿using System;
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
        List<int> numeros = new List<int>();

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
            }
        }
        public void temporizador()
        {
            int tiempo = 10;
            while (tiempo >= 0)
            {
                Thread.Sleep(1000);
                lock (l)
                {
                    if (tiempo >= 0)
                    {
                        sendToClients($"El juego comenzará en {tiempo} segundos.");
                        tiempo--;
                        if (tiempo < 0)
                        {
                            Monitor.PulseAll(l);
                        }
                    }
                }
            }
        }
        public int getMaximo()
        {
            int max = 0;
            foreach (var num in numeros)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public void sendToClients(string cad)
        {
            lock (l)
            {
                foreach (var sw in clientes)
                {
                    try
                    {
                        sw.WriteLine(cad);
                        sw.Flush();
                    }catch(IOException ex) { }
                }
            }
        }
        public void newClient(Socket sCliente)
        {
            lock (l) { 
                int num = rand.Next(0, 100);
                numeros.Add(num);
                bool conectado = true;
                IPEndPoint ieClient = (IPEndPoint)sCliente.RemoteEndPoint;
                NetworkStream ns = new NetworkStream(sCliente);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                clientes.Add(sw);
                if (clientes.Count >= 2 && !countStart)
                {
                    countStart = true;
                    Thread temp = new Thread(() =>
                        temporizador()
                    );
                    temp.Start();
                }
                Monitor.Wait(l);
                try
                {
                    if (getMaximo() == num)
                    {
                        sw.WriteLine("Has gannado");
                    }
                    else
                    {
                        sw.WriteLine($"Has perdido, tu número era el {num} y ha ganado {getMaximo()}");
                    }
                    sw.Flush();
                }catch(IOException ex) { }
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
