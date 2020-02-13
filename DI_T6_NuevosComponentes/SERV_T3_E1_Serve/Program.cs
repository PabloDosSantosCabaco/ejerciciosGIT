using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SERV_T3_E1_Serve
{
    class Program
    {
        IPEndPoint ie;
        IPEndPoint ieClient;
        Socket s;
        Socket sClient;

        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        bool running = true;
        static Program ej = new Program();
        static void Main(string[] args)
        {
            ej.openConection();
            while (ej.running)
            {
                ej.clientConection();
            };
            ej.closeConection();
        }
                
        public void openConection()
        {
            ie = new IPEndPoint(IPAddress.Any, 31416);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie); //COMPROBAR PUERTO OCUPADO
            s.Listen(5);
        }
        public void closeConection()
        {
            s.Close();

        }
        public void clientConection()
        {
            sClient = s.Accept();

            ns = new NetworkStream(sClient);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);

            switch (sr.ReadLine())
            {
                case "HORA":
                    sw.WriteLine(DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes + ":" + DateTime.Now.TimeOfDay.Seconds);
                    break;
                case "FECHA":
                    sw.WriteLine(DateTime.Now.Date.Day + "/" + DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year);
                    break;
                case "TODO":
                    sw.WriteLine(DateTime.Now);
                    break;
                case "DESCONECTAR":
                    running = false;
                    break;
            }
            sw.Flush();
            ns.Close();
            sr.Close();
            sw.Close();
            sClient.Close();
        }
    }
}
