using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T6_E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (etiquetaAviso1.Gradiente)
            {
                btnGrad.Text = "Gradiente: ON";
            }
            for(int i=0; i<Enum.GetNames(typeof(EtiquetaAviso.eMarca)).Length; i++)
            {
                cmbBox.Items.Add(Enum.GetNames(typeof(EtiquetaAviso.eMarca))[i]);
            }
            cmbBox.Text = etiquetaAviso1.Marca+"";
        }
        bool bandera = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            /*base.OnPaint(e);
            if (bandera)
            {
                e.Graphics.DrawString("Prueba de escritura de texto",
                this.Font, Brushes.BlueViolet, 10, 10);
            }*/
        }

        private void EtiquetaAviso1_MouseClick(object sender, MouseEventArgs e)
        {
            if (etiquetaAviso1.Marca != EtiquetaAviso.eMarca.Nada)
            {
                if(etiquetaAviso1.imagenMarca.Width>=e.X && etiquetaAviso1.imagenMarca.Height >= e.Y)
                {
                    etiquetaAviso1.CickEnMarca();
                }
            }
        }

        private void btnGrad_Click(object sender, EventArgs e)
        {
            if (etiquetaAviso1.Gradiente)
            {
                btnGrad.Text = "GRADIENTE: OFF";
                etiquetaAviso1.Gradiente = false;
            }
            else
            {
                btnGrad.Text = "GRADIENTE: ON";
                etiquetaAviso1.Gradiente = true;
            }
            //Refresh();
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBox.SelectedItem)
            {
                case EtiquetaAviso.eMarca.Nada:
                    etiquetaAviso1.Marca = EtiquetaAviso.eMarca.Nada;
                    break;
                case EtiquetaAviso.eMarca.Cruz:
                    etiquetaAviso1.Marca = EtiquetaAviso.eMarca.Cruz;
                    break;
                case EtiquetaAviso.eMarca.Circulo:
                    etiquetaAviso1.Marca = EtiquetaAviso.eMarca.Circulo;
                    break;
                case EtiquetaAviso.eMarca.Imagen:
                    etiquetaAviso1.Marca = EtiquetaAviso.eMarca.Imagen;
                    break;
            }
        }

        //bandera = !bandera;
        //this.Refresh();
        /*Graphics gr = this.CreateGraphics();
        gr.DrawString("Escribo fuera del OnPaint", this.Font, Brushes.BlueViolet, 10, 10);
        gr.DrawImage(new Bitmap(@"C:\Windows\Web\Wallpaper\Theme2\img7.jpg"), 10, 30);*/

    }
}
