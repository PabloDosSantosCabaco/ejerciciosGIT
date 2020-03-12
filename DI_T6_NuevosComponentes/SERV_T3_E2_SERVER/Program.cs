using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SERV_T3_E2_Serve
{
    class Program
    {
        public IPEndPoint ie;
        public Socket s;
        public bool running = true;
        static Program p = new Program();
        List<string> usuarios = new List<string>();
        List<StreamWriter> destinos = new List<StreamWriter>();

        static void Main(string[] args)
        {
            p.ie = new IPEndPoint(IPAddress.Any, 31416);
            p.s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            p.openServe();
            while (p.running)
            {
                Socket sClient = p.s.Accept();
                Thread hilo = new Thread(()=>
                    p.clientConnection(sClient)
                );
                hilo.Start();
            }
            p.closeServe();
        }
        public void clientConnection(Socket sClient)
        {
            bool conectado = true;
            IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
            Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address, ieClient.Port);
            NetworkStream ns = new NetworkStream(sClient);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            destinos.Add(sw);
            String usuario = "";
            sw.WriteLine("Introduzca un nombre de usuario: ");
            sw.Flush();
            usuario = sr.ReadLine();
            usuarios.Add(usuario + "@" + ieClient.Address);
            sendMessages("Client connected:" + usuario + "@" + ieClient.Address + " at port " + ieClient.Port, sw);
            while (conectado)
            {
                try
                {
                    string mensaje = sr.ReadLine();
                    if (mensaje != null)
                    {
                        switch (mensaje)
                        {
                            case "#salir":
                                conectado = false;
                                break;
                            case "#lista":
                                showList(sw);
                                break;
                            default:
                                sendMessages(usuario + "@" + ieClient.Address + ":"+mensaje,sw);
                                mensaje = null;
                                break;
                        }
                    }
                    else
                    {
                        conectado = false;
                    }
                }
                catch (IOException)
                {
                    conectado = false;
                }
            }
            Console.WriteLine("Client disconnected:{0} at port {1}", ieClient.Address, ieClient.Port);
            sendMessages("Client disconnected:"+ usuario + "@" + ieClient.Address + " at port "+ ieClient.Port, sw);
            usuarios.Remove(usuario + "@" + ieClient.Address);
            destinos.Remove(sw);
            sw.Close();
            sr.Close();
            ns.Close();
            sClient.Close();
        }
        public void sendMessages(string mensaje,StreamWriter sw)
        {
            foreach(var destino in destinos)
            {
                if (destino != sw)
                {
                    destino.WriteLine(mensaje);
                    destino.Flush();
                }
            }
        }
        public void showList(StreamWriter swd)
        {
            swd.WriteLine("Usuarios conectados");
            swd.WriteLine("*********************");
            foreach (string usuario in usuarios)
            {
                swd.WriteLine(usuario);
            }
            swd.WriteLine("*********************");
            swd.Flush();
        }
        public void openServe()
        {
            s.Bind(p.ie);
            s.Listen(100);
        }
        public void closeServe()
        {
            s.Close();
        }
    }
}
// Locks y puerto ocupado