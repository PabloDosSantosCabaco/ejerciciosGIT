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

namespace SERV_T3_E4_Client
{
    public partial class Form1 : Form
    {
        public IPEndPoint ie;
        public string direccion = "127.0.0.1";
        public int puerto = 31416;
        public Socket s;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        public string palabra = "";
        public Form1()
        {
            InitializeComponent();
            conectar();
        }

        public void conectar()
        {
            ie = new IPEndPoint(IPAddress.Parse(direccion), puerto);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(ie);
            }
            catch (SocketException) { }
            ns = new NetworkStream(s);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
        }
        public void desconectar()
        {
            s.Close();
        }
        private void btnPalabra_Click(object sender, EventArgs e)
        {
            sw.WriteLine("word");
            sw.Flush();
            palabra = sr.ReadLine();
            lblTextos.Text = palabra;
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            conectar();
        }
    }
}
