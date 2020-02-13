using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ej5
{
    public partial class Form1 : Form
    {
        static string titulo = " Titulo formulario";
        int count = titulo.Length-1;
        int changeIcon = 0;
        bool kda = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtToAdd.Text.Trim().Equals(""))
            {
                lblTxtError.Text = "Debe introducir un elemento para añadir.";
                timer.Start();
                return;
            }
            lblTxtError.Text = "";
            lst1.Items.Add(txtToAdd.Text);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTxtError.Text = "";

            timer.Stop();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndices.Count < 1)
            {
                lblTxtError.Text = "No hay elementos seleccionados.";
                timer.Start();
                return;
            }
            ListBox.SelectedIndexCollection indices = lst1.SelectedIndices;
            for(int i= indices.Count-1; i>=0; i--)
            {
                lst1.Items.RemoveAt(indices[i]);
            }
            restartLbls();
        }

        private void BtnToRight_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndices.Count < 1)
            {
                lblTxtError.Text = "No hay elementos seleccionados.";
                timer.Start();
                return;
            }
            ListBox.SelectedIndexCollection indices = lst1.SelectedIndices;
            
            for (int i = indices.Count - 1; i >= 0; i--)
            {
                lst2.Items.Insert(0, lst1.Items[indices[i]]);
                lst1.Items.RemoveAt(indices[i]);
            }
            restartLbls();
        }
        private void BtnToLeft_Click(object sender, EventArgs e)
        {
            if (lst2.SelectedIndices.Count < 1)
            {
                lblTxtError.Text = "No hay elementos seleccionados.";
                timer.Start();
                return;
            }
            ListBox.SelectedIndexCollection indices = lst2.SelectedIndices;

            for (int i = indices.Count - 1; i >= 0; i--)
            {
                lst1.Items.Insert(0, lst2.Items[indices[i]]);
                lst2.Items.RemoveAt(indices[i]);
            }
            restartLbls();
        }

        private void Lst1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lst1.SelectedIndices.Count < 1)
            {
                lblTxtError.Text = "No hay elementos seleccionados.";
                timer.Start();
                return;
            }
            ListBox.SelectedIndexCollection indices = lst1.SelectedIndices;
            string cad = $"Elementos seleccionados:{Environment.NewLine}";
            for (int i=0; i<indices.Count; i++)
            {
                cad += $"-{indices[i]}{Environment.NewLine}";
            }
            lblSelectedIndex.Text = cad;
            lblSelectedCount.Text = $"Elementos seleccionados: {indices.Count}";
        }
        public void restartLbls()
        {
            lblSelectedCount.Text = "No hay elementos seleccionados.";
            lblSelectedIndex.Text = "No hay elementos seleccionados.";
            lblTxtError.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temporizador.Start();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            changeIcon++;
            if (changeIcon >= 2)
            {
                if (!kda)
                {
                    this.Icon = new Icon($"{Environment.GetEnvironmentVariable("userprofile")}" + "\\Desktop\\iconos\\kda_ahri.ico");
                    kda = true;
                }
                else
                {
                    this.Icon = new Icon($"{Environment.GetEnvironmentVariable("userprofile")}" + "\\Desktop\\iconos\\arcade_ahri.ico");
                    kda = false;
                }
                changeIcon = 0;
            }
            this.Text = titulo.Substring(count);
            count--;
            if (count <0)
            {
                count = titulo.Length - 1;
            }
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void Lst2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.lst2,lst2.Items.Count.ToString());
        }
    }
}
