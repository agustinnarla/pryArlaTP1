namespace pry1Arla
{
    partial class frmCultivos
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
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblCultivos = new System.Windows.Forms.Label();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.lblIngresosCultivos = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cmdConsutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(8, 43);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(90, 17);
            this.lblIdentificacion.TabIndex = 9;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivos.Location = new System.Drawing.Point(8, 84);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(57, 17);
            this.lblCultivos.TabIndex = 8;
            this.lblCultivos.Text = "Cultivos";
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(104, 81);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(144, 20);
            this.txtCultivos.TabIndex = 6;
            // 
            // lblIngresosCultivos
            // 
            this.lblIngresosCultivos.AutoSize = true;
            this.lblIngresosCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosCultivos.Location = new System.Drawing.Point(61, 9);
            this.lblIngresosCultivos.Name = "lblIngresosCultivos";
            this.lblIngresosCultivos.Size = new System.Drawing.Size(123, 17);
            this.lblIngresosCultivos.TabIndex = 5;
            this.lblIngresosCultivos.Text = "Ingeso de Cultivos";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(144, 120);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(87, 40);
            this.cmdCargar.TabIndex = 10;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(104, 40);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(144, 20);
            this.txtIdentificacion.TabIndex = 11;
            // 
            // cmdConsutar
            // 
            this.cmdConsutar.Location = new System.Drawing.Point(21, 120);
            this.cmdConsutar.Name = "cmdConsutar";
            this.cmdConsutar.Size = new System.Drawing.Size(87, 40);
            this.cmdConsutar.TabIndex = 12;
            this.cmdConsutar.Text = "Consultar Identificador";
            this.cmdConsutar.UseVisualStyleBackColor = true;
            this.cmdConsutar.Click += new System.EventHandler(this.cmdConsutar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 172);
            this.Controls.Add(this.cmdConsutar);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.lblIngresosCultivos);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Label lblIngresosCultivos;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button cmdConsutar;
    }
}