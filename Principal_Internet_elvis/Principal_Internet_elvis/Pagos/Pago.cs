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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Principal_Internet_elvis.Pagos
{
    public partial class Pago : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public void buscar_c()
        {
            cm = new SqlCommand("SELECT * FROM V_cliente_pago WHERE nombre like '%" + txt_buscar_c.Text + "%'", cn);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            dgv_tabla_c.DataSource = tabla;
        }

        public void buscar_p()
        {
            cm = new SqlCommand("SELECT * FROM V_paquetes_pago WHERE idcliente = '" + txt_codigo_c.Text+"' and nombre_cliente like '%"+txt_b_p.Text+"%'",cn);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            dgv_tabla_p.DataSource = tabla;
        }

        public Pago()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            cn.Open();
            buscar_c();
            buscar_p();
        }

        private void txt_buscar_c_TextChanged(object sender, EventArgs e)
        {
            buscar_c();
        }

        private void btnbusCLI_Click(object sender, EventArgs e)
        {
            gb_cliente.Visible = false;
            gBusCliente.Visible = true;
        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {
            gb_cliente.Visible = true;
            gBusCliente.Visible = false;
        }

        private void dgv_tabla_c_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_c.Text = dgv_tabla_c.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_c.Text = dgv_tabla_c.CurrentRow.Cells[1].Value.ToString();
            txt_rtn_c.Text = dgv_tabla_c.CurrentRow.Cells[2].Value.ToString();
            txt_direccion_c.Text = dgv_tabla_c.CurrentRow.Cells[3].Value.ToString();

            gb_cliente.Visible = true;
            gBusCliente.Visible = false;
            buscar_p();

        }

        private void btnBusCON_Click(object sender, EventArgs e)
        {
            gb_paquete.Visible = false;
            gBusConcep.Visible = true;
        }

        private void btnAtrasConcepto_Click(object sender, EventArgs e)
        {
            gb_paquete.Visible = true;
            gBusConcep.Visible = false;
        }

        private void txt_b_p_TextChanged(object sender, EventArgs e)
        {
            buscar_p();
        }

        private void dgv_tabla_p_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo_p.Text = dgv_tabla_p.CurrentRow.Cells[0].Value.ToString();
            txt_descripcion_p.Text = dgv_tabla_p.CurrentRow.Cells[1].Value.ToString();
            txt_monto_p.Text = dgv_tabla_p.CurrentRow.Cells[2].Value.ToString();
            txt_monto_to.Text = dgv_tabla_p.CurrentRow.Cells[2].Value.ToString();

            gb_paquete.Visible = true;
            gBusConcep.Visible = false;

        }

        public void borrar()
        {

            txt_codigo_p.Text = "";
            txt_codigo_c.Text = "";
            txt_rtn_c.Text = "";
            txt_nombre_c.Text = "";
            txt_descripcion_p.Text = "";
            txt_monto_p.Text = "";
            txt_efectivo.Text = "";
            txt_cambio.Text = "";
            txt_direccion_c.Text = "";
            txt_monto_to.Text = "";

        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void Pago_Activated(object sender, EventArgs e)
        {
            
        }

        private void cb_tipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipopago.Text == "EFECTIVO")
            {
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox5.Visible = false;
            }
            else if (cb_tipopago.Text == "TARGETA DE DEBITO")
            {

                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = true;
                groupBox5.Text = "No. TARJETA DE DEBITO";

            }
            else if (cb_tipopago.Text == "TARGETA DE CREDITO")
            {

                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = true;
                groupBox5.Text = "No. TARJETA DE CREDITO";

            }
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            letras_numero l = new letras_numero();
            l.solonumero(e);
        }

        private void txt_efectivo_TextChanged(object sender, EventArgs e)
        {
            int suma;
            try
            {
                suma = (int.Parse(txt_efectivo.Text)) - (int.Parse(txt_monto_to.Text));
                
                if (suma <= 0)
                {
                    txt_cambio.Text = "0";
                }
                else
                {
                    txt_cambio.Text = suma.ToString();
                }

            }
            catch (Exception ex)
            { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            letras_numero l = new letras_numero();
            l.solonumero(e);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Program.factura = new Factura();
            Program.factura.BringToFront();
            Program.factura.Show();
        }
    }
}
