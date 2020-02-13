#define TECLA_

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio2
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        public Form1()
        {
            InitializeComponent();
        }

        
        //TITULO COORDENADAS
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mouse Tester X:"+e.X + " Y:"+ e.Y;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Text = "Mouse Tester X:" + e.X + " Y:" + e.Y;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void BtnR_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mouse Tester X:" + (x+e.X) + " Y:" + (y+e.Y);
        }

        private void BtnL_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mouse Tester X:" + (x + e.X) + " Y:" + (y + e.Y);
        }
        //CAMBIOS TITULO TECLADO
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if TECLA
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyChar + "";
            }
#endif
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if !TECLA
            Text = e.KeyCode.ToString();
#endif

        }
        //Cambios color botones
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnL.BackColor = Color.Red;
            }else if(e.Button == MouseButtons.Right)
            {
                btnR.BackColor = Color.Red;
            }
            else
            {
                btnL.BackColor = Color.Red;
                btnR.BackColor = Color.Red;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            btnL.BackColor = Color.Empty;
            btnR.BackColor = Color.Empty;
        }

        //CONFIRMAR SALIDA
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que quieres salir?","Confirmar salida",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                )==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
