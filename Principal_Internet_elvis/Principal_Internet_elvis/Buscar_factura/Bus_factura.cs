using Principal_Internet_elvis.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Bus_factura : Form
    {
        private int row = -1;

        public Bus_factura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Bus_factura_Load(object sender, EventArgs e)
        {
            addFuente(Program.principal.fuente);
        }

        private void buscar()
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            if(row == -1)
            {
                MessageBox.Show("Seleccione un factura.");
                return;
            }
            mostrarFactura(int.Parse(dgv_tabla.Rows[row].Cells["idfactura"].Value.ToString()));
        }

        private void mostrarFactura(int id)
        { }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                row = dgv_tabla.CurrentRow.Index;
            }
        }
    }
}
