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
    public partial class Form2 : Form
    {
        String path;
        public Form2(String path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pBox.Image = new Bitmap(path);
            pBox.Width = new Bitmap(path).Width;
            pBox.Height = new Bitmap(path).Height;
            this.ClientSize = pBox.Size;
            this.Text = path.Substring(path.LastIndexOf("\\")+1);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            pBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox.Height = this.ClientSize.Height;
            pBox.Width = this.ClientSize.Width;
        }
    }
}
