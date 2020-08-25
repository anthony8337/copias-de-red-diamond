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

namespace Principal_Internet_elvis.Reportes
{
    public partial class ReportesTipo : Form
    {
        public ReportesTipo()
        {
            InitializeComponent();
        }

        private void bt_mora_buscar_Click(object sender, EventArgs e)
        {
            mostrarMora();
        }

        private void mostrarMora()
        { }

        private void mostrarEstado()
        { }

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

        private void ReportesTipo_Load(object sender, EventArgs e)
        {
            gb_estado_buscar.Visible = false;
            gb_estado.Visible = true;
            addFuente(Program.principal.fuente);
        }

        private void bt_estado_atras_Click(object sender, EventArgs e)
        {
            gb_estado_buscar.Visible = false;
            gb_estado.Visible = true;
        }

        private void bt_estado_buscar_Click(object sender, EventArgs e)
        {
            gb_estado_buscar.Visible = true;
            gb_estado.Visible = false;
            txt_estado_buscar.Select();
        }

        private void bt_estado_imprimir_Click(object sender, EventArgs e)
        {
            if (txt_estado_codigo.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            mostrarEstado();
        }

        private void dgv_estado_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_estado_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_estado_tabla.CurrentRow.Index;
                int c = int.Parse(dgv_estado_tabla.Rows[row].Cells["idcliente"].Value.ToString());
                txt_estado_codigo.Text = c.ToString("D10");
                txt_estado_nombre.Text = dgv_estado_tabla.Rows[row].Cells["nombre"].Value.ToString();

                gb_estado_buscar.Visible = false;
                gb_estado.Visible = true;
                dgv_estado_tabla.DataSource = null;
                txt_estado_buscar.Text = "";
            }
        }

        private void txt_estado_buscar_KeyDown(object sender, KeyEventArgs e)
        { }
    }
}
