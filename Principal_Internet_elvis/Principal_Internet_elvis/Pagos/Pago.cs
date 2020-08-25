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

namespace Principal_Internet_elvis.Pagos
{
    public partial class Pago : Form
    {
        private int idclientepa = -1;
        private float total = -1, desc = -1, isv = -1, totalpagar = 0, subtotal = 0, descuento = 0, impuesto = 0;
        private string mensualidad = "";

        private int idfactura;

        DataTable dt = new DataTable();
        private int filadetalles = -1;

        public Pago()
        {
            InitializeComponent();
            gBusCliente.Visible = false;
            gBusConcep.Visible = false;
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            addFuente(Program.principal.fuente);
            if (Program.principal.logo != null)
            {
                img_logo.Image = Program.principal.logo;
                img_logo.Visible = true;
            }

            dt.Columns.Add("ID");
            dt.Columns.Add("FECHA");
            dt.Columns.Add("TOTAL");
            dt.Columns.Add("DESCUENTO");
            dt.Columns.Add("ISV");
            dt.Columns.Add("PAQUETE");
            dt.Columns.Add("CANTIDAD");
            dt.Columns.Add("MONTO");

            dgv_detalles.DataSource = dt;
            dgv_detalles.Columns[0].Visible = false;
            dgv_detalles.Columns[1].Visible = false;
            dgv_detalles.Columns[2].Visible = false;
            dgv_detalles.Columns[3].Visible = false;
            dgv_detalles.Columns[4].Visible = false;
        }

        private void btnbusCLI_Click(object sender, EventArgs e)
        {
            gBusCliente.Visible = true;
            gb_cliente.Visible = false;
            txt_buscar_c.Select();
        }

        private void btnBusCON_Click(object sender, EventArgs e)
        {}

        private void btnAtrasConcepto_Click(object sender, EventArgs e)
        {
            gBusConcep.Visible = false;
            gb_paquete.Visible = true;
        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {
            gBusCliente.Visible = false;
            gb_cliente.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(filadetalles == -1)
            {
                MessageBox.Show("Seleccione un detalle para poder borrarlo.");
                return;
            }
            dt.Rows[filadetalles].Delete();
            limpiarPaquete();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

            foreach (Label e in Program.GetAllChildren(this).OfType<Label>())
            {
                e.Font = f;
            }

            foreach (RadioButton e in Program.GetAllChildren(this).OfType<RadioButton>())
            {
                e.Font = f;
            }
        }

        private void txt_buscar_c_KeyDown(object sender, KeyEventArgs e)
        {}

        private void dgv_tabla_c_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla_c.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_tabla_c.CurrentRow.Index;
                int c = int.Parse(dgv_tabla_c.Rows[row].Cells["idcliente"].Value.ToString());
                txt_codigo_c.Text = c.ToString("D10");
                txt_nombre_c.Text = dgv_tabla_c.Rows[row].Cells["nombre"].Value.ToString();
                txt_rtn_c.Text = dgv_tabla_c.Rows[row].Cells["rtn"].Value.ToString();
                txt_direccion_c.Text = dgv_tabla_c.Rows[row].Cells["direccion"].Value.ToString();

                dgv_tabla_c.DataSource = null;
                gBusCliente.Visible = false;
                gb_cliente.Visible = true;
                txt_buscar_c.Text = "";

                gb_acciones.Enabled = true;
                gb_paquete.Enabled = true;
                btnImprimir.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void dgv_tabla_p_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cb_tipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_tipopago.SelectedIndex == 0)
            {
                txt_efectivo.Text = "";
                txt_cambio.Text = "";
                txt_efectivo.Enabled = true;
            }
            else
            {
                txt_efectivo.Text = "" + totalpagar;
                txt_efectivo.Enabled = false;
                txt_cambio.Text = "0";
            }
        }

        private void txt_efectivo_KeyUp(object sender, KeyEventArgs e)
        {
            if (float.Parse(txt_efectivo.Text) >= totalpagar)
            {
                txt_cambio.Text = "" + (float.Parse(txt_efectivo.Text) - totalpagar);
            }
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if(cb_adelantado.Checked == false && (total == -1 || idclientepa == -1 || mensualidad == ""))
            {
                MessageBox.Show("Seleccione un mes a pagar.");
                return;
            }

            btnbusCLI.Enabled = false;

            DataRow dr = dt.NewRow();
            dr["ID"] = "" + int.Parse(txt_codigo_p.Text);
            dr["FECHA"] = dtp_mes_p.Value.ToString("yyyy/MM/dd");
            dr["TOTAL"] = "" + total;
            dr["DESCUENTO"] = desc;
            dr["ISV"] = "" + isv;
            dr["PAQUETE"] = txt_descripcion_p.Text+" - Mes: "+ mensualidad.ToUpper();
            dr["CANTIDAD"] = 1;
            dr["MONTO"] = txt_monto_p.Text;

            dt.Rows.Add(dr);

            limpiarPaquete();
        }


        private void limpiarPaquete()
        {
            foreach (TextBox e in Program.GetAllChildren(gb_paquete).OfType<TextBox>())
            {
                e.Text = "";
            }

            idclientepa = -1;
            total = -1;
            mensualidad = "";
            filadetalles = -1;

            totalpagar = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                subtotal = float.Parse(dt.Rows[i]["TOTAL"].ToString()) + subtotal;
                descuento = float.Parse(dt.Rows[i]["DESCUENTO"].ToString()) + descuento;
                impuesto = float.Parse(dt.Rows[i]["ISV"].ToString()) + impuesto;
            }
            totalpagar = subtotal - descuento;

            txt_totalpagar.Text = totalpagar.ToString("L0.00");

            dgv_detalles.ClearSelection();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_adelantado_CheckedChanged(object sender, EventArgs e)
        {
            dtp_mes_p.Enabled = cb_adelantado.Checked;
            mensualidad = dtp_mes_p.Value.ToString("MMMM");
        }

        private void dtp_mes_p_ValueChanged(object sender, EventArgs e)
        {
            mensualidad = dtp_mes_p.Value.ToString("MMMM");
        }

        private void limpiarTodo()
        {
            btnbusCLI.Enabled = true;

            gBusConcep.Visible = false;
            gb_paquete.Visible = true;

            gBusCliente.Visible = false;
            gb_cliente.Visible = true;

            cb_tipopago.Text = "";

            dt.Rows.Clear();

            limpiarPaquete();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { }

        private void insertarCuota(int idclientepa, string descrip, string fecha, string mes, float monto, float descuent, float isv, int estado)
        {}

        private void dgv_detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_detalles.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                filadetalles = dgv_detalles.CurrentRow.Index;
            }
        }

        private void mostrarFactura(int id)
        { }
    }
}
