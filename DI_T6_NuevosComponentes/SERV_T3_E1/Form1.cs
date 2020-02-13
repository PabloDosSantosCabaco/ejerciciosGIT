using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERV_T3_E1
{
    public partial class Form1 : Form
    {
        IPEndPoint ie;
        IPEndPoint ieClient;
        Socket s;
        Socket sClient;

        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        bool running = true;
        public Form1()
        {
            InitializeComponent();
            openConection();
            while (running)
            {
                clientConection();
            };
            closeConection();
        }
        public void openConection()
        {
            ie = new IPEndPoint(IPAddress.Any, 31416);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie);
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
                    sw.WriteLine(DateTime.Now);
                    break;
                case "FECHA":
                    break;
                case "TODO":
                    break;
                case "DESCONECTAR":
                    break;
            }
        }
    }
}
