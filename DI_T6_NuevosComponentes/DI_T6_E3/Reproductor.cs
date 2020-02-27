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
    public partial class Reproductor : UserControl
    {
        int contSec = 0;
        public int contMin = 0;
        string[] estados = { "Play", "Pause" };
        public bool running = false;
        public event System.EventHandler DesbordaTiempo;
        public Reproductor()
        {
            InitializeComponent();
            btnPlay.Text = estados[0];
            lblTime.Text = String.Format("{0,2:D2}:{1,2:D2}", contMin, contSec);
            timer1.Start();
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
                    DesbordaTiempo?.Invoke(this,EventArgs.Empty);
                }
            }
            lblTime.Text = String.Format("{0,2:D2}:{1,2:D2}", contMin, contSec);
            Refresh();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            /*SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, 0, 0);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();*/
            this.Size = new Size(Math.Max(lblTime.Width,btnPlay.Width), lblTime.Height+btnPlay.Height);
            //b.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                ActualizarTiempo();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            running = !running;
            if (running)
            {
                btnPlay.Text = estados[1];
            }
            else
            {
                btnPlay.Text = estados[0];
            }
            Refresh();
        }
    }
}
