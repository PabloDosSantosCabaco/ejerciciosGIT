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
        public enum eTipo
        {
            Numerico,
            Textual
        }
        private eTipo tipo = eTipo.Numerico;
        [Category("Otros")]
        [Description("Accede al tipo de dato que contiene la caja de texto.")]
        public eTipo Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
                this.Refresh();
            }
        }
        [Category("Otros")]
        [Description("Texto interno de la caja de texto.")]
        public string Texto
        {
            get
            {
                return txt.Text;
            }
            set
            {
                txt.Text = value;
                this.Refresh();
            }
        }
        [Category("Otros")]
        [Description("Opción multilínea de la caja de texto.")]
        public bool Multilinea
        {
            get
            {
                return txt.Multiline;
            }
            set
            {
                txt.Multiline = value;
                this.Refresh();
            }
        }
        private Color colorBorde = Color.Red;
        [Category("Otros")]
        [Description("Se lanza cuando cambia el texto de la caja de texto.")]
        public event System.EventHandler EventoTextChanged;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            pintarBorde(g, colorBorde);
        }
        public ValidateTextBox()
        {
            InitializeComponent();
            txt.Location = new Point(10, 10);
            this.Height = txt.Height + 20;
            txt.Width = this.Width - 20;
            this.Refresh();
        }

        private void ValidateTextBox_SizeChanged(object sender, EventArgs e)
        {
            this.Height = txt.Height + 20;
            txt.Width = this.Width - 20;
        }
        public void pintarBorde(Graphics e, Color color)
        {
            SolidBrush b = new SolidBrush(color);
            e.DrawRectangle(new Pen(b), 5, 5, this.Width - 10, this.Height - 10);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            EventoTextChanged?.Invoke(this, EventArgs.Empty);
            switch (Tipo)
            {
                case eTipo.Numerico:
                    try
                    {
                        Convert.ToInt32(txt.Text);
                        colorBorde = Color.Green;
                    }
                    catch (FormatException ex)
                    {
                        colorBorde = Color.Red;
                    }
                    catch (OverflowException ex)
                    {
                        colorBorde = Color.Green;
                    }
                    break;
                case eTipo.Textual:
                    Color aux = Color.Green;
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        if (txt.Text[i] == ' ' || ((char)txt.Text[i] >= 65 && (char)txt.Text[i] <= 90) || ((char)txt.Text[i] >= 97 && (char)txt.Text[i] <= 122))
                        {

                        }
                        else
                        {
                            aux = Color.Red;
                        }
                    }
                    colorBorde = aux;
                    break;
            }
            this.Refresh();
        }
    }
}
