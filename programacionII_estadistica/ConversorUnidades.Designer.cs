namespace programacionII_estadistica
{
    partial class ConversorUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorUnidades));
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(126, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(35, 66);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(204, 66);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(35, 141);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(219, 144);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(13, 13);
            this.lblRespuesta.TabIndex = 4;
            this.lblRespuesta.Text = "?";
            // 
            // cboTipo
            // 
            this.cboTipo.AccessibleDescription = "";
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Peso",
            "Volumen",
            "Almacenamiento"});
            this.cboTipo.Location = new System.Drawing.Point(83, 29);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboDe
            // 
            this.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDe.FormattingEnabled = true;
            this.cboDe.Location = new System.Drawing.Point(12, 93);
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(121, 21);
            this.cboDe.TabIndex = 1;
            // 
            // cboA
            // 
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(166, 93);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(121, 21);
            this.cboA.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(104, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConvertir.Location = new System.Drawing.Point(114, 201);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(75, 23);
            this.BtnConvertir.TabIndex = 4;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConversorUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::programacionII_estadistica.Properties.Resources.descargar;
            this.ClientSize = new System.Drawing.Size(306, 252);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.cboDe);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConversorUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Unidades";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}