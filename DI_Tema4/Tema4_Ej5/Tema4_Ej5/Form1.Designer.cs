namespace Tema4_Ej5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.txtToAdd = new System.Windows.Forms.TextBox();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.lblSelectedIndex = new System.Windows.Forms.Label();
            this.lblTxtError = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(222, 94);
            this.lst1.Name = "lst1";
            this.lst1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst1.Size = new System.Drawing.Size(187, 290);
            this.lst1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lst1, "Lista de elementos");
            this.lst1.SelectedValueChanged += new System.EventHandler(this.Lst1_SelectedValueChanged);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(589, 81);
            this.lst2.Name = "lst2";
            this.lst2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst2.Size = new System.Drawing.Size(187, 290);
            this.lst2.TabIndex = 1;
            this.lst2.MouseHover += new System.EventHandler(this.Lst2_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(440, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btnAdd, "Añade un elemento a la lista 1");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(440, 151);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 35);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btnDel, "Elimina elementos seleccionados");
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(440, 211);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(110, 35);
            this.btnToRight.TabIndex = 4;
            this.btnToRight.Text = "--->";
            this.toolTip1.SetToolTip(this.btnToRight, "Traspasa elementos");
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.BtnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(440, 269);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(110, 35);
            this.btnToLeft.TabIndex = 5;
            this.btnToLeft.Text = "<---";
            this.toolTip1.SetToolTip(this.btnToLeft, "Traspasa elementos");
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.BtnToLeft_Click);
            // 
            // txtToAdd
            // 
            this.txtToAdd.Location = new System.Drawing.Point(222, 60);
            this.txtToAdd.Name = "txtToAdd";
            this.txtToAdd.Size = new System.Drawing.Size(170, 20);
            this.txtToAdd.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtToAdd, "Elemento a introducir");
            // 
            // lblSelectedCount
            // 
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Location = new System.Drawing.Point(25, 94);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new System.Drawing.Size(163, 13);
            this.lblSelectedCount.TabIndex = 7;
            this.lblSelectedCount.Text = "No hay elementos seleccionados";
            // 
            // lblSelectedIndex
            // 
            this.lblSelectedIndex.AutoSize = true;
            this.lblSelectedIndex.Location = new System.Drawing.Point(25, 134);
            this.lblSelectedIndex.Name = "lblSelectedIndex";
            this.lblSelectedIndex.Size = new System.Drawing.Size(163, 13);
            this.lblSelectedIndex.TabIndex = 8;
            this.lblSelectedIndex.Text = "No hay elementos seleccionados";
            // 
            // lblTxtError
            // 
            this.lblTxtError.AutoSize = true;
            this.lblTxtError.ForeColor = System.Drawing.Color.Red;
            this.lblTxtError.Location = new System.Drawing.Point(398, 67);
            this.lblTxtError.Name = "lblTxtError";
            this.lblTxtError.Size = new System.Drawing.Size(0, 13);
            this.lblTxtError.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // temporizador
            // 
            this.temporizador.Interval = 200;
            this.temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTxtError);
            this.Controls.Add(this.lblSelectedIndex);
            this.Controls.Add(this.lblSelectedCount);
            this.Controls.Add(this.txtToAdd);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.TextBox txtToAdd;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label lblSelectedIndex;
        private System.Windows.Forms.Label lblTxtError;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

