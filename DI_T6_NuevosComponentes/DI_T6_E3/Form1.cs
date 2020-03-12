using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T6_E3
{
    public partial class Form1 : Form
    {
        private static readonly object l = new object();
        private List<string> imagenes = new List<string>();
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(DialogResult.OK == fbd.ShowDialog())
                {
                    try
                    {
                        string dir = fbd.SelectedPath;
                        DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                        imagenes.Clear();
                        for (int i = 0; i < di.GetFiles().Length; i++)
                        {
                            if (di.GetFiles()[i].Extension == ".png" || di.GetFiles()[i].Extension == ".jpg")
                            {
                                imagenes.Add(di.GetFiles()[i].FullName);
                            }
                        }
                    }catch(Exception ex) { }
                }
            }
        }

        private void reproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductor1.XX++;
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (reproductor1.running)
            {
                reproductor1.YY++;
                if (imagenes.Count > 0)
                {
                    bool imagenMostrada = false;
                    while (!imagenMostrada)
                    {
                        try
                        {
                            pctBox.Image = System.Drawing.Image.FromFile(imagenes[cont]);
                            imagenMostrada = true;
                        }
                        catch (Exception ex)
                        {

                        }
                        cont++;
                        if (cont >= imagenes.Count)
                        {
                            cont = 0;
                        }
                    }
                    
                }
            }
        }
    }
}
