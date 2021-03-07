using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sabado1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario = txtusuario.Text.TrimEnd();

            contraseña = txtcontraseña.Text.TrimEnd();


            if (usuario=="UWU"&&contraseña=="Hola")

            {
                MessageBox.Show("Hola bienvenido uwu");


            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
}
