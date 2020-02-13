namespace Principal
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
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.txtSep = new System.Windows.Forms.TextBox();
            this.btnSep = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.labelTextBox1 = new DI_T6_NuevosComponentes.LabelTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(12, 61);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(75, 23);
            this.btn_cambiar.TabIndex = 1;
            this.btn_cambiar.Text = "Cambiar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.Btn_cambiar_Click);
            // 
            // txtSep
            // 
            this.txtSep.Location = new System.Drawing.Point(25, 181);
            this.txtSep.Name = "txtSep";
            this.txtSep.Size = new System.Drawing.Size(100, 20);
            this.txtSep.TabIndex = 2;
            // 
            // btnSep
            // 
            this.btnSep.Location = new System.Drawing.Point(25, 207);
            this.btnSep.Name = "btnSep";
            this.btnSep.Size = new System.Drawing.Size(137, 23);
            this.btnSep.TabIndex = 3;
            this.btnSep.Text = "Cambiar separacion";
            this.btnSep.UseVisualStyleBackColor = true;
            this.btnSep.Click += new System.EventHandler(this.BtnSep_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(127, 61);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(35, 13);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "label1";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox1.Location = new System.Drawing.Point(12, 23);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = DI_T6_NuevosComponentes.LabelTextBox.ePosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separacion = 25;
            this.labelTextBox1.Size = new System.Drawing.Size(138, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "Texto label";
            this.labelTextBox1.TextTxt = "Texto textbox";
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.LabelTextBox1_TxtChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LabelTextBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad Separación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnSep);
            this.Controls.Add(this.txtSep);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DI_T6_NuevosComponentes.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.TextBox txtSep;
        private System.Windows.Forms.Button btnSep;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label1;
    }
}

