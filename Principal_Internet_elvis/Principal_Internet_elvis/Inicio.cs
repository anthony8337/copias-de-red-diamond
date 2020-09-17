using Principal_Internet_elvis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Internet
{
    
    public partial class Inicio : Form
    {

        
        
        public Inicio()
        {
            InitializeComponent();  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saber_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender.Equals(txtUsuario))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtContra.Select();

                }
            }
            else if (sender.Equals(txtContra))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnEntrar_Click(null, null);
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string tecnico = "admin";
            string clave = "1234";


            if (txtContra.Text == clave && txtUsuario.Text == tecnico)
            {

                MessageBox.Show("Bienvenido "+tecnico);

                Program.principal.Enabled = true;
                Program.principal.tabla();

                this.Dispose();

            }
            else
            {
                MessageBox.Show("El usuario o contraseña no son correctos \nPor favor, intentalo de nuevo");
                txtUsuario.Select();
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Configuracion f = new Configuracion();
            f.Show();
            Visible = false;
        }


    }
}
