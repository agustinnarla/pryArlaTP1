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
            this.lblCultivos = new System.Windows.Forms.Label();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivos.Location = new System.Drawing.Point(12, 12);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(57, 17);
            this.lblCultivos.TabIndex = 8;
            this.lblCultivos.Text = "Cultivos";
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(75, 11);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(144, 20);
            this.txtCultivos.TabIndex = 6;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(153, 37);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(66, 23);
            this.cmdCargar.TabIndex = 9;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click_1);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(75, 37);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(66, 23);
            this.cmdBorrar.TabIndex = 10;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 72);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.txtCultivos);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdBorrar;
    }
}