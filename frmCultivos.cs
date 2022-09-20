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

        private void cmdCargar_Click(object sender, EventArgs e)
        {
         
            StreamWriter cultivos = new StreamWriter("./Cultivos.txt", true);
            StreamReader repetidor = new StreamReader("./Cultivos.txt");
            bool bandera = false;

            while (repetidor.EndOfStream)
            {
                if (txtIdentificacion.Text == repetidor.ReadLine())
                {
                    MessageBox.Show("Este codigo ya se cargo, por favor ingrese otro");
                    bandera = true;
                    txtIdentificacion.Text = "";
                }
            }

            if (bandera == true)
            {
                MessageBox.Show("Numero no utilizado");
            }

            cultivos.WriteLine(txtIdentificacion.Text+ "  " + txtCultivos.Text); 
            cultivos.Close();
            txtCultivos.Text = "";
            txtIdentificacion.Text = "";
            txtCultivos.Focus();
        }

        private void cmdConsutar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
