using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Principal_Internet_elvis.Pagos
{
    public partial class Sele_Cliente : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public void tabla_clientes()
        {
            try
            {
                cm = new SqlCommand("SELECT nombre FROM V_clientes_imprime WHERE nombre LIKE '%"+textBox1.Text+"%'", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }

        }

        public Sele_Cliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;
            tabla_clientes();
        }

        private void txt_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Sele_Cliente_Load(object sender, EventArgs e)
        {
            tabla_clientes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Reportes.ReportesTipo.nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Dispose();
        }
    }
}
