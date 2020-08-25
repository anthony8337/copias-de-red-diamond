using Principal_Internet_elvis.ClientesCarpeta;
using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Ubicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.FormmGenerales
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            addFuente(Program.principal.fuente);
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-AGREGAR";
                Program.ubicacionTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-AGREGAR";
                Program.paquetesTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                
                Program.clientes = new Clientes();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-AGREGAR";
                Program.clientes.Show();
                this.Close();
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-BUSCAR";
                Program.ubicacionTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-BUSCAR";
                Program.paquetesTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Program.clientes = new Clientes();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-BUSCAR";
                Program.clientes.Show();
                this.Close();
            }
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-MODIFICAR";
                Program.ubicacionTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-MODIFICAR";
                Program.paquetesTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Clientes c = new Clientes();
                Program.clientes = new Clientes();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-MODIFICAR";
                Program.clientes.Show();
                this.Close();
            }
        }

        private void bt_estado_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("UBICACION"))
            {
                Program.ubicacionTipo = new UbicacionTipo();
                Program.ubicacionTipo.TopMost = true;
                Program.ubicacionTipo.Focus();
                Program.ubicacionTipo.BringToFront();
                Program.ubicacionTipo.Text = "UBICACION-ESTADO";
                Program.ubicacionTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("PAQUETES"))
            {
                Program.paquetesTipo = new PaquetesTipo();
                Program.paquetesTipo.TopMost = true;
                Program.paquetesTipo.Focus();
                Program.paquetesTipo.BringToFront();
                Program.paquetesTipo.Text = "PAQUETES-ESTADO";
                Program.paquetesTipo.Show();
                this.Close();
            }
            else if (this.Text.Equals("CLIENTES"))
            {
                Program.clientes = new Clientes();
                Program.clientes.TopMost = true;
                Program.clientes.Focus();
                Program.clientes.BringToFront();
                Program.clientes.Text = "CLIENTE-ESTADO";
                Program.clientes.Show();
                this.Close();
            }
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
    }
}
