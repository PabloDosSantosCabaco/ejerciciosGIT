namespace SERV_T3_E2_Client
{
    partial class Chat
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.chatEnter1 = new SERV_T3_E2_Client.chatEnter();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChat.Location = new System.Drawing.Point(0, 0);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.Size = new System.Drawing.Size(800, 450);
            this.txtChat.TabIndex = 1;
            // 
            // chatEnter1
            // 
            this.chatEnter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatEnter1.Location = new System.Drawing.Point(0, 426);
            this.chatEnter1.Name = "chatEnter1";
            this.chatEnter1.Size = new System.Drawing.Size(800, 24);
            this.chatEnter1.TabIndex = 2;
            this.chatEnter1.TextTxt = "";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chatEnter1);
            this.Controls.Add(this.txtChat);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChat;
        private chatEnter chatEnter1;
    }
}

