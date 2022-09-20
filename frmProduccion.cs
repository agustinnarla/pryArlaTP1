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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string varLocalidades = lstLocalidad.Text;
            string varCultivos = lstCultivos.Text;
            string varToneladas = txtToneladas.Text;
            cmdCargar.Enabled = false;

            StreamWriter toneladas = new StreamWriter("./Toneladas.txt", true);
            toneladas.WriteLine(lstCultivos.Text + "  " + lstLocalidad.Text + "  " + txtToneladas.Text);
            txtToneladas.Text = "";
            MessageBox.Show("Carga realizada");
            toneladas.Close();

            if (varLocalidades == "" && varCultivos == "" && varToneladas == "")
            {
                cmdCargar.Enabled = false; 
            }
            if (varLocalidades != "" && varCultivos != "" && varToneladas != "")
            {
                cmdCargar.Enabled = true;
            }
            

        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");

            StreamReader localidades = new StreamReader("./Localidades.txt");
            
            while (!localidades.EndOfStream)
            {
                string[] matLocalidad = localidades.ReadLine().Split(separador);
                lstLocalidad.Items.Add(matLocalidad[3]);
            }

            localidades.Close();

            StreamReader cultivos = new StreamReader("./Cultivos.txt");

            while (!cultivos.EndOfStream)
            {
                string[] matcultivo = cultivos.ReadLine().Split(separador);
                lstLocalidad.Items.Add(matcultivo[3]);
            }
            cultivos.Close();


        }
    }
}
