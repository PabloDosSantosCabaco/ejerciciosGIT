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
            this.components = new System.ComponentModel.Container();
            this.btnDir = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.reproductor1 = new DI_T6_E3.Reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(314, 387);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(132, 23);
            this.btnDir.TabIndex = 3;
            this.btnDir.Text = "Seleccionar Directorio";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // pctBox
            // 
            this.pctBox.Location = new System.Drawing.Point(129, 37);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(499, 289);
            this.pctBox.TabIndex = 5;
            this.pctBox.TabStop = false;
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(346, 345);
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Size = new System.Drawing.Size(75, 36);
            this.reproductor1.TabIndex = 4;
            this.reproductor1.DesbordaTiempo += new System.EventHandler(this.reproductor1_DesbordaTiempo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.reproductor1);
            this.Controls.Add(this.btnDir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Timer temporizador;
        private Reproductor reproductor1;
        private System.Windows.Forms.PictureBox pctBox;
    }
}

