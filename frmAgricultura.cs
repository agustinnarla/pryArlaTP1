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
    public partial class frmAgricultura : Form
    {
        Datos[] vecDatos = new Datos[23];
        public struct Datos
        {
            public string Localidades;
            public string Cultivos;
        }
        public frmAgricultura()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void producionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmProduccion = new frmProduccion();
            frmProduccion.ShowDialog();
           
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLocalidad = new frmLocalidad();
            frmLocalidad.ShowDialog();
            
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCultivos = new frmCultivos();
            frmCultivos.ShowDialog();
                
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultaLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsulta = new frmConsulta();
            frmConsulta.ShowDialog();
        }
    }
}
