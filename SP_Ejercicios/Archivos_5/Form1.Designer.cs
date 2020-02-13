namespace Archivos_5
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
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblErrorDir = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblCad = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(90, 46);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(179, 20);
            this.txtDir.TabIndex = 0;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(90, 98);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(179, 239);
            this.txtInfo.TabIndex = 1;
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(90, 72);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(100, 20);
            this.txtCad.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(144, 354);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Buscar";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblErrorDir
            // 
            this.lblErrorDir.AutoSize = true;
            this.lblErrorDir.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorDir.Location = new System.Drawing.Point(300, 49);
            this.lblErrorDir.Name = "lblErrorDir";
            this.lblErrorDir.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDir.TabIndex = 4;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(22, 46);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 5;
            this.lblDir.Text = "Directorio";
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Location = new System.Drawing.Point(22, 72);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(43, 13);
            this.lblCad.TabIndex = 6;
            this.lblCad.Text = "Palabra";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 98);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Ocurrencias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCad);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblErrorDir);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtDir);
            this.Name = "Form1";
            this.Text = "Archivos 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblErrorDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.Label lblInfo;
    }
}

