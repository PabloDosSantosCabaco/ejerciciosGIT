using DI_T6_NuevosComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_cambiar_Click(object sender, EventArgs e)
        {
            if (this.labelTextBox1.Posicion.Equals(LabelTextBox.ePosicion.DERECHA))
            {
                this.labelTextBox1.Posicion = LabelTextBox.ePosicion.IZQUIERDA;
            }
            else
            {
                this.labelTextBox1.Posicion = LabelTextBox.ePosicion.DERECHA;
            }
            this.Text = this.labelTextBox1.Posicion+"";
        }

        private void BtnSep_Click(object sender, EventArgs e)
        {
            if (txtSep.Text.Length != 0)
            {
                try
                {
                    labelTextBox1.Separacion = Convert.ToInt32(txtSep.Text);
                }
                catch (FormatException){}
                catch (OverflowException) { }
                catch (InvalidCastException) { }
            }
        }

        private void LabelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode + "";
        }

        private void LabelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            lblChange.Text = labelTextBox1.TextTxt;
        }
    }
}
