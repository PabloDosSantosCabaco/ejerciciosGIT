using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos_5
{
    public partial class Form1 : Form
    {
        private static readonly object l = new object();
        public Form1()
        {
            InitializeComponent();
        }
        public void buscarOcurrencias(FileInfo archivo, string palabra)
        {
            int contador;
            contador = 0;
            string texto;
            using (StreamReader sr = new StreamReader(archivo.FullName))
            {
                texto = sr.ReadToEnd();
            }
            string[] palabras = texto.Split(' ');
            foreach (var p in palabras)
            {
                if (p.Equals(palabra))
                {
                    contador++;
                }
            }
            if (contador > 0)
            {
                lock (l)
                {
                    txtInfo.Invoke((Action)(()=> { 
                        txtInfo.AppendText(archivo.Name + ": " + contador + Environment.NewLine);
                    }));
                }
            }
        }
        public bool comprobarPalabra()
        {
            if (!txtCad.Text.Trim().Equals("") && !txtCad.Text.Trim().Contains(" "))
            {
                return true;
            }
            return false;
        }
        public FileInfo[] getArchivos()
        {
            DirectoryInfo directorio = new DirectoryInfo(txtDir.Text.Trim());
            return directorio.GetFiles("*.txt");
        }
        public bool comprobarDirectorio()
        {
            return Directory.Exists(txtDir.Text.Trim());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (comprobarDirectorio() && comprobarPalabra())
            {
                lblErrorDir.Text = "";
                FileInfo[] archivos = getArchivos();
                Thread[] hilos = new Thread[archivos.Length];
                for(int i=0; i<hilos.Length; i++)
                {
                    int aux = i;
                    hilos[aux] = new Thread(()=> { 
                        buscarOcurrencias(archivos[aux], txtCad.Text); 
                    });
                }
                for(int i=0; i<hilos.Length; i++)
                {
                    hilos[i].Start();
                }
            }
            else
            {
                lblErrorDir.Text = "El directorio no existe";
            }
        }
    }
}
