using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERV_T3_E1_Client
{
    public partial class VentanaIP : Form
    {
        Cliente f1;
        bool permisoCierre = false;
        public VentanaIP(Cliente cl)
        {
            InitializeComponent();
            f1 = cl;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                f1.setDireccion(IPAddress.Parse(txtIP.Text));
                f1.setPuerto(Convert.ToInt32(txtPuerto.Text));
                permisoCierre = true;
                this.Close();
            }
        }
        public bool checkData()
        {
            try
            {
                IPAddress.Parse(txtIP.Text);
                if(Convert.ToInt32(txtPuerto.Text)<0 || Convert.ToInt32(txtPuerto.Text) > 65535)
                {
                    return false;
                }
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    s.Bind(new IPEndPoint(IPAddress.Any, Convert.ToInt32(txtPuerto.Text)));
                    Console.WriteLine($"Port {Convert.ToInt32(txtPuerto.Text)} free");
                }
                catch (SocketException e) when (e.ErrorCode == (int)SocketError.AddressAlreadyInUse)
                {
                    Console.WriteLine($"Port {Convert.ToInt32(txtPuerto.Text)} in use");
                    return false;
                }
                s.Close();
                return true;
            }
            catch (SocketException ex)
            {
            }
            catch (OverflowException)
            {
            }
            catch (FormatException)
            {
            }
            return false;
        }

        private void VentanaIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!permisoCierre)
            {
                e.Cancel = true;
            }
        }
    }
}
