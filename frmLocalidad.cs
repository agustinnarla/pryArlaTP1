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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pry1Arla
{
    public partial class frmLocalidad : Form
    {
      

        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {

            string varLocalidades = lstLocalidades.Text;
            int varIdentificador = 1;

            if (varLocalidades != "")
            {
                if (File.Exists("./Localidades.txt"))
                {
                    char separador = Convert.ToChar(",");
                    StreamReader srLocalidades = new StreamReader("./Localidaes.txt");
                    while (!srLocalidades.EndOfStream)
                    {
                        string[] vecLocalidades = srLocalidades.ReadLine().Split(separador);
                        int vecId = Convert.ToInt32(vecLocalidades[1]);
                        varIdentificador = vecId + 1;

                    }
                    srLocalidades.Close();
                }
                StreamWriter swLocalidades = new StreamWriter("./Localidades.txt", true);
                swLocalidades.WriteLine(varLocalidades + "," + varIdentificador);
                MessageBox.Show("Carga Realizada");
                lstLocalidades.Text = "";
                lstLocalidades.Focus();
                swLocalidades.Close();
            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");
            }

        }

        private void lstLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {


         



        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
