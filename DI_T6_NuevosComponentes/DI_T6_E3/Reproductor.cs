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
        int xx = 0;
        [Category("Otros")]
        [Description("Representa los minutos del reproductor.")]
        public int XX
        {
            get
            {
                return xx;
            }
            set
            {
                if (this.xx > 99)
                {
                    this.xx = 0;
                }
                else
                {
                    this.xx = value;
                }
                lblTime.Text = String.Format("{0,2:D2}:{1,2:D2}", XX, YY);
                this.Refresh();
            }
        }
        int yy = 0;
        [Category("Otros")]
        [Description("Representa los segundos del reproductor.")]
        public int YY
        {
            get
            {
                return yy;
            }
            set
            {
                if (this.yy > 59)
                {
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                    this.yy = this.yy%60;
                }
                else
                {
                    this.yy = value;
                }
                lblTime.Text = String.Format("{0,2:D2}:{1,2:D2}", XX, YY);
                this.Refresh();
            }
        }
        string[] estados = { "Play", "Pause" };
        public bool running = false;
        public event System.EventHandler DesbordaTiempo;
        public event System.EventHandler Pulsacion;
        public Reproductor()
        {
            InitializeComponent();
            btnPlay.Text = estados[0];
            lblTime.Text = String.Format("{0,2:D2}:{1,2:D2}", XX, YY);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            this.Size = new Size(Math.Max(lblTime.Width,btnPlay.Width), lblTime.Height+btnPlay.Height);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Pulsacion?.Invoke(this, EventArgs.Empty);
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
