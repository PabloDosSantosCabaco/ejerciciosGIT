namespace T4_E7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirRecientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeSelecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.selecciónDeEscrituraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayus = new System.Windows.Forms.ToolStripMenuItem();
            this.minus = new System.Windows.Forms.ToolStripMenuItem();
            this.normal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iconRecientes = new System.Windows.Forms.ToolStripButton();
            this.iconNew = new System.Windows.Forms.ToolStripButton();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveTS = new System.Windows.Forms.ToolStripButton();
            this.copyTS = new System.Windows.Forms.ToolStripButton();
            this.cutTS = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDocumentoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.abrirRecientes,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoDocumentoToolStripMenuItem
            // 
            this.nuevoDocumentoToolStripMenuItem.Name = "nuevoDocumentoToolStripMenuItem";
            this.nuevoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoDocumentoToolStripMenuItem.Text = "Nuevo";
            this.nuevoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.NuevoDocumentoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // abrirRecientes
            // 
            this.abrirRecientes.Name = "abrirRecientes";
            this.abrirRecientes.Size = new System.Drawing.Size(150, 22);
            this.abrirRecientes.Text = "Abrir recientes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.seleccionarToolStripMenuItem,
            this.informaciónDeSelecciónToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.seleccionarToolStripMenuItem.Text = "Seleccionar todo";
            this.seleccionarToolStripMenuItem.Click += new System.EventHandler(this.seleccionarToolStripMenuItem_Click);
            // 
            // informaciónDeSelecciónToolStripMenuItem
            // 
            this.informaciónDeSelecciónToolStripMenuItem.Name = "informaciónDeSelecciónToolStripMenuItem";
            this.informaciónDeSelecciónToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.informaciónDeSelecciónToolStripMenuItem.Text = "Información de selección";
            this.informaciónDeSelecciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeSelecciónToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajusteDeLinea,
            this.selecciónDeEscrituraToolStripMenuItem,
            this.toolStripMenuItem3,
            this.colorTextoToolStripMenuItem,
            this.colorFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.acercaDeToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ajusteDeLinea
            // 
            this.ajusteDeLinea.Checked = true;
            this.ajusteDeLinea.CheckOnClick = true;
            this.ajusteDeLinea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ajusteDeLinea.Name = "ajusteDeLinea";
            this.ajusteDeLinea.Size = new System.Drawing.Size(188, 22);
            this.ajusteDeLinea.Text = "Ajuste de línea";
            // 
            // selecciónDeEscrituraToolStripMenuItem
            // 
            this.selecciónDeEscrituraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mayus,
            this.minus,
            this.normal});
            this.selecciónDeEscrituraToolStripMenuItem.Name = "selecciónDeEscrituraToolStripMenuItem";
            this.selecciónDeEscrituraToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.selecciónDeEscrituraToolStripMenuItem.Text = "Selección de escritura";
            // 
            // mayus
            // 
            this.mayus.CheckOnClick = true;
            this.mayus.Name = "mayus";
            this.mayus.Size = new System.Drawing.Size(136, 22);
            this.mayus.Text = "Mayúsculas";
            this.mayus.CheckedChanged += new System.EventHandler(this.Mayus_CheckedChanged);
            // 
            // minus
            // 
            this.minus.CheckOnClick = true;
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(136, 22);
            this.minus.Text = "Minúsculas";
            this.minus.CheckedChanged += new System.EventHandler(this.Minus_CheckedChanged);
            // 
            // normal
            // 
            this.normal.CheckOnClick = true;
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(136, 22);
            this.normal.Text = "Normal";
            this.normal.CheckedChanged += new System.EventHandler(this.Normal_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // colorTextoToolStripMenuItem
            // 
            this.colorTextoToolStripMenuItem.Name = "colorTextoToolStripMenuItem";
            this.colorTextoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colorTextoToolStripMenuItem.Text = "Color Texto";
            this.colorTextoToolStripMenuItem.Click += new System.EventHandler(this.colorTextoToolStripMenuItem_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colorFondoToolStripMenuItem.Text = "Color Fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(185, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconRecientes,
            this.iconNew,
            this.saveTS,
            this.copyTS,
            this.cutTS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // iconRecientes
            // 
            this.iconRecientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconRecientes.Image = ((System.Drawing.Image)(resources.GetObject("iconRecientes.Image")));
            this.iconRecientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconRecientes.Name = "iconRecientes";
            this.iconRecientes.Size = new System.Drawing.Size(23, 22);
            this.iconRecientes.Text = "toolStripButton1";
            this.iconRecientes.ToolTipText = "Archivos Recientes";
            this.iconRecientes.Click += new System.EventHandler(this.iconRecientes_Click);
            // 
            // iconNew
            // 
            this.iconNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconNew.Image = ((System.Drawing.Image)(resources.GetObject("iconNew.Image")));
            this.iconNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconNew.Name = "iconNew";
            this.iconNew.Size = new System.Drawing.Size(23, 22);
            this.iconNew.Text = "toolStripButton2";
            this.iconNew.ToolTipText = "Nuevo Documento";
            this.iconNew.Click += new System.EventHandler(this.IconNew_Click);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 49);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(800, 401);
            this.txtContent.TabIndex = 3;
            this.txtContent.TextChanged += new System.EventHandler(this.TxtContent_TextChanged);
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            this.txtContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtContent_MouseDown);
            this.txtContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtContent_MouseMove);
            this.txtContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtContent_MouseUp);
            // 
            // saveTS
            // 
            this.saveTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTS.Image = ((System.Drawing.Image)(resources.GetObject("saveTS.Image")));
            this.saveTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTS.Name = "saveTS";
            this.saveTS.Size = new System.Drawing.Size(23, 22);
            this.saveTS.Text = "toolStripButton1";
            this.saveTS.Click += new System.EventHandler(this.saveTS_Click);
            // 
            // copyTS
            // 
            this.copyTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyTS.Image = ((System.Drawing.Image)(resources.GetObject("copyTS.Image")));
            this.copyTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyTS.Name = "copyTS";
            this.copyTS.Size = new System.Drawing.Size(23, 22);
            this.copyTS.Text = "toolStripButton2";
            this.copyTS.Click += new System.EventHandler(this.copyTS_Click);
            // 
            // cutTS
            // 
            this.cutTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutTS.Image = ((System.Drawing.Image)(resources.GetObject("cutTS.Image")));
            this.cutTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutTS.Name = "cutTS";
            this.cutTS.Size = new System.Drawing.Size(23, 22);
            this.cutTS.Text = "toolStripButton3";
            this.cutTS.Click += new System.EventHandler(this.cutTS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton iconRecientes;
        private System.Windows.Forms.ToolStripButton iconNew;
        private System.Windows.Forms.ToolStripMenuItem abrirRecientes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeSelecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeLinea;
        private System.Windows.Forms.ToolStripMenuItem selecciónDeEscrituraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayus;
        private System.Windows.Forms.ToolStripMenuItem minus;
        private System.Windows.Forms.ToolStripMenuItem normal;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton saveTS;
        private System.Windows.Forms.ToolStripButton copyTS;
        private System.Windows.Forms.ToolStripButton cutTS;
    }
}

