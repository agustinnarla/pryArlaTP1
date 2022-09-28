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
           
            string varToneladas = txtToneladas.Text;
            
            if (varToneladas != "")
            {
                
                StreamWriter swToneladas = new StreamWriter("./Toneladas.txt", true);
                swToneladas.WriteLine(lstLocalidad.Text + "," + lstCultivos.Text + "," + txtToneladas.Text);
                lstCultivos.Text = "";
                lstLocalidad.Text = "";
                txtToneladas.Text = "";
                MessageBox.Show("Carga realizada");
                swToneladas.Close();
            }
            else
            {
                
              MessageBox.Show("Complete con los datos, por favor ");
                
            }
            


        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //cargamos a las listas con datos de los archivos 

            char separador = Convert.ToChar(",");
            if (File.Exists("./Localidades.txt"))
            {
            
                StreamReader srLocalidades = new StreamReader("./Localidades.txt");

                while (!srLocalidades.EndOfStream)
                {
                    string[] vecLocalidad = srLocalidades.ReadLine().Split(separador);
                    lstLocalidad.Items.Add(vecLocalidad[0]);
                }

                srLocalidades.Close();

            }
            if (File.Exists("./Cultivos.txt"))
            {
                StreamReader srCultivos = new StreamReader("./Cultivos.txt");

                while (!srCultivos.EndOfStream)
                {
                    string[] vecCultivo = srCultivos.ReadLine().Split(separador);
                    lstCultivos.Items.Add(vecCultivo[0]);
                }
                srCultivos.Close();
            }

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Borrar archivo 
            File.Delete("./Toneladas.txt");
            MessageBox.Show("Archivo Eliminado");
        }

        private void txtToneladas_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtToneladas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
