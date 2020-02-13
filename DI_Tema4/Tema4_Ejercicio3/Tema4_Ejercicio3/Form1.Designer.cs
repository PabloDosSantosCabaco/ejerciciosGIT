namespace Tema4_Ejercicio3
{
    partial class formulario3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario3));
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkBoxModal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(89, 67);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Imagen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // chkBoxModal
            // 
            this.chkBoxModal.AutoSize = true;
            this.chkBoxModal.Location = new System.Drawing.Point(183, 71);
            this.chkBoxModal.Name = "chkBoxModal";
            this.chkBoxModal.Size = new System.Drawing.Size(55, 17);
            this.chkBoxModal.TabIndex = 1;
            this.chkBoxModal.Text = "Modal";
            this.chkBoxModal.UseVisualStyleBackColor = true;
            // 
            // formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 169);
            this.Controls.Add(this.chkBoxModal);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formulario3";
            this.Text = "Visor de imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulario3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox chkBoxModal;
    }
}

