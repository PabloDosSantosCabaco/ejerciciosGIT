namespace SERV_T3_E4_Client
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnPalabra = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.lblTextos = new System.Windows.Forms.Label();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(105, 267);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(93, 232);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 1;
            // 
            // btnPalabra
            // 
            this.btnPalabra.Location = new System.Drawing.Point(387, 51);
            this.btnPalabra.Name = "btnPalabra";
            this.btnPalabra.Size = new System.Drawing.Size(75, 23);
            this.btnPalabra.TabIndex = 2;
            this.btnPalabra.Text = "Palabra";
            this.btnPalabra.UseVisualStyleBackColor = true;
            this.btnPalabra.Click += new System.EventHandler(this.btnPalabra_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(387, 106);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(75, 23);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // lblTextos
            // 
            this.lblTextos.AutoSize = true;
            this.lblTextos.Location = new System.Drawing.Point(387, 162);
            this.lblTextos.Name = "lblTextos";
            this.lblTextos.Size = new System.Drawing.Size(35, 13);
            this.lblTextos.TabIndex = 4;
            this.lblTextos.Text = "label1";
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.Location = new System.Drawing.Point(347, 366);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(99, 23);
            this.btnNuevoJuego.TabIndex = 5;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = true;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.Location = new System.Drawing.Point(497, 106);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(120, 95);
            this.lstRecords.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.btnNuevoJuego);
            this.Controls.Add(this.lblTextos);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnPalabra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnPalabra;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Label lblTextos;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.ListBox lstRecords;
    }
}

