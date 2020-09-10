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
    public partial class Seleccionar : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        SqlCommand cm;

        public Seleccionar()
        {
            InitializeComponent();
        }

        private void Seleccionar_Load(object sender, EventArgs e)
        {
            cn.Open();
            Clientes.tipo = "Colonia";
            tabla();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "TABLA EN VISTA: COLONIA";
            Clientes.tipo = "Colonia";
            MessageBox.Show(Clientes.tipo);
            tabla();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Clientes.tipo = "Barrio";
            groupBox1.Text = "TABLA EN VISTA: BARRIO";
            tabla();
        }

        public void tabla()
        {
            try
            {
                if (rb_colonia.Checked)
                {
                    cm = new SqlCommand("Select* from V_colonia", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    dgv_tabla.DataSource = tabla;
                }
                else
                {
                    cm = new SqlCommand("Select* from V_barrio", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    dgv_tabla.DataSource = tabla;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }
            for (int i = 0; i < dgv_tabla.Rows.Count; i++)
            {
                if (dgv_tabla.Rows[i].Cells["estado"].Value.ToString().Equals("Activo"))
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dgv_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                dgv_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }


        }
        
        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Clientes.lugar = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Clientes.tipo);
            
            

            if (Clientes.tipo == "Colonia")
            {
                try
                {
                    cm = new SqlCommand("Select idsector from Colonia WHERE colonia = @lugar", cn);
                    cm.Parameters.AddWithValue("@lugar", Clientes.lugar);
                    Clientes.idsector = int.Parse(cm.ExecuteScalar().ToString());
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
            else if (Clientes.tipo == "Barrio")
            {
                try
                {
                    cm = new SqlCommand("Select idsector from Barrio WHERE barrio = @lugar", cn);
                    cm.Parameters.AddWithValue("@lugar", Clientes.lugar);
                    Clientes.idsector = int.Parse(cm.ExecuteScalar().ToString());
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

            
            MessageBox.Show(Clientes.idsector.ToString());
            this.Dispose();
        }
    }
}
