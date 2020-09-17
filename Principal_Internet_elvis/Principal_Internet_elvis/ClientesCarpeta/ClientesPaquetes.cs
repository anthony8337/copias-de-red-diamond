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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Principal_Internet_elvis.ClientesCarpeta
{
    public partial class ClientesPaquetes : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm, cm2;

        public static int idregistro;
        public static string nombre, identificamelo;
        public int idvinculo, idcliente;

        public void eliminar()
        {
            if (MessageBox.Show("Seguro que desea eliminar el siguiente registro seleccionado", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    idcliente = int.Parse(dgv_tabla.CurrentRow.Cells[0].Value.ToString());
                    cm2 = new SqlCommand("SELECT idvinculo FROM ClientePaquete WHERE idcliente = @idclie ", cn);
                    cm2.Parameters.AddWithValue("@idclie", idcliente);
                    identificamelo = cm2.ExecuteScalar().ToString();

                    idvinculo = int.Parse(cm2.ExecuteScalar().ToString());

                    cm = new SqlCommand("DELETE FROM ClientePaquete WHERE idvinculo = @vinculo", cn);
                    cm.Parameters.AddWithValue("@vinculo", idvinculo);
                    cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El registro no tiene paquetes registrados");
                }
            }
        }
    

        public void tabla()
        {
            try
            {
                cm = new SqlCommand("Select * from V_clientepaquete WHERE idcliente = '"+idregistro+"'", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                dgv_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }
        }

            public ClientesPaquetes()
        {
            InitializeComponent();
        }
        
        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Program.paquetesElegir = new PaquetesElegir();
            Program.paquetesElegir.TopMost = true;
            Program.paquetesElegir.BringToFront();
            Program.paquetesElegir.Text = "ELEGIR-PAQUETES";
            Program.paquetesElegir.Show();
            Program.paquetesElegir.Focus();
        }
        
        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void ClientesPaquetes_Load(object sender, EventArgs e)
        {

            cn.Open();
            groupBox1.Text = "PAQUETES REGISTRADOS DE: " + nombre;
            tabla();

            try
            {
                idcliente = int.Parse(dgv_tabla.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este registro no tiene paquetes registrados");
            }
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = int.Parse(dgv_tabla.CurrentRow.Cells[0].Value.ToString());
        }

        private void ClientesPaquetes_Activated(object sender, EventArgs e)
        {
            tabla();
        }

        private void bt_quitar_Click(object sender, EventArgs e)
        {
            eliminar();
            tabla();
        }
    }
}
