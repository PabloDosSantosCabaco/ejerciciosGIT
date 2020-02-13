using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace DI_T6_E2
{
    public partial class EtiquetaAviso : Control
    {
        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }
        private eMarca marca = eMarca.Nada;
        public bool gradiente;
        public Image imagenMarca;
        public Color colorInicial, colorFinal;
        private int imgAncho = 0, imgAlto = 0;
        private int contador = 0;

        public EtiquetaAviso()
        {
            InitializeComponent();
            gradiente = false;
            colorInicial = Color.Red;
            colorFinal = Color.Black;
            this.Refresh();
        }
        [Category("FOO")]
        [Description("Establece la imagen de la marca")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }
        [Category("FOO")]
        [Description("Establece el color inicial del gradiente")]
        public Color ColorInicial
        {
            set
            {
                colorInicial = value;
                Refresh();
            }
            get
            {
                return colorInicial;
            }
        }
        [Category("FOO")]
        [Description("Establece el color final del gradiente")]
        public Color ColorFinal
        {
            set
            {
                colorFinal = value;
                Refresh();
            }
            get
            {
                return colorFinal;
            }
        }
        [Category("FOO")]
        [Description("Indica si dibuja un degradado o no")]
        public bool Gradiente
        {
            set {
                gradiente = value;
                Refresh();
            }
            get { return gradiente; }
        }
        [Category("FOO")]
        [Description("Indica si muestra una cruz, un círculo, una imagen o nada")]
        public eMarca Marca
        {
            set
            {
                if (Enum.IsDefined(typeof(eMarca), value))
                {
                    marca = value;
                    this.Refresh();
                }
            }
            get { return marca; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
                             // a la hora de dibujar
            imgAlto = 0;
            imgAncho = 0;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            if (gradiente)
            {
                LinearGradientBrush fondo = new LinearGradientBrush(new PointF(0,0),new PointF(this.Width,0),ColorInicial,ColorFinal);
                g.FillRectangle(fondo,new Rectangle(0,0,this.Width,this.Height));
            }
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                   this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height,
                   this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor,
                   this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagenMarca != null)
                    {
                        g.DrawImage(imagenMarca, offsetX, offsetY, imagenMarca.Width, imagenMarca.Height);
                        offsetY = imagenMarca.Height/2-this.Font.Height;
                        offsetX = imagenMarca.Width;
                       
                    }
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY*2);
            b.Dispose();
        }        public void ClickEnMarca()
        {
            contador++;
            this.Text =$"Pulsado {contador} veces";
            Refresh();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
    }
}
