namespace DI_T6_E1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSep = new System.Windows.Forms.Button();
            this.txtSeparacion = new DI_T6_E1.lblTxt();
            this.main = new DI_T6_E1.lblTxt();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(61, 49);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Cambia";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSep
            // 
            this.btnSep.Location = new System.Drawing.Point(61, 130);
            this.btnSep.Name = "btnSep";
            this.btnSep.Size = new System.Drawing.Size(75, 23);
            this.btnSep.TabIndex = 3;
            this.btnSep.Text = "Aplicar";
            this.btnSep.UseVisualStyleBackColor = true;
            this.btnSep.Click += new System.EventHandler(this.btnSep_Click);
            // 
            // txtSeparacion
            // 
            this.txtSeparacion.Location = new System.Drawing.Point(12, 95);
            this.txtSeparacion.Name = "txtSeparacion";
            this.txtSeparacion.Posicion = DI_T6_E1.lblTxt.ePosicion.IZQUIERDA;
            this.txtSeparacion.PswChr = false;
            this.txtSeparacion.Separacion = 0;
            this.txtSeparacion.Size = new System.Drawing.Size(161, 20);
            this.txtSeparacion.TabIndex = 2;
            this.txtSeparacion.TextLabel = "Separación";
            this.txtSeparacion.TextTxt = "";
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(12, 12);
            this.main.Name = "main";
            this.main.Posicion = DI_T6_E1.lblTxt.ePosicion.IZQUIERDA;
            this.main.PswChr = false;
            this.main.Separacion = 0;
            this.main.Size = new System.Drawing.Size(131, 20);
            this.main.TabIndex = 4;
            this.main.TextLabel = "dddd";
            this.main.TextTxt = "";
            this.main.TxtChanged += new System.EventHandler(this.lblTxt_TxtChanged);
            this.main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.main_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.btnSep);
            this.Controls.Add(this.txtSeparacion);
            this.Controls.Add(this.btnChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DI_T6_E1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private lblTxt txtSeparacion;
        private System.Windows.Forms.Button btnSep;
        private lblTxt main;
    }
}

