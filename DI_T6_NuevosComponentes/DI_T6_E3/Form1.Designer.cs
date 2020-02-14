namespace DI_T6_E3
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtTime = new DI_T6_E3.TiempoReproductor();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(388, 372);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "button1";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(317, 52);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(106, 13);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "tiempoReproductor1";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(356, 191);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(35, 13);
            this.lblImg.TabIndex = 2;
            this.lblImg.Text = "label1";
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(231, 372);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(132, 23);
            this.btnDir.TabIndex = 3;
            this.btnDir.Text = "Seleccionar Directorio";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiempoReproductor txtTime;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Button btnDir;
    }
}

