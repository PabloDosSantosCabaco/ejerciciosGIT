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

namespace Archivos_3
{
    public partial class Form1 : Form
    {
        string ruta = "";
        Color colorTexto;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetEnvironmentVariable("userprofile")+"\\color.pds"))
            {
                using (BinaryReader br = new BinaryReader(new FileStream(Environment.GetEnvironmentVariable("userprofile") + "\\color.pds", FileMode.Open)))
                {
                    colorTexto = Color.FromArgb(br.ReadByte(), br.ReadByte(), br.ReadByte());
                    ruta = br.ReadString();
                    using (StreamReader fs = new StreamReader(ruta))
                    {
                        txtInfo.Text = fs.ReadToEnd();
                        txtInfo.ForeColor = colorTexto;
                    }
                }
            }
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
                    MessageBoxIcon.Question))
                {

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
            saveConfig();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!txtInfo.Text.Equals(""))
            {
                switch (MessageBox.Show("Desea guardar el contenido actual?",
                    "Save?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question))
                {

                    case DialogResult.Yes:
                        guardar();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE");
                ofd.Title = "Abrir archivo";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
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
                        using(StreamWriter sw = new StreamWriter(ruta))
                        {
                            sw.WriteLine(txtInfo.Text);
                        }
                        saveConfig();
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

        private void Form1_SizeChanged_1(object sender, EventArgs e)
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.R && e.Control)
            {
                using (ColorDialog cd = new ColorDialog())
                {

                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        colorTexto = cd.Color;
                        saveConfig();
                        txtInfo.ForeColor = colorTexto;
                    }
                }
            }
        }
        public void saveConfig()
        {
            try
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream(Environment.GetEnvironmentVariable("userprofile") + "\\color.pds",
                    FileMode.OpenOrCreate)))
                {
                    bw.Write(colorTexto.R);
                    bw.Write(colorTexto.G);
                    bw.Write(colorTexto.B);
                    bw.Write(ruta);
                }
            }
            catch (ArgumentNullException)// NO
            {
            }
        }

    }
}
