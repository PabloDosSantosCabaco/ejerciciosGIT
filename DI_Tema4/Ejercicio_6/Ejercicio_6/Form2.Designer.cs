namespace Ejercicio_6
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnPIN = new System.Windows.Forms.Button();
            this.lblPIN = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(67, 54);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(75, 20);
            this.txtPIN.TabIndex = 0;
            // 
            // btnPIN
            // 
            this.btnPIN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPIN.Location = new System.Drawing.Point(67, 92);
            this.btnPIN.Name = "btnPIN";
            this.btnPIN.Size = new System.Drawing.Size(75, 23);
            this.btnPIN.TabIndex = 1;
            this.btnPIN.Text = "Accept";
            this.btnPIN.UseVisualStyleBackColor = true;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Location = new System.Drawing.Point(74, 25);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(54, 13);
            this.lblPIN.TabIndex = 2;
            this.lblPIN.Text = "Insert PIN";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(48, 129);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnPIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 166);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.btnPIN);
            this.Controls.Add(this.txtPIN);
            this.Name = "Form2";
            this.Text = "Insertar PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPIN;
        private System.Windows.Forms.Label lblPIN;
        public System.Windows.Forms.TextBox txtPIN;
        public System.Windows.Forms.Label lblError;
    }
}