using Principal_Internet_elvis.Configuraciones;
using Proyecto_Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txt_server.Text == "")
            {
                MessageBox.Show("Llene los campos.");
                return;
            }

            try
            {
                string ruta = Application.StartupPath + "\\config.txt";
                StreamWriter streamWriter = new StreamWriter(ruta);
                streamWriter.WriteLine(txt_server.Text);
                streamWriter.Close();
                Inicio f = new Inicio();
                f.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema al guardar"+ ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {}

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_empresa_Click(object sender, EventArgs e)
        {
            Program.configuracionLogo = new ConfiguracionLogo();
            Program.configuracionLogo.Text = "EMPRESA";
            Program.configuracionLogo.Show();
            Program.configuracionLogo.Focus();
            this.Close();
        }

        public void addFuente(Font f)
        {
            foreach (Button e in Program.GetAllChildren(this).OfType<Button>())
            {
                e.Font = f;
            }

            foreach (GroupBox e in Program.GetAllChildren(this).OfType<GroupBox>())
            {
                e.Font = f;
            }

            foreach (TextBox e in Program.GetAllChildren(this).OfType<TextBox>())
            {
                e.Font = f;
            }

            foreach (DateTimePicker e in Program.GetAllChildren(this).OfType<DateTimePicker>())
            {
                e.Font = f;
            }
        }

        private void bt_provedores_Click(object sender, EventArgs e)
        {
            Program.proveedor = new Proveedor();
            Program.proveedor.Text = "PROVEEDORES";
            Program.proveedor.Show();
            Program.proveedor.Focus();
            this.Close();
        }

        private void bt_socios_Click(object sender, EventArgs e)
        {
            Program.socios = new Socios();
            Program.socios.Text = "PROVEEDORES";
            Program.socios.Show();
            Program.socios.Focus();
            this.Close();
        }

        private void bt_usuarios_Click(object sender, EventArgs e)
        {
            Program.usuarios = new Usuarios();
            Program.usuarios.Text = "USUARIOS";
            Program.usuarios.Show();
            Program.usuarios.Focus();
            this.Close();
        }
    }
}
