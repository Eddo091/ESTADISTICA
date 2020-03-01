namespace programacionII_estadistica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversoresToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.conversoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFormularioActivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::programacionII_estadistica.Properties.Resources.Salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticaToolStripMenuItem,
            this.conversoresToolStripMenuItem,
            this.conversoresToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.estadisticaToolStripMenuItem.Image = global::programacionII_estadistica.Properties.Resources.Estadistica;
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            this.estadisticaToolStripMenuItem.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // conversoresToolStripMenuItem
            // 
            this.conversoresToolStripMenuItem.Name = "conversoresToolStripMenuItem";
            this.conversoresToolStripMenuItem.Size = new System.Drawing.Size(174, 6);
            // 
            // conversoresToolStripMenuItem1
            // 
            this.conversoresToolStripMenuItem1.Image = global::programacionII_estadistica.Properties.Resources.Conversor;
            this.conversoresToolStripMenuItem1.Name = "conversoresToolStripMenuItem1";
            this.conversoresToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.conversoresToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.conversoresToolStripMenuItem1.Text = "Conversores";
            this.conversoresToolStripMenuItem1.Click += new System.EventHandler(this.conversoresToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::programacionII_estadistica.Properties.Resources.Estadistica;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Estadistica";
            this.toolStripButton1.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::programacionII_estadistica.Properties.Resources.Conversor;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Conversores";
            this.toolStripButton2.Click += new System.EventHandler(this.conversoresToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusFecha,
            this.lblFormularioActivo,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusFecha
            // 
            this.lblStatusFecha.Name = "lblStatusFecha";
            this.lblStatusFecha.Size = new System.Drawing.Size(118, 17);
            this.lblStatusFecha.Text = "toolStripStatusLabel1";
            // 
            // lblFormularioActivo
            // 
            this.lblFormularioActivo.Name = "lblFormularioActivo";
            this.lblFormularioActivo.Size = new System.Drawing.Size(136, 17);
            this.lblFormularioActivo.Text = "Nombre de la aplicacion";
            this.lblFormularioActivo.Click += new System.EventHandler(this.lblFormularioActivo_Click);
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(118, 17);
            this.lblHora.Text = "toolStripStatusLabel1";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator conversoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblFormularioActivo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
    }
}