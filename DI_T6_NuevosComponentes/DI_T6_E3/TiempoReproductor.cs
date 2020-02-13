using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T6_E3
{
    public partial class TiempoReproductor : Control
    {
        int contSec = 0;
        int contMin = 0;
        int ms = 0;
        public TiempoReproductor()
        {
            InitializeComponent();
        }
        public void ActualizarTiempo()
        {
            contSec++;
            if (contSec >= 60)
            {
                contSec = 0;
                contMin++;
                if (contMin > 99)
                {
                    contMin = 0;
                }
            }
            this.Text = $"{contMin,0}:{contSec,2}";
            Refresh();
        }
        public void Timer()
        {
            ms++;
            if (ms >= 1000)
            {
                ms = 0;
                ActualizarTiempo();
            }
            Refresh();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Timer();
            
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, 0, 0);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width, tam.Height);
            b.Dispose();
        }
    }
}
