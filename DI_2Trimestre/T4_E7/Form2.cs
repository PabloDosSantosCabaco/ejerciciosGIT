using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4_E7
{
    public partial class Form2 : Form
    {
        Form1 f = new Form1();
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }
        public void actualizar(int inicio,int longitud,string seleccion)
        {
            lblInfo.Text = ($"Inicio: {inicio}{Environment.NewLine}Longitud: {longitud}{Environment.NewLine}Selección: {seleccion}"); 
        }

        private void btnAply_Click(object sender, EventArgs e)
        {
            try
            {
                int inicio = Convert.ToInt32(txtInicio.Text);
                int longitud = Convert.ToInt32(txtLongitud.Text);
                f.changeSelection(inicio, longitud);
            }
            catch (OverflowException) { }
            catch (FormatException) { }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.noModalAbierto = false;
        }
    }
}
