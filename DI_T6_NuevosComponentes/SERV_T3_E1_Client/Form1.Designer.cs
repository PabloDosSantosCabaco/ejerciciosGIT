namespace SERV_T3_E1_Client
{
    partial class Cliente
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnFechaHora = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(19, 138);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Disconnected";
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(22, 25);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 1;
            this.btnFecha.Text = "FECHA";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(142, 25);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(75, 23);
            this.btnHora.TabIndex = 2;
            this.btnHora.Text = "HORA";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnFechaHora
            // 
            this.btnFechaHora.Location = new System.Drawing.Point(22, 81);
            this.btnFechaHora.Name = "btnFechaHora";
            this.btnFechaHora.Size = new System.Drawing.Size(75, 23);
            this.btnFechaHora.TabIndex = 3;
            this.btnFechaHora.Text = "TODO";
            this.btnFechaHora.UseVisualStyleBackColor = true;
            this.btnFechaHora.Click += new System.EventHandler(this.btnFechaHora_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(142, 81);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "APAGAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 233);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFechaHora);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.lblInfo);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnFechaHora;
        private System.Windows.Forms.Button btnCerrar;
    }
}

