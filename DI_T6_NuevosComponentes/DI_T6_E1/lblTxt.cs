using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T6_E1
{
    public partial class lblTxt : UserControl  //Eventos y passwordchar
    {
        public enum ePosicion
        {
            DERECHA,
            IZQUIERDA
        }
        private ePosicion posicion = ePosicion.DERECHA;
        private int separacion = 0;
        private bool pswChr;
        public event System.EventHandler TxtChanged;
        public lblTxt()
        {
            InitializeComponent();
            txt.Text = "";
            lbl.Text = "Etiqueta";
            pswChr = false;
            recolocar();
        }

        [Category("Nuevos")]
        [Description("Indicia la separación que existe entre la etiqueta y la caja de texto.")]
        public int Separacion
        {
            get
            {
                return separacion;
            }
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        [Category("Nuevos")]
        [Description("Establece si la contraseña se verá o no.")]
        public bool PswChr
        {
            get
            {
                return pswChr;
            }
            set
            {
                pswChr = value;
            }
        }
        [Category ("Nuevos")]
        [Description ("Indica la posición en la que se coloca la etiqueta respecto de la caja de texto.")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }
        [Category ("Nuevos")]
        [Description ("Obtiene y modifica el valor del texto de la etiqueta.")]
        public string TextLabel
        {
            get
            {
                return lbl.Text;
            }
            set
            {
                lbl.Text = value;
            }
        }
        [Category ("Nuevos")]
        [Description ("Obtiene y modifica el valor del texto de la caja de texto.")]
        public string TextTxt
        {
            get
            {
                return txt.Text;
            }
            set
            {
                txt.Text = value;
            }
        }
        public void recolocar()
        {
            this.Width = lbl.Width + txt.Width + Separacion;
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    this.Height = Math.Max(lbl.Height, txt.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    lbl.Width = this.Width - txt.Width - Separacion;
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    this.Height = Math.Max(lbl.Height, txt.Height);
                    break;
            }
        }

        private void lbl_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (pswChr)
            {
                txt.PasswordChar = '*';
            }
            TxtChanged(sender, e);
        }
    }
}
