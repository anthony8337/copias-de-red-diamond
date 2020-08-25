using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Paquetes
{
    public partial class PaquetesElegir : Form
    {
        public int id = -1, id_cliente = -1;
        List<int> In = new List<int>();

        public PaquetesElegir()
        {
            InitializeComponent();
        }

        private void PaquetesElegir_Load(object sender, EventArgs e)
        { }

        private void bt_aceptar_Click(object sender, EventArgs e)
        { }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
            int n = dgv_tabla.CurrentRow.Index;

            dgv_tabla.Rows[n].Selected = false;

            dgv_tabla.ClearSelection();

            if (In.Contains(n))
            {
                In.Remove(n);
            }
            else
            {
                In.Add(n);
            }

            foreach (int i in In)
            {
                dgv_tabla.Rows[i].Selected = true;
            }
        }
    }
}
