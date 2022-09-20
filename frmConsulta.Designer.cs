namespace pry1Arla
{
    partial class frmConsulta
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
            this.grlConsulta = new System.Windows.Forms.DataGridView();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toneladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grlConsulta
            // 
            this.grlConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Localidad,
            this.Cultivo,
            this.Toneladas});
            this.grlConsulta.Location = new System.Drawing.Point(3, 12);
            this.grlConsulta.Name = "grlConsulta";
            this.grlConsulta.Size = new System.Drawing.Size(433, 207);
            this.grlConsulta.TabIndex = 0;
            this.grlConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 150;
            // 
            // Cultivo
            // 
            this.Cultivo.HeaderText = "Cultivo";
            this.Cultivo.Name = "Cultivo";
            this.Cultivo.ReadOnly = true;
            // 
            // Toneladas
            // 
            this.Toneladas.HeaderText = "Tonelada";
            this.Toneladas.Name = "Toneladas";
            this.Toneladas.ReadOnly = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(328, 225);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(108, 29);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlConsulta);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.grlConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toneladas;
        private System.Windows.Forms.Button cmdConsultar;
    }
}