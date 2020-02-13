using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4_E7
{
    public partial class Form1 : Form
    {
        Form2 f2;
        bool fileSaved = false;
        List<string> recientes = new List<string>();
        Color textColor = Color.Black;
        Font fuente;
        String escritura = "";
        public Form1()
        {
            InitializeComponent();
            fuente = new Font(this.Font, FontStyle.Regular);
            leerArchivoRecientes();
            toolTip1.SetToolTip(txtContent, "Lineas: " + lanes_number() + "\nPalabras: " + words_number()+"\nCharacters: "+characters_number());
            
        }
        public void newDocument()
        {
            if (fileSaved)
            {
                txtContent.Clear();
            }else if (txtContent.Text.Length > 0 && !fileSaved)
            {
                switch(MessageBox.Show("¿Quieres guardar el documento?",
                    "Guardar archivo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        saveFile();
                        txtContent.Clear();
                        break;
                    case DialogResult.No:
                        txtContent.Clear();
                        break;
                }
            }
        }
        public void saveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine(txtContent.Text);
                    fileSaved = true;
                    recientes.Add(sfd.FileName);
                    refreshRecents();
                }
            }
        }
        public void refreshRecents()
        {
            if (recientes.Count > 5)
            {
                recientes.RemoveAt(0);
            }
            if (recientes.Count >= 0)
            {
                abrirRecientes.DropDownItems.Clear();
                foreach (string item in recientes)
                {
                    ToolStripItem subItem = new ToolStripMenuItem(item);
                    abrirRecientes.DropDownItems.Add(subItem);
                }
            }
        }
        public void openFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    txtContent.Text = sr.ReadToEnd();
                    fileSaved = true;
                }
            }
        }
        public void openFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                txtContent.Text = sr.ReadToEnd();
                fileSaved = true;
            }
        }

        public int lanes_number()
        {
            return txtContent.Text.Split(new[] {'\n' }).Length;
        }
        public int words_number()
        {
            return txtContent.Text.Trim().Split(null).Length-1;
        }
        public int characters_number()
        {
            return txtContent.Text.Length;
        }

        private void NuevoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDocument();
        }
        private void IconNew_Click(object sender, EventArgs e)
        {
            newDocument();
        }
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        private void TxtContent_TextChanged(object sender, EventArgs e)
        {
            fileSaved = false;
            refreshSize();
            if (ajusteDeLinea.Checked)
            {

            }
            toolTip1.SetToolTip(txtContent, "Lineas: " + lanes_number() + "\nPalabras: " + words_number() + "\nCharacters: " + characters_number());
            
        }
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtContent.Text.Length > 0 && !fileSaved)
            {
                switch (MessageBox.Show("¿Quieres guardar el documento?",
                    "Guardar archivo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        saveFile();
                        txtContent.Clear();
                        break;
                    case DialogResult.No:
                        txtContent.Clear();
                        break;
                }
            }
            grabarArchivoRecientes();
            if (MessageBox.Show("¿Seguro que desea salir?",
                "Confirmación salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void grabarArchivoRecientes()
        {
            using (BinaryWriter sw = new BinaryWriter(new FileStream(Environment.GetEnvironmentVariable("APPDATA") + "\\recientes",FileMode.OpenOrCreate)))
            {
                sw.Write(recientes.Count);  //Numero de archivos recientes
                foreach (string item in recientes)
                {
                    sw.Write(item);
                }
                sw.Write(txtContent.ForeColor.ToArgb());
                sw.Write(txtContent.BackColor.ToArgb());
                sw.Write(this.Font.Name);
                sw.Write(this.Font.Size);
                sw.Write(Convert.ToInt32(this.Font.Style));
                sw.Write(mayus.Checked);
                sw.Write(minus.Checked);
                sw.Write(normal.Checked);
                sw.Write(ajusteDeLinea.Checked);
            }
        }
        public void leerArchivoRecientes()
        {
            try
            {
                using (BinaryReader sw = new BinaryReader(new FileStream(Environment.GetEnvironmentVariable("APPDATA") + "\\recientes",FileMode.Open)))
                {
                    int recientesSize = sw.ReadInt32(); //Numero de archivos recientes
                    for(int i=0; i<recientesSize; i++)
                    {
                        recientes.Add(sw.ReadString());
                    }
                    if (recientesSize > 0)
                    {
                        using (StreamReader sr = new StreamReader(recientes[recientesSize-1]))
                        {
                            txtContent.Text = sr.ReadToEnd();
                        }
                    }
                    txtContent.ForeColor = Color.FromArgb(sw.ReadInt32());
                    txtContent.BackColor = Color.FromArgb(sw.ReadInt32());
                    fuente = new Font(sw.ReadString(), sw.ReadInt32(),(FontStyle)sw.ReadInt32());
                    mayus.Checked = sw.ReadBoolean();
                    minus.Checked = sw.ReadBoolean();
                    normal.Checked = sw.ReadBoolean();
                    ajusteDeLinea.Checked = sw.ReadBoolean();
                }
            }
            catch (FileNotFoundException)
            {

            }
            if (recientes.Count > 0)
            {
                foreach (string item in recientes)
                {
                    ToolStripItem subItem = new ToolStripMenuItem(item);
                    abrirRecientes.DropDownItems.Add(subItem);
                    subItem.Click += new System.EventHandler(this.abrirArchivoRecientes);
                }
            }
        }
        private void abrirArchivoRecientes(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(sender.ToString()))
            {
                txtContent.Text = sr.ReadToEnd();
                fileSaved = true;
            }
        }
        public void refreshSize()
        {
            if (mayus.Checked)
            {
                txtContent.Text = txtContent.Text.ToUpper();
                escritura = "Mayus";
            }
            if (minus.Checked)
            {
                txtContent.Text = txtContent.Text.ToLower();
                escritura = "Minus";
            }
            if (normal.Checked){
                escritura = "";
            }
            txtContent.SelectionStart = txtContent.Text.Length;
            txtContent.SelectionLength = 0;
        }

        private void Mayus_CheckedChanged(object sender, EventArgs e)
        {
            if (mayus.Checked)
            {
                minus.Checked = false;
                normal.Checked = false;
            }else if (!minus.Checked)
            {
                normal.Checked = true;
            }
            refreshSize();
        }
        private void Minus_CheckedChanged(object sender, EventArgs e)
        {
            if (minus.Checked)
            {
                mayus.Checked = false;
                normal.Checked = false;
            }
            else if (!mayus.Checked)
            {
                normal.Checked = true;
            }
            refreshSize();
        }
        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
            if (normal.Checked)
            {
                minus.Checked = false;
                mayus.Checked = false;
            }
            else if (!minus.Checked && !mayus.Checked)
            {
                normal.Checked = true;
            }
            refreshSize();
        }
        public bool noModalAbierto = false;
        private void modalInfo(Form1 f)
        {
            f2 = new Form2(this);
            f2.Show();
            f2.actualizar(txtContent.SelectionStart, txtContent.SelectionLength,txtContent.SelectedText);
            noModalAbierto = true;
        }

        private void informaciónDeSelecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalInfo(this);
        }

        public void changeSelection(int inicio, int longitud)
        {
            txtContent.SelectionStart = inicio;
            txtContent.SelectionLength = longitud;
        }
        private void txtContent_MouseUp(object sender, MouseEventArgs e)
        {
            if (!noModalAbierto) return;
            f2.actualizar(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText);
        }
        private void txtContent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!noModalAbierto) return;
                f2.actualizar(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText);
            }
        }
        private void txtContent_MouseMove(object sender, MouseEventArgs e)
        {
            if (!noModalAbierto) return;
            f2.actualizar(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText);
        }
        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.SelectAll();
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Undo();
        }
        private void colorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarColor(true);
        }
        public void cambiarColor(bool texto)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textColor = colorDialog.Color;
            }
            if (texto)
            {
                txtContent.ForeColor = textColor;
            }
            else
            {
                txtContent.BackColor = textColor;
            }
        }
        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarColor(false);
        }
        public void cambiarFuente()
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fuente = fontDialog.Font;
            }
            txtContent.Font = fuente;
            
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarFuente();
        }

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                {
                    if (!noModalAbierto) return;
                    f2.actualizar(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText);
                }

        }

        private void iconRecientes_Click(object sender, EventArgs e)
        {
            openFile(recientes[1]);
        }

        private void saveTS_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void copyTS_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void cutTS_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }
    }
}
