using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos_2
{
    public partial class Form1 : Form
    {
        string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInfo.Location = new System.Drawing.Point(0, 0);
            txtInfo.Size = this.ClientSize;
            txtInfo.Height -= btnGuardar.Height;

            btnNuevo.Location = new System.Drawing.Point(0, txtInfo.Height);
            btnNuevo.Width = txtInfo.Width / 3;
            btnAbrir.Location = new System.Drawing.Point(btnNuevo.Width, txtInfo.Height);
            btnAbrir.Width = btnNuevo.Width;
            btnGuardar.Location = new System.Drawing.Point(btnNuevo.Width*2, txtInfo.Height);
            btnGuardar.Width = btnNuevo.Width;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            txtInfo.Location = new System.Drawing.Point(0, 0);
            txtInfo.Size = this.ClientSize;
            txtInfo.Height -= btnGuardar.Height;

            btnNuevo.Location = new System.Drawing.Point(0, txtInfo.Height);
            btnNuevo.Width = txtInfo.Width / 3;
            btnAbrir.Location = new System.Drawing.Point(btnNuevo.Width, txtInfo.Height);
            btnAbrir.Width = btnNuevo.Width;
            btnGuardar.Location = new System.Drawing.Point(btnNuevo.Width * 2, txtInfo.Height);
            btnGuardar.Width = btnNuevo.Width;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!txtInfo.Text.Equals(""))
            {
                switch (MessageBox.Show("Desea guardar el contenido actual?",
                    "Save?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question)){

                    case DialogResult.Yes:
                        if (guardar())
                        {
                            txtInfo.Clear();
                            ruta = "";
                        }
                        break;
                    case DialogResult.No:
                        txtInfo.Clear();
                        ruta = "";
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!txtInfo.Text.Equals(""))
            {
                if (MessageBox.Show("Desea guardar el contenido actual?",
                    "Save?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    guardar();
                }
            }
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE");
                ofd.Title = "Abrir archivo";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamReader sr = new StreamReader(ofd.FileName)) {
                        txtInfo.Text = sr.ReadToEnd();
                    }
                }
            }
        }
        public bool guardar()
        {
            if (ruta.Equals(""))
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Title = "Escoja destino";
                    sfd.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE");

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(sfd.FileName, "Directorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        ruta = sfd.FileName;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.Write(txtInfo.Text);
            }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
