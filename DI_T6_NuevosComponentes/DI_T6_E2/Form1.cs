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
                    etiquetaAviso1.ClickEnMarca();
                }
            }
        }

        //bandera = !bandera;
        //this.Refresh();
        /*Graphics gr = this.CreateGraphics();
        gr.DrawString("Escribo fuera del OnPaint", this.Font, Brushes.BlueViolet, 10, 10);
        gr.DrawImage(new Bitmap(@"C:\Windows\Web\Wallpaper\Theme2\img7.jpg"), 10, 30);*/

    }
}
