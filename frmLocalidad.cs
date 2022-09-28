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

            //Si no esta vacio que entre 
            if (varLocalidades != "")
            {
                //Comprobar si el archivo ya esta creado
                if (File.Exists("./Localidades.txt"))
                {
                    char separador = Convert.ToChar(",");
                    //Lectura
                    StreamReader srLocalidades = new StreamReader("./Localidades.txt");
                    
                    while (!srLocalidades.EndOfStream)
                    {
                        //Creacion de identificador automatico
                        string[] vecLocalidades = srLocalidades.ReadLine().Split(separador);
                        int vecId = Convert.ToInt32(vecLocalidades[1]);
                        varIdentificador = vecId + 1;

                    }
                    srLocalidades.Close();
                }
                //Evitar que se sobrescriban los archivos 
                StreamWriter swLocalidades = File.AppendText("./Localidades.txt");
                swLocalidades.WriteLine(varLocalidades + "," + varIdentificador);
                MessageBox.Show("Carga Realizada");
                lstLocalidades.SelectedIndex = -1;
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

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Borrar archivo 
            File.Delete("./Localidades.txt");
            MessageBox.Show("Archivo Eliminado");
        }
    }
}
