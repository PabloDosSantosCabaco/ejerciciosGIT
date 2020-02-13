using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            Process[] procesos = Process.GetProcesses();
            txtInfo.AppendText("PID\tNombre\tTitle"+Environment.NewLine);
            foreach(Process p in procesos){
                txtInfo.AppendText(p.Id+"\t");
                txtInfo.AppendText(p.ProcessName + "\t");
                if (!p.MainWindowTitle.Trim().Equals(""))
                {
                    txtInfo.AppendText(p.MainWindowTitle);
                }
                txtInfo.AppendText(Environment.NewLine);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Process[] procesos = Process.GetProcesses();
            Process proceso = null;
            bool existe = false;
            foreach(Process p in procesos)
            {
                if (txtBoxPID.Text.Trim() == p.Id.ToString())
                {
                    existe = true;
                    proceso = p;
                }
            }
            if (existe)
            {
                txtInfo.Clear();
                txtInfo.AppendText("Nombre: " + proceso.ProcessName + Environment.NewLine);
                txtInfo.AppendText("PID: " + proceso.Id + Environment.NewLine);
                txtInfo.AppendText("Titulo Ventana: " + proceso.MainWindowTitle + Environment.NewLine);
            }
        }
    }
}
