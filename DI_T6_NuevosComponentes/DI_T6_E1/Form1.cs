using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T6_E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            switch (lblTxt.Posicion)
            {
                case lblTxt.ePosicion.DERECHA:
                    lblTxt.Posicion = lblTxt.ePosicion.IZQUIERDA;
                    break;
                case lblTxt.ePosicion.IZQUIERDA:
                    lblTxt.Posicion = lblTxt.ePosicion.DERECHA;
                    break;
            }
            lblTxt.recolocar();
            this.Text = lblTxt.Posicion+"";
        }

        private void btnSep_Click(object sender, EventArgs e)
        {
            if (txtSeparacion.TextTxt!="")
            {
                try
                {
                    int valor = Convert.ToInt32(txtSeparacion.TextTxt);
                    lblTxt.Separacion = valor;
                    lblTxt.recolocar();
                }
                catch (OverflowException) { }
                catch (FormatException) { }
            }
        }

        private void lblTxt_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode + "";
        }
        
    }
}
