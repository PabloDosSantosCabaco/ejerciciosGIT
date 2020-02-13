#define CREDITONEGATIVO
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Ejercicio3 : Form
    {
        int credit = 50;
        public Ejercicio3()
        {
            InitializeComponent();
            lblCredit.Text = credit+"€";
            lblInfo.Text = "Que va a haber premio.";
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (credit < 2)
            {
                return;
            }
            Random number = new Random();
            credit -= 2;
            txtFirst.Text = number.Next(1, 8).ToString();
            txtSecond.Text = number.Next(1, 8).ToString();
            txtThird.Text = number.Next(1, 8).ToString();
            credit += comprobarResultado(int.Parse(txtFirst.Text), int.Parse(txtSecond.Text), int.Parse(txtThird.Text));
            lblCredit.Text = credit + "€";
        }

        public int comprobarResultado(int n1, int n2, int n3)
        {
            if(n1==n2 && n2 == n3)
            {
                return 20;
            }else if(n1==n2 || n1==n3 || n2==n3)
            {
#if CREDITONEGATIVO
                return -5;  
#else
                return 5;
#endif
            }
            else
            {
                return 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            credit += 10;
            lblCredit.Text = credit + "€";
        }
    }
}
// Directiva compilación
// Botón credito
// Comprobación crédito