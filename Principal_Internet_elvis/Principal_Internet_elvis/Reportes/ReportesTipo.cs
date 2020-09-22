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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Principal_Internet_elvis.Reportes
{
    public partial class ReportesTipo : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public static string nombre;

        public void tabla_clientes()
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM V_clientes_imprime", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                vgb_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }

        }

        public void tabla_factura()
        {
            if (nombre != "" && cb_rango.Checked == false)
            {
                try
                {
                    cm = new SqlCommand("SELECT * FROM V_factura WHERE nombre LIKE '%" + txt_cliente.Text + "%'", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    vgb_tabla.DataSource = tabla;
                }
                catch (Exception ex)
                { }
            }
            else if (nombre == "" && cb_rango.Checked == false)
            {
                try
                {
                    cm = new SqlCommand("SELECT * FROM V_factura", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    vgb_tabla.DataSource = tabla;
                }
                catch (Exception ex)
                { }
            }
            else if (nombre == "" && cb_rango.Checked == true)
            {
                try
                {
                    cm = new SqlCommand("SELECT * FROM V_factura WHERE nombre LIKE '%" + txt_cliente.Text + "%' AND fecha BETWEEN '" + dtp_desde.Value.ToShortDateString() + "' AND '" + dtp_hasta.Value.ToShortDateString() + "'", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    vgb_tabla.DataSource = tabla;
                }
                catch (Exception ex)
                { }
            } else if (nombre != "" && cb_rango.Checked == true)
            {
                try
                {
                    cm = new SqlCommand("SELECT * FROM V_factura WHERE fecha BETWEEN '" + dtp_desde.Value.ToShortDateString() + "' AND '" + dtp_hasta.Value.ToShortDateString() + "'", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    vgb_tabla.DataSource = tabla;
                }
                catch (Exception ex)
                { }
            }

            

        }

        public void tabla_servicios()
        {

            try
            {
                cm = new SqlCommand("Select * from Servicio", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                vgb_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }


        }

        public void tabla_paquetes()
        {
            try
            {
                cm = new SqlCommand("Select * from Paquete", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                vgb_tabla.DataSource = tabla;

                
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }
        }

        public void tablaColonia()
        {

            try
            {
                cm = new SqlCommand("Select * from V_colonia", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                vgb_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }

        }

        public void tablaBarrio()
        {

            try
            {
                cm = new SqlCommand("Select * from V_barrio", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                vgb_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }

        }

        public void tablaSector()
        {

            try
            {
                cm = new SqlCommand("Select * from Sector", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                vgb_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }

        }


        public ReportesTipo()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            vgb_tabla.Columns.Clear();
            rb_barrio.Checked = true;
            r_cli_a.Checked = true;
            txt_cliente.Text = "";
            cb_rango.Checked = false;
            rb_servicio.Checked = true;
            txt_nombre_sector.Text = "";
            nombre = "";
            
        }

        private void ReportesTipo_Resize(object sender, EventArgs e)
        {
            vgb_tabla.Left = this.Width - (vgb_tabla.Width + 25);
            vgb_tabla.Top = this.Height - (vgb_tabla.Height + 50);
        }

        private void ReportesTipo_Load(object sender, EventArgs e)
        {
            d_h.Enabled = false;
        }

        private void btn_restableser_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_rango_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rango.Checked == true)
            {
                d_h.Enabled = true;
            }
            else
            {
                d_h.Enabled = false;
            }
        }

        private void btn_b_c_Click(object sender, EventArgs e)
        {
            vgb_tabla.Columns.Clear();
            tabla_clientes();
        }

        private void btn_f_c_Click(object sender, EventArgs e)
        {
            vgb_tabla.Columns.Clear();
            tabla_factura();
        }

        private void btn_ver_paquete_Click(object sender, EventArgs e)
        {
            if (rb_servicio.Checked == true)
            {
                vgb_tabla.Columns.Clear();
                tabla_servicios();
            }
            else
            {
                vgb_tabla.Columns.Clear();
                tabla_paquetes();
            }
        }

        private void rb_sectores_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sectores.Checked == true)
            {
                groupBox6.Enabled = false;
            }
            else
            {
                groupBox6.Enabled = true;
            }
        }

        private void btn_ver_lugares_Click(object sender, EventArgs e)
        {
            if (rb_barrio.Checked == true)
            {
                vgb_tabla.Columns.Clear();
                tablaBarrio();
            } else if (rb_colonias.Checked == true)
            {
                vgb_tabla.Columns.Clear();
                tablaColonia();
            } else if (rb_sectores.Checked == true)
            {
                vgb_tabla.Columns.Clear();
                tablaSector();
            }
        }

        private void btn_bu_cli_Click(object sender, EventArgs e)
        {
            Program.sele_Cliente = new Pagos.Sele_Cliente();
            Program.sele_Cliente.Show();
            Program.sele_Cliente.TopMost = true;
            Program.sele_Cliente.Focus();
            Program.sele_Cliente.BringToFront();

        }

        private void ReportesTipo_Activated(object sender, EventArgs e)
        {
            txt_cliente.Text = nombre;
        }
    }
}
