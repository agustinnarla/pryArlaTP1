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
            StreamReader consulta = new StreamReader("./toneladas.txt");
            char separador = Convert.ToChar(",");

            while (!consulta.EndOfStream)
            {
                string[] matProductos = consulta.ReadLine().Split(separador);
                string localidad = matProductos[0];
                string cultivos = matProductos[1];  
                string toneladas = matProductos[2];

            }
            consulta.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
