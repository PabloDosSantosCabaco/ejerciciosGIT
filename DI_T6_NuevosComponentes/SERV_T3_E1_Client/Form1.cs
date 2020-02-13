using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace SERV_T3_E1_Client
{
    public partial class Cliente : Form
    {
        IPEndPoint ie;
        Socket server;

        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        IPAddress direccion;
        int puerto;
        bool running = true;
        VentanaIP form2;
        public void setDireccion(IPAddress direccion)
        {
            this.direccion = direccion;
        }
        public void setPuerto(int puerto)
        {
            this.puerto = puerto;
        }
        public Cliente()
        {
            InitializeComponent();
            form2 = new VentanaIP(this);
            form2.ShowDialog();
            ie = new IPEndPoint(direccion, puerto);
        }
        public bool conectar()
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork,
 SocketType.Stream, ProtocolType.Tcp);
                server.Connect(ie);
                return true;
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Error connection: {0}\nError code: {1}({2})",
                    ex.Message, (SocketError)ex.ErrorCode, ex.ErrorCode);
                return false;
            }
        }
        public void pedirDato(string dato)
        {
            string msg;
            if (conectar())
            {
                ns = new NetworkStream(server);
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                sw.WriteLine(dato);
                sw.Flush();
                lblInfo.Text = sr.ReadLine();
                closeConnection();
            }
        }
        public void closeConnection()
        {
            sr.Close();
            sw.Close();
            ns.Close();
            server.Close();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            pedirDato("FECHA");
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            pedirDato("HORA");
        }

        private void btnFechaHora_Click(object sender, EventArgs e)
        {
            pedirDato("TODO");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pedirDato("DESCONECTAR");
            this.Close();
        }
    }
}
