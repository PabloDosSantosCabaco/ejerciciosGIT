using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T6_E5
{
    public partial class ValidateTextBox : UserControl
    {
        public string texto;
        public bool multilinea;
        public bool correcto = false;
        public enum eTipo
        {
            numerico,
            textual
        }
        public eTipo tipo = eTipo.numerico;
        public eTipo Tipo
        {
            set
            {
                if (Enum.IsDefined(typeof(eTipo), value))
                {
                    tipo = value;
                }
            }
            get
            {
                return tipo;
            }
        }
        public string Texto
        {
            set
            {
                texto = value;
                txtBox.Text = texto;
            }
            get
            {
                return texto;
            }
        }
        public bool Multilinea
        {
            set
            {
                multilinea = value;
            }
            get
            {
                return multilinea;
            }
        }
        public ValidateTextBox()
        {
            InitializeComponent();
            txtBox.Location = new Point(10, 10);
            this.Size = new Size(txtBox.Width + 20, txtBox.Height + 20);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (correcto)
            {
                SolidBrush b = new SolidBrush(Color.Green);
            }
            else
            {
                SolidBrush b = new SolidBrush(Color.Red);
            }
            g.DrawString(this.Text, this.Font, b, 0, 0);
        }

        private void ValidateTextBox_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(txtBox.Width+20,txtBox.Height+20);
        }
    }
}
