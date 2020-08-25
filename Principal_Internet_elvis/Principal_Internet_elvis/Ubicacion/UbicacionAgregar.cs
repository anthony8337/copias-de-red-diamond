using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Principal_Internet_elvis.Ubicacion
{
    public partial class UbicacionAgregar : Form
    {
        private int id2;
        private int row = -1, estado = -1;

        public UbicacionAgregar()
        {
            InitializeComponent();
        }

        private void UbicacionAgregar_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        { }

        public void agregarDatos(int id, string nombre)
        {
            id2 = id;
            txt_codigo2.Text = nombre;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            botonAceptar();
        }

        private void bt_codigo2_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("AGREGAR-BARRIO") || this.Text.Equals("MODIFICAR-BARRIO"))
            {
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Text = "ELEGIR-SECTOR";
                Program.ubicacionElegir.Show();
                Program.ubicacionElegir.Focus();
            }
            else if (this.Text.Equals("AGREGAR-LUGAR") || this.Text.Equals("MODIFICAR-LUGAR"))
            {
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Text = "ELEGIR-BARRIO";
                Program.ubicacionElegir.Show();
                Program.ubicacionElegir.Focus();
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                botonAceptar();
            }
        }

        private void botonAceptar()
        { }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && Text.Contains("MODIFICAR") || 
                selectedRowCount > 0 && Text.Contains("ESTADO"))
            {
                row = dgv_tabla.CurrentRow.Index;
                seleccionar();
            }
        }

        private void seleccionar()
        {
            if (this.Text.Contains("SECTOR"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_nombre.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                estado = int.Parse(dgv_tabla.Rows[row].Cells[2].Value.ToString());
            }
            else if (this.Text.Contains("BARRIO"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_codigo2.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                txt_nombre.Text = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                id2 = int.Parse(dgv_tabla.Rows[row].Cells[1].Value.ToString());
                estado = int.Parse(dgv_tabla.Rows[row].Cells[3].Value.ToString());
            }
            else if (this.Text.Contains("LUGAR"))
            {
                txt_codigo.Text = dgv_tabla.Rows[row].Cells[0].Value.ToString();
                txt_codigo2.Text = dgv_tabla.Rows[row].Cells[1].Value.ToString();
                txt_nombre.Text = dgv_tabla.Rows[row].Cells[2].Value.ToString();
                id2 = int.Parse(dgv_tabla.Rows[row].Cells[1].Value.ToString());
                estado = int.Parse(dgv_tabla.Rows[row].Cells[3].Value.ToString());
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

            foreach (DataGridView e in Program.GetAllChildren(this).OfType<DataGridView>())
            {
                e.Font = f;
            }
        }
    }
}
