using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        int intentos = 3;
        string codigo = "1234";
        bool pinCorrecto = false;
        string[] valores = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
        int countRowBtn = 0;
        int initX = 30;
        int initY = 82;
        int plus = 56;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Solicitud PIN
            Form2 formPIN = new Form2();
            while (!pinCorrecto)
            {
                if (intentos <= 0)
                {
                    this.Close();
                    return;
                }
                switch (formPIN.ShowDialog())
                {
                    case DialogResult.OK:
                        if (formPIN.txtPIN.Text.Trim().Equals(codigo))
                        {
                            pinCorrecto = true;
                            formPIN.Close();
                        }
                        else
                        {
                            intentos--;
                            formPIN.lblError.Text = $"PIN no válido.{Environment.NewLine}Quedan {intentos} intentos.";
                        }
                        break;
                }
            }

            //Creación de botones
            for(int i=0; i<valores.Length; i++)
            {
                Button btn = new Button();
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Location = new System.Drawing.Point(initX, initY);
                btn.Name = "btn"+i;
                btn.Size = new System.Drawing.Size(50, 50);
                btn.TabIndex = 1;
                btn.Text = valores[i];
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(this.Button1_Click);
                btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
                btn.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
                this.Controls.Add(btn);
                countRowBtn++;
                initX += plus;
                if (countRowBtn % 3 == 0)
                {
                    countRowBtn = 0;
                    initY += plus;
                    initX -= (plus * 3);
                }
            }

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            txtNumbers.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Aqua;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((Button)sender).BackColor == Color.Aqua)
            {
                return;
            }
            ((Button)sender).BackColor = Color.Red;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            if(((Button)sender).BackColor == Color.Aqua)
            {
                return;
            }
            ((Button)sender).BackColor = DefaultBackColor;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            txtNumbers.Clear();
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    boton.BackColor = DefaultBackColor;
                }
            }
        }

        private void GrabarNúmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text.Trim().Equals(""))
            {
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(txtNumbers.Text);
                }
            }
        }
    }
}
