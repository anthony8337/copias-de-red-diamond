using Principal_Internet_elvis.Paquetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.ClientesCarpeta
{
    public partial class ClientesPaquetes : Form
    {
        

        public ClientesPaquetes()
        {
            InitializeComponent();
        }

        private void ClientesPaquetes_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        { }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Program.paquetesElegir = new PaquetesElegir();
            Program.paquetesElegir.TopMost = true;
            Program.paquetesElegir.BringToFront();
            Program.paquetesElegir.Text = "ELEGIR-PAQUETES";
            Program.paquetesElegir.Show();
            Program.paquetesElegir.Focus();
        }

        private void bt_quitar_Click(object sender, EventArgs e)
        { }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
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

            foreach (DataGridView e in Program.GetAllChildren(this).OfType<DataGridView>())
            {
                e.Font = f;
            }
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
