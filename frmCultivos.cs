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
using System.Reflection;

namespace pry1Arla
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

       

        private void cmdConsutar_Click(object sender, EventArgs e)
        {
             
        }

        private void cmdCargar_Click_1(object sender, EventArgs e)
        {
            string varCultivos = txtCultivos.Text;
            int varIdentificador = 1;

            //Si no esta vacio que entre 
            if (varCultivos != "")
            {
                //Comprobar si el archivo ya esta creado
                if (File.Exists("./Cultivos.txt"))
                {
                    char separador = Convert.ToChar(",");
                    //Lectura
                    StreamReader srCultivos = new StreamReader("./Cultivos.txt");

                    while (!srCultivos.EndOfStream)
                    {
                        //Creacion de identificador automatico
                        string[] vecCultivos = srCultivos.ReadLine().Split(separador);
                        int vecId = Convert.ToInt32(vecCultivos[1]);
                        varIdentificador = vecId + 1;

                    }
                    srCultivos.Close();
                }
                //Evitar que se sobrescriban los archivos 
                StreamWriter swCultivos = File.AppendText("./Cultivos.txt");
                swCultivos.WriteLine(varCultivos + "," + varIdentificador);
                MessageBox.Show("Carga Realizada");
                txtCultivos.Text = "";
                txtCultivos.Focus();
                swCultivos.Close();
            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");
            }

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //Borrar archivo 
            File.Delete("./Cultivos.txt");
            MessageBox.Show("Archivo Eliminado");
        }
    }
}
