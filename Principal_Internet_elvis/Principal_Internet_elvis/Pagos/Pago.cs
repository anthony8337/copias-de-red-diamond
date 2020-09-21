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

        public void recibo_agregar()
        {
            string codigo = "INSERT INTO Factura(idcliente, fecha, paquetes, tipopago, importe_gravado_15,importe_gravado_18, isv15, isv18, excento, exonerado, pago_total)VALUES(@idcliente, @fecha, @paquetes, @tipopago,@importe_gravado_15,@importe_gravado_18, @isv15, @isv18, @excento, @exonerado, @total)";

            float i15, i18 , ig15, ig18;
            try
            {
                i15 = float.Parse(Math.Round(float.Parse(txt_monto_p.Text) * 0.15f).ToString());
                i18 = float.Parse(Math.Round(float.Parse(txt_monto_p.Text) * 0.18f).ToString());
                ig18 = float.Parse(txt_monto_p.Text) - i18;
                ig15 = float.Parse(txt_monto_p.Text) - i15;




                cm = new SqlCommand(codigo, cn);
                cm.Parameters.AddWithValue("@idcliente", int.Parse(txt_codigo_c.Text));
                cm.Parameters.AddWithValue("@fecha", dtp_fecha.Value.ToShortDateString());
                cm.Parameters.AddWithValue("@paquetes", txt_descripcion_p.Text);
                cm.Parameters.AddWithValue("@tipopago", cb_tipopago.Text);

                if (r_15.Checked == true && r_18.Checked == false)
                {
                    cm.Parameters.AddWithValue("@importe_gravado_15", ig15);
                    cm.Parameters.AddWithValue("@isv15", i15);
                    cm.Parameters.AddWithValue("@importe_gravado_18", 0);
                    cm.Parameters.AddWithValue("@isv18", 0);
                }
                else if (r_15.Checked == false && r_18.Checked == true)
                {
                    cm.Parameters.AddWithValue("@importe_gravado_15", 0);
                    cm.Parameters.AddWithValue("@isv15", 0);
                    cm.Parameters.AddWithValue("@importe_gravado_18", ig18);
                    cm.Parameters.AddWithValue("@isv18", i18);
                }

                cm.Parameters.AddWithValue("@excento", 0);
                cm.Parameters.AddWithValue("@exonerado", 0);
                cm.Parameters.AddWithValue("@total", txt_monto_p.Text);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden haber campos vacios");
            }



        }

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

        public void tabla_factura()
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM V_factura WHERE fecha = '" + dtp_fecha.Value.ToShortDateString() + "' AND nombre='"+ txt_nombre_c.Text +"'", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                dgv_detalles.DataSource = tabla;
            }
            catch (Exception ex)
            { }
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
            tabla_factura();
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
                textBox1.Text = "";

            }
            else if (cb_tipopago.Text == "TARGETA DE CREDITO")
            {

                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = true;
                groupBox5.Text = "No. TARJETA DE CREDITO";
                textBox1.Text = "";

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

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            recibo_agregar();
            tabla_factura();
        }
    }
}
