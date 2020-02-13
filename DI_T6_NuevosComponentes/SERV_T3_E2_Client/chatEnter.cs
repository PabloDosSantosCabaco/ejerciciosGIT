using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERV_T3_E2_Client
{
    public partial class chatEnter : UserControl
    {
        public chatEnter()
        {
            InitializeComponent();
            recolocar();
        }
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }
        private void recolocar()
        {
            txt.Location = new Point(0, 0);
            txt.Width = this.Width - btn.Width;
            btn.Location = new Point(txt.Width, 0);
            this.Height = Math.Max(txt.Height, btn.Height);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            recolocar();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
