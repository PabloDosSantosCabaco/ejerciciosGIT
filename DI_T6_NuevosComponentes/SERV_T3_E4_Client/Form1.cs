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
using System.Threading;
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

        public Label[] letras;
        public string palabra = "";
        public int vidas = 10;
        public bool jugando = false;

        int temporizador = 0;

        private static readonly object l = new object();
        public Form1()
        {
            InitializeComponent();
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
            construirPalabra(palabra);
        }
        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            conectar();
            jugando = true;
            Thread tiempo = new Thread(()=>
                hiloTiempo()
            );
            tiempo.Start();
            construirPalabra(pedirPalabra());

        }
        public void hiloTiempo()
        {
            while (jugando)
            {
                lock (l)
                {
                    if (jugando)
                    {
                        temporizador++;
                    }
                }
                Thread.Sleep(1000);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conectar();
            sw.WriteLine("cierre");
            sw.Flush();
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            sw.WriteLine("record");
            sw.Flush();
            while (sr.Peek()!=-1)
            {
                lstRecords.Items.Add(sr.ReadLine() + "\t" + sr.ReadLine());
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!jugando || vidas <= 0)
            {
                return;
            }
            if (!sendLetra())
            {
                vidas--;
                if (vidas <= 0)
                {
                    ahorcar();
                    lblTextos.Text = "Has perdido";
                }
            }
            if (comprobarFinal())
            {
                lblTextos.Text = "Ganaste"+temporizador;
                jugando = false;
            }
        }
        public void construirPalabra(string palabra)
        {
            letras = new Label[palabra.Length];
            for(int i=0; i<palabra.Length; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(50+(i*20), 116);
                lbl.Size = new System.Drawing.Size(35, 13);
                lbl.TabIndex = 6;
                lbl.Text = "_";
                this.Controls.Add(lbl);
                letras[i] = lbl;
            }
            lblTextos.Text = palabra;
            this.palabra = palabra;
        }
        public string pedirPalabra()
        {
            sw.WriteLine("word");
            sw.Flush();
            return sr.ReadLine();
        }
        public void ahorcar()
        {
            switch (vidas)
            {
                case 9:

                    break;
            }
        }
        public bool comprobarFinal()
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                if (letras[i].Text.ToString() == "_")
                {
                    return false;
                }
            }
            return true;
        }
        public bool sendLetra()
        {
            bool added = false;
            if (palabra.ToLower().Contains(txtLetra.Text.ToLower()) && txtLetra.Text.Length == 1)
            {
                for(int i=0; i<palabra.Length; i++)
                {
                    if (palabra[i].ToString().ToLower() == txtLetra.Text.ToLower())
                    {
                        letras[i].Text = palabra[i].ToString();
                        added = true;
                    }
                }
            }
            return added;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.Red, 5), 200, 400, 300, 400);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}
