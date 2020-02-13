using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a=MessageBox.Show("¿Quieres camiar el título a "+inputText.Text+"?", "Ventana", MessageBoxButtons.YesNo);
            switch (a)
            {
                case DialogResult.Yes:
                    this.Text = inputText.Text;
                    break;
            }
        }
    }
}
