using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Ubicacion
{
    public partial class UbicacionElegir : Form
    {
        public UbicacionElegir()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            int row = dgv_tabla.CurrentRow.Index;
            int id = 0;
            string nombre = "";

            if (this.Text.Equals("ELEGIR-SECTOR"))
            {
                id = Int32.Parse(dgv_tabla.Rows[row].Cells[0].Value.ToString());
                nombre = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                Program.ubicacionAgregar.agregarDatos(id, nombre);
            }
            else if (this.Text.Equals("ELEGIR-BARRIO"))
            {
                id = Int32.Parse(dgv_tabla.Rows[row].Cells[0].Value.ToString());
                nombre = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                Program.ubicacionAgregar.agregarDatos(id, nombre);
            }
            else if (this.Text.Equals("ELEGIR-LUGAR"))
            {
                id = Int32.Parse(dgv_tabla.Rows[row].Cells["idlugar"].Value.ToString());
                nombre = dgv_tabla.Rows[row].Cells["lugar"].Value.ToString();
                Program.clientes.agregarDatos(id, nombre);
            }
            this.Close();
        }

        private void UbicacionElegir_Load(object sender, EventArgs e)
        {}

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
    }
}
