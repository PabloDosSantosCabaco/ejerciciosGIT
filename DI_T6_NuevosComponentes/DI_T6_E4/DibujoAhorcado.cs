using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_T6_E4
{
    public partial class DibujoAhorcado : Component
    {
        public int errores = 0;
        event System.EventHandler CambiaError;
        event System.EventHandler Ahorcado;
        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        public DibujoAhorcado(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
         
    }
}
