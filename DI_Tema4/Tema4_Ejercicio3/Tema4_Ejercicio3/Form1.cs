using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio3
{
    public partial class formulario3 : Form
    {
        String path;
        public formulario3()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop";
            opDialog.Filter = "Image files (*.jpg; *.png)|*.jpg; *png|All files (*.*)|*.*";
            opDialog.RestoreDirectory = true;
            if(opDialog.ShowDialog() == DialogResult.OK)
            {
                Form2 f = new Form2(opDialog.FileName);
                DialogResult res;
                if (chkBoxModal.Checked)
                {
                    res = f.ShowDialog();
                }
                else
                {
                    f.Show();
                }
            }
        }

        private void Formulario3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que quieres salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
