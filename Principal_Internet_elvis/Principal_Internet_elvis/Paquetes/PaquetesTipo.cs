using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Principal_Internet_elvis.Paquetes
{
    public partial class PaquetesTipo : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        SqlCommand cm;

        public PaquetesTipo()
        {
            InitializeComponent();
        }

        private void bt_paquete_Click(object sender, EventArgs e)
        {
            Program.paquetesAgregar = new PaquetesAgregar();
            if (this.Text.Equals("PAQUETES-AGREGAR"))
            {
                Program.paquetesAgregar.Text = "AGREGAR-PAQUETE";
            }
            else if (this.Text.Equals("PAQUETES-BUSCAR"))
            {
                Program.paquetesAgregar.Text = "BUSCAR-PAQUETE";
            }
            else if (this.Text.Equals("PAQUETES-MODIFICAR"))
            {
                Program.paquetesAgregar.Text = "MODIFICAR-PAQUETE";
            }
            else if (this.Text.Equals("PAQUETES-ESTADO"))
            {
                Program.paquetesAgregar.Text = "ESTADO-PAQUETE";
            }
            Program.paquetesAgregar.Show();
            Program.paquetesAgregar.Focus();
            this.Close();
        }

        private void bt_servicio_Click(object sender, EventArgs e)
        {
            Program.servicios = new Servicios();
            if (this.Text.Equals("PAQUETES-AGREGAR"))
            {
                Program.servicios.Text = "AGREGAR-SERVICIO";
            }
            else if (this.Text.Equals("PAQUETES-BUSCAR"))
            {
                Program.servicios.Text = "BUSCAR-SERVICIO";
            }
            else if (this.Text.Equals("PAQUETES-MODIFICAR"))
            {
                Program.servicios.Text = "MODIFICAR-SERVICIO";
            }
            else if (this.Text.Equals("PAQUETES-ESTADO"))
            {
                Program.servicios.Text = "ESTADO-SERVICIO";
            }
            Program.servicios.Show();
            Program.servicios.Focus();
            this.Close();
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falla en la busqueda:"+ex.ToString());
                }
                
            }

        }

        public void tabla()
        {

            try
            {

                if (txt_buscar.Text == "")
                {
                    cm = new SqlCommand("Select * from Paquete", cn);
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    dgv_tabla.DataSource = tabla;
                }
                else
                {
                    cm = new SqlCommand("Select * from Paquete where descripcion1 like '%"+txt_buscar.Text+"%'", cn);
                    cm.ExecuteNonQuery();
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


        private void PaquetesTipo_Load(object sender, EventArgs e)
        {
            cn.Open();
            tabla();
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
