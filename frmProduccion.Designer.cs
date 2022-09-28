namespace pry1Arla
{
    partial class frmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.lblCultivos = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblIngresoToneladas = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivos = new System.Windows.Forms.ComboBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivos.Location = new System.Drawing.Point(18, 74);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(57, 17);
            this.lblCultivos.TabIndex = 9;
            this.lblCultivos.Text = "Cultivos";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(18, 38);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 17);
            this.lblLocalidad.TabIndex = 8;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblIngresoToneladas
            // 
            this.lblIngresoToneladas.AutoSize = true;
            this.lblIngresoToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoToneladas.Location = new System.Drawing.Point(53, 6);
            this.lblIngresoToneladas.Name = "lblIngresoToneladas";
            this.lblIngresoToneladas.Size = new System.Drawing.Size(146, 17);
            this.lblIngresoToneladas.TabIndex = 5;
            this.lblIngresoToneladas.Text = "Ingreso de Toneladas";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladas.Location = new System.Drawing.Point(18, 112);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(75, 17);
            this.lblToneladas.TabIndex = 10;
            this.lblToneladas.Text = "Toneladas";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(104, 38);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(143, 21);
            this.lstLocalidad.TabIndex = 11;
            // 
            // lstCultivos
            // 
            this.lstCultivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivos.FormattingEnabled = true;
            this.lstCultivos.Location = new System.Drawing.Point(104, 75);
            this.lstCultivos.Name = "lstCultivos";
            this.lstCultivos.Size = new System.Drawing.Size(143, 21);
            this.lstCultivos.TabIndex = 12;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(104, 111);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(143, 20);
            this.txtToneladas.TabIndex = 13;
            this.txtToneladas.TextChanged += new System.EventHandler(this.txtToneladas_TextChanged);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(190, 137);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(60, 23);
            this.cmdCargar.TabIndex = 14;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(104, 137);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(60, 23);
            this.cmdBorrar.TabIndex = 15;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 166);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.lstCultivos);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblIngresoToneladas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblIngresoToneladas;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivos;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdBorrar;
    }
}