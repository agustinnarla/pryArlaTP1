namespace pry1Arla
{
    partial class frmLocalidad
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
            this.lblIngresaLocalidad = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lstLocalidades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIngresaLocalidad
            // 
            this.lblIngresaLocalidad.AutoSize = true;
            this.lblIngresaLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaLocalidad.Location = new System.Drawing.Point(52, 9);
            this.lblIngresaLocalidad.Name = "lblIngresaLocalidad";
            this.lblIngresaLocalidad.Size = new System.Drawing.Size(135, 17);
            this.lblIngresaLocalidad.TabIndex = 0;
            this.lblIngresaLocalidad.Text = "Ingresa la Localidad";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(5, 48);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 17);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(145, 71);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(100, 23);
            this.cmdCargar.TabIndex = 5;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lstLocalidades
            // 
            this.lstLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidades.FormattingEnabled = true;
            this.lstLocalidades.Items.AddRange(new object[] {
            "Buenos Aires",
            "Ciudad Autónoma de Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
            "Tucumán"});
            this.lstLocalidades.Location = new System.Drawing.Point(100, 44);
            this.lstLocalidades.Name = "lstLocalidades";
            this.lstLocalidades.Size = new System.Drawing.Size(145, 21);
            this.lstLocalidades.TabIndex = 6;
            this.lstLocalidades.SelectedIndexChanged += new System.EventHandler(this.lstLocalidades_SelectedIndexChanged);
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 103);
            this.Controls.Add(this.lstLocalidades);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblIngresaLocalidad);
            this.Name = "frmLocalidad";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.frmLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresaLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.ComboBox lstLocalidades;
    }
}