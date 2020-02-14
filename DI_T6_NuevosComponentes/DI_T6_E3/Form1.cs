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

namespace DI_T6_E3
{
    public partial class Form1 : Form
    {
        private string[] estados = { "Play", "Pause" };
        private bool play = false;
        private int sec = 0;
        private int min = 0;
        private List<string> imagenes = new List<string>();
        public Form1()
        {
            InitializeComponent();
            btnPlay.Text = estados[0];
        }
        public void refreshTime()
        {
            sec++;
            if (sec > 59)
            {
                DesbordaTiempo();
            }
        }
        public void DesbordaTiempo()
        {
            sec = 0;
            min++;
            if (min > 99)
            {
                min = 0;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(!play)
            {
                btnPlay.Text = estados[1];
            }
            else
            {
                btnPlay.Text = estados[0];
            }
            play = !play;
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(DialogResult.OK == fbd.ShowDialog())
                {
                    string dir = fbd.SelectedPath;
                    DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                    //di.GetFiles()
                }
            }
        }
    }
}
