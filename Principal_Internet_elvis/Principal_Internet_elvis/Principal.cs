using Principal_Internet_elvis;
using Principal_Internet_elvis.Configuraciones;
using Principal_Internet_elvis.FormmGenerales;
using Principal_Internet_elvis.Pagos;
using Principal_Internet_elvis.Reportes;
using Proyecto_Internet;
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

namespace Proyecto_dawelin
{
    public partial class Principal : Form
    {

        

        public int idu;
        public string user, clave, desc, nombre;
        public Font fuente;
        public Image logo;

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        //empresa
        public string nombre_e, eslogan_e, rtn_e, cai_e, correo_e, fechalimite_e;
        public int desde_e, hasta_e, ide;


        public Principal()
        {
            InitializeComponent();
        }

        public void activarConUser()
        {
            btnPago.Enabled = true;
            btnCliente.Enabled = true;
            btnEstado.Enabled = true;
            btnPaquetes.Enabled = true;
            btnUbicacion.Enabled = true;
            btnReportes.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnSalir.Enabled = true;
            if(logo != null)
            {
                img_logo.Image = logo;
                img_logo.BackColor = Color.SlateGray;
            }
            actualizar();
        }

        private void actualizar()
        {
            tabla();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            Program.configuracion = new Configuracion();
            Program.configuracion.Show();
            Program.configuracion.TopMost = true;
            Program.configuracion.Focus();
            Program.configuracion.BringToFront();
            Program.configuracion.Text = "CONFIGURACION";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Program.reportesTipo = new ReportesTipo();
            Program.reportesTipo.Show();
            Program.reportesTipo.Focus();
            Program.reportesTipo.BringToFront();
            Program.reportesTipo.Text = "REPORTES";
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Program.bus_Factura = new Bus_factura();
            Program.bus_Factura.Show();
            Program.bus_Factura.Focus();
            Program.bus_Factura.BringToFront();
            Program.bus_Factura.Text = "BUSQUEDA-FACTURAS";
        }

        private void dgv_pendientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgv_tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int row = dgv_tabla.CurrentRow.Index;

                Program.estado_Cliente = new Estado_cliente();
                Program.estado_Cliente.accesoRapido(dgv_tabla.Rows[row].Cells["nombre"].Value.ToString());
                Program.estado_Cliente.Show();
                Program.estado_Cliente.Focus();
                Program.estado_Cliente.BringToFront();
                Program.estado_Cliente.Text = "ESTADO-CLIENTES";
            }
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.Open();

            

            Principal p = new Principal();

            if (p.Enabled == true)
            {
                tabla();
            }
            Program.inicio = new Inicio();
            Program.inicio.Show();
            Program.inicio.TopMost = true; 
            Program.inicio.Focus(); 
            Program.inicio.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntPago_Click(object sender, EventArgs e)
        {
            Program.pago = new Pago();
            Program.pago.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Program.OpCliente = new Opciones();
            Program.OpCliente.Show();
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
            Program.OpCliente.Text = "CLIENTES";
            
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            img_logo.Left = this.Width - (img_logo.Width + 25);
            lb_pendiente.Left = this.Width - (lb_pendiente.Width + 25);
            bt_actualizar.Left = this.Width - (bt_actualizar.Width + 25);
            dgv_tabla.Left = this.Width - (dgv_tabla.Width + 25);
            dgv_tabla.Top = this.Height - (dgv_tabla.Height + 50);
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Program.OpCliente = new Opciones();
            Program.OpCliente.Show();
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
            Program.OpCliente.Text = "UBICACION";
        }

        private void bt_estado_Click(object sender, EventArgs e)
        {
            Program.estado_Cliente = new Estado_cliente();
            Program.estado_Cliente.Show();
            Program.estado_Cliente.Focus();
            Program.estado_Cliente.BringToFront();
            Program.estado_Cliente.Text = "ESTADO-CLIENTES";
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            Program.OpCliente = new Opciones();
            Program.OpCliente.Show();
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
            Program.OpCliente.Text = "PAQUETES";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.configuracion = new Configuracion();
            Program.configuracion.Show();
            Program.OpCliente.Focus();
            Program.OpCliente.BringToFront();
        }

        public void tabla()
        {
            try
            {
                cm = new SqlCommand("Select * from Cliente WHERE estado = 'PENDIENTE INSTALACION'", cn);
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

        public void addFuente(Font f)
        {
            foreach (Button boton in Program.GetAllChildren(this).OfType<Button>())
            {
                boton.Font = f;
            }

            foreach (Label boton in Program.GetAllChildren(this).OfType<Label>())
            {
                boton.Font = f;
            }
        }
    }
}
