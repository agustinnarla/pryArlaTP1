using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry1Arla
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Toneladas.txt"))
            {
                char separador = Convert.ToChar(",");
                StreamReader srConsultaTotal = new StreamReader("./Toneladas.txt");
                while (!srConsultaTotal.EndOfStream)
                {
                    string[] vecConsultaCliente = srConsultaTotal.ReadLine().Split(separador);
                     grlConsulta.Rows.Add(vecConsultaCliente);
                    cmdConsultar.Enabled = false;

                }
                srConsultaTotal.Close();
            }
            else
            {
                MessageBox.Show("Porfavor, primero registre los datos.");
            }
        }
    }
}
