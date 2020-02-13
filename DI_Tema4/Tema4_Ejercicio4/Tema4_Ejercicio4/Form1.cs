using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio4
{
    public partial class Form1 : Form
    {
        public delegate double Operaciones(double a, double b);
        Hashtable signos = new Hashtable();
        int segundos = 0;
        int minutos = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = String.Format("{0,0:D2} : {1,0:D2}", minutos, segundos);
            signos.Add("+", new Operaciones((a,b)=> { return Double.Parse(txtDato1.Text) + Double.Parse(txtDato2.Text); }));
            signos.Add("-", new Operaciones((a, b) => { return Double.Parse(txtDato1.Text) - Double.Parse(txtDato2.Text); }));
            signos.Add("*", new Operaciones((a, b) => { return Double.Parse(txtDato1.Text) * Double.Parse(txtDato2.Text); }));
            signos.Add("/", new Operaciones((a, b) => { return Double.Parse(txtDato1.Text) / Double.Parse(txtDato2.Text); }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void RbtnSuma_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "+";
        }

        private void RbtnResta_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "-";
        }

        private void RbtnMult_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "*";
        }

        private void RbtnDiv_CheckedChanged(object sender, EventArgs e)
        {
            lblSign.Text = "/";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!txtDato1.Text.Trim().Equals("") && !txtDato2.Text.Trim().Equals(""))
            {
                try
                {
                    lblError.Text = "";
                    double dato1 =Double.Parse(txtDato1.Text);
                    double dato2 =Double.Parse(txtDato2.Text);
                    lblError.Text = dato1 +" "+ lblSign.Text + " " + dato2 + " " + "=" + " " + ((Operaciones)signos[lblSign.Text])(dato1, dato2);
                }
                catch (OverflowException)
                {
                    lblError.Text = "El número es demasiado grande.";
                }
                catch (FormatException)
                {
                    lblError.Text += "No son válidas las cadenas de caracteres.";
                }
            }
            else
            {
                lblError.Text = "Rellene los campos por favor";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos >= 60)
            {
                segundos = 0;
                minutos++;
            }
            this.Text = String.Format("{0,0:D2} : {1,0:D2}", minutos, segundos);
        }
    }

}
