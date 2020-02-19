namespace programacionII_estadistica
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnCalcularEstandar = new System.Windows.Forms.Button();
            this.btnCalcularTpica = new System.Windows.Forms.Button();
            this.grdEstadistica = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2ixfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblToF1 = new System.Windows.Forms.Label();
            this.lblToX1F1 = new System.Windows.Forms.Label();
            this.lblToX2iF1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEstand = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(12, 30);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "SERIE:";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(60, 27);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(184, 20);
            this.txtserie.TabIndex = 1;
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(22, 109);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(79, 32);
            this.btnMediaAritmetica.TabIndex = 2;
            this.btnMediaAritmetica.Text = "Calcular X";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(19, 75);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "X";
            // 
            // btnCalcularEstandar
            // 
            this.btnCalcularEstandar.Location = new System.Drawing.Point(107, 109);
            this.btnCalcularEstandar.Name = "btnCalcularEstandar";
            this.btnCalcularEstandar.Size = new System.Drawing.Size(105, 32);
            this.btnCalcularEstandar.TabIndex = 4;
            this.btnCalcularEstandar.Text = "Calcular Estandar";
            this.btnCalcularEstandar.UseVisualStyleBackColor = true;
            this.btnCalcularEstandar.Click += new System.EventHandler(this.btnCalcularEstandar_Click);
            // 
            // btnCalcularTpica
            // 
            this.btnCalcularTpica.Location = new System.Drawing.Point(218, 109);
            this.btnCalcularTpica.Name = "btnCalcularTpica";
            this.btnCalcularTpica.Size = new System.Drawing.Size(86, 32);
            this.btnCalcularTpica.TabIndex = 5;
            this.btnCalcularTpica.Text = "Calcular Tipica";
            this.btnCalcularTpica.UseVisualStyleBackColor = true;
            this.btnCalcularTpica.Click += new System.EventHandler(this.btnCalcularTpica_Click);
            // 
            // grdEstadistica
            // 
            this.grdEstadistica.AllowUserToDeleteRows = false;
            this.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.f1,
            this.fi,
            this.xixfi,
            this.x2ixfi});
            this.grdEstadistica.Location = new System.Drawing.Point(21, 180);
            this.grdEstadistica.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grdEstadistica.Name = "grdEstadistica";
            this.grdEstadistica.RowHeadersWidth = 102;
            this.grdEstadistica.RowTemplate.Height = 40;
            this.grdEstadistica.Size = new System.Drawing.Size(494, 278);
            this.grdEstadistica.TabIndex = 6;
            this.grdEstadistica.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdEstadistica_KeyUp);
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.MinimumWidth = 12;
            this.x1.Name = "x1";
            this.x1.Width = 60;
            // 
            // f1
            // 
            this.f1.HeaderText = "F1";
            this.f1.MinimumWidth = 12;
            this.f1.Name = "f1";
            this.f1.Width = 60;
            // 
            // fi
            // 
            this.fi.HeaderText = "Fi";
            this.fi.MinimumWidth = 12;
            this.fi.Name = "fi";
            this.fi.Width = 60;
            // 
            // xixfi
            // 
            this.xixfi.HeaderText = "Xi * Fi";
            this.xixfi.MinimumWidth = 12;
            this.xixfi.Name = "xixfi";
            this.xixfi.Width = 70;
            // 
            // x2ixfi
            // 
            this.x2ixfi.HeaderText = "X2i * Fi";
            this.x2ixfi.MinimumWidth = 12;
            this.x2ixfi.Name = "x2ixfi";
            this.x2ixfi.Width = 70;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(31, 477);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(62, 13);
            this.lblTotales.TabIndex = 7;
            this.lblTotales.Text = "TOTALES: ";
            // 
            // lblToF1
            // 
            this.lblToF1.AutoSize = true;
            this.lblToF1.Location = new System.Drawing.Point(161, 477);
            this.lblToF1.Name = "lblToF1";
            this.lblToF1.Size = new System.Drawing.Size(57, 13);
            this.lblToF1.TabIndex = 8;
            this.lblToF1.Text = "TOTAL F1";
            // 
            // lblToX1F1
            // 
            this.lblToX1F1.AutoSize = true;
            this.lblToX1F1.Location = new System.Drawing.Point(247, 477);
            this.lblToX1F1.Name = "lblToX1F1";
            this.lblToX1F1.Size = new System.Drawing.Size(75, 13);
            this.lblToX1F1.TabIndex = 9;
            this.lblToX1F1.Text = "TOTAL X1xF1";
            // 
            // lblToX2iF1
            // 
            this.lblToX2iF1.AutoSize = true;
            this.lblToX2iF1.Location = new System.Drawing.Point(350, 477);
            this.lblToX2iF1.Name = "lblToX2iF1";
            this.lblToX2iF1.Size = new System.Drawing.Size(78, 13);
            this.lblToX2iF1.TabIndex = 10;
            this.lblToX2iF1.Text = "TOTAL X2IxF1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // lblEstand
            // 
            this.lblEstand.AutoSize = true;
            this.lblEstand.Location = new System.Drawing.Point(152, 518);
            this.lblEstand.Name = "lblEstand";
            this.lblEstand.Size = new System.Drawing.Size(66, 13);
            this.lblEstand.TabIndex = 12;
            this.lblEstand.Text = "ESTANDAR";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(247, 518);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(41, 13);
            this.lblTip.TabIndex = 13;
            this.lblTip.Text = "TIPICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 540);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblEstand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblToX2iF1);
            this.Controls.Add(this.lblToX1F1);
            this.Controls.Add(this.lblToF1);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.grdEstadistica);
            this.Controls.Add(this.btnCalcularTpica);
            this.Controls.Add(this.btnCalcularEstandar);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.btnMediaAritmetica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Calculos basicos Estadistica";
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnCalcularEstandar;
        private System.Windows.Forms.Button btnCalcularTpica;
        private System.Windows.Forms.DataGridView grdEstadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn xixfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2ixfi;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblToF1;
        private System.Windows.Forms.Label lblToX1F1;
        private System.Windows.Forms.Label lblToX2iF1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEstand;
        private System.Windows.Forms.Label lblTip;
    }
}

