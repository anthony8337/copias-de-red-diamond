using Principal_Internet_elvis.Paquetes;
using Principal_Internet_elvis.Ubicacion;
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
using System.Data.SqlTypes;


namespace Principal_Internet_elvis.ClientesCarpeta
{
    public partial class Clientes : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        SqlCommand cm;
        
        public Clientes()
        {
            InitializeComponent();
        }
        
        private void Clientes_Load(object sender, EventArgs e)
        {

            cargar_inicio();

        }

        public void cargar_inicio()
        {

            if (Text != "CLIENTE-AGREGAR")
            {
                btn_borrar.Enabled = false;
            }

            try
            {
                cn.Open();
                MessageBox.Show("Conexion correcta");
                tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion: ", ex.ToString());
            }

            
        }


        public void tabla()
        {

            try
            {
                cm = new SqlCommand("Select * from Cliente", cn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cm;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                dgv_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: "+e.ToString());
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

        public void buscar()
        {
            cm = new SqlCommand("Select * from Cliente", cn);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cm;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            dgv_tabla.DataSource = tabla;
        }

        public void agregar()
        {
            string insertar = "insert into Cliente (nombre, rtn, telefono, genero, correo, fecha, direccion, lugar, estado) " +
            "VALUES (@nombre, @rtn, @telefono, @genero, @correo, @fecha, @direccion, @lugar, @estado)";
            
            try
            {

                if (txt_codigo.Text != "")
                {
                    cm = new SqlCommand("Select idcliente from Cliente where idcliente= @id", cn);
                    cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Este registro ya existe");
                    limpiar();
                }
                else
                {
                    cm = new SqlCommand(insertar, cn);
                    cm.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cm.Parameters.AddWithValue("@rtn", txt_rtn.Text);
                    cm.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                    if (rb_femenino.Checked == true && rb_masculino.Checked == false)
                    {
                        cm.Parameters.AddWithValue("@genero", "F");
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@genero", "M");
                    }
                    cm.Parameters.AddWithValue("@correo", txt_correo.Text);
                    cm.Parameters.AddWithValue("@fecha", dtp_fecha.Value.ToShortDateString());
                    cm.Parameters.AddWithValue("@direccion", txt_direccion.Text);
                    cm.Parameters.AddWithValue("@lugar", txt_lugar.Text);
                    cm.Parameters.AddWithValue("@estado", "PENDIENTE INSTALACION");
                    cm.ExecuteNonQuery();
                    tabla();
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encontro ploblemas en: " + ex.ToString());
            }
        }

        public void actualizar()
        {

            try
            {

                string actualizar = "UPDATE Cliente SET nombre = @nombre, rtn = @rtn, telefono = @telefono, genero = @genero, correo = @correo, fecha = @fecha, direccion = @direccion, lugar = @lugar, estado = @estado" +
                    " WHERE idcliente = @id";

                cm = new SqlCommand(actualizar, cn);
                cm.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                cm.Parameters.AddWithValue("@rtn", txt_rtn.Text);
                cm.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                if (rb_femenino.Checked == true && rb_masculino.Checked == false)
                {
                    cm.Parameters.AddWithValue("@genero", "F");
                }
                else
                {
                    cm.Parameters.AddWithValue("@genero", "M");
                }
                cm.Parameters.AddWithValue("@correo", txt_correo.Text);
                cm.Parameters.AddWithValue("@fecha", dtp_fecha.Value.ToShortDateString());
                cm.Parameters.AddWithValue("@direccion", txt_direccion.Text);
                cm.Parameters.AddWithValue("@lugar", txt_lugar.Text);
                cm.Parameters.AddWithValue("@estado", "PENDIENTE INSTALACION");
                cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                cm.ExecuteNonQuery();
                tabla();
                limpiar();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encontro ploblemas en:"+ ex.ToString());
            }
        }
        public void limpiar()
        {

            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_rtn.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_lugar.Text ="";
            dtp_fecha.Value = DateTime.Now;


        }
    

        public void agregarDatos(int id, string nombre)
        {
            txt_lugar.Text = nombre;
            
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            acciones();
        }


        public void acciones()
        {
            if (txt_nombre.Text == "" ||
                    txt_rtn.Text == "" ||
                    txt_telefono.Text == "" ||
                    txt_correo.Text == "" ||
                    txt_direccion.Text == "" ||
                    txt_lugar.Text == ""
                    )
            {
                MessageBox.Show("Ninguno de los campos deben estar vacios");
            }
            else
            {
                if (Text == "CLIENTE-AGREGAR")
                {
                    agregar();
                }

                if (Text == "CLIENTE-MODIFICAR")
                {
                    actualizar();
                    btn_borrar.Enabled = false;
                }

            }
        }
        
        private void bt_lugar_Click(object sender, EventArgs e)
        {
            
        }
        
        private void seleccionar()
        {
            
        }

        private void bt_paquetes_Click(object sender, EventArgs e)
        {
            Program.clientesPaquetes = new ClientesPaquetes();
            Program.clientesPaquetes.TopMost = true;
            Program.clientesPaquetes.Focus();
            Program.clientesPaquetes.BringToFront();
            Program.clientesPaquetes.Show();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Close();
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

        

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try {
                string borrar = "DELETE FROM Cliente WHERE idcliente = @id";
                cm = new SqlCommand(borrar, cn);
                cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                cm.ExecuteNonQuery();
                limpiar();
                tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La accion no se pudo realizar: "+ex.ToString());
            }

            }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            txt_rtn.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_telefono.Text = dgv_tabla.CurrentRow.Cells[3].Value.ToString();
            txt_correo.Text = dgv_tabla.CurrentRow.Cells[5].Value.ToString();
            dtp_fecha.Text = dgv_tabla.CurrentRow.Cells[6].Value.ToString();
            txt_direccion.Text = dgv_tabla.CurrentRow.Cells[7].Value.ToString();
            txt_lugar.Text = dgv_tabla.CurrentRow.Cells[8].Value.ToString();
            if (dgv_tabla.CurrentRow.Cells[4].Value.ToString() == "F")
            {
                rb_femenino.Checked = true;
                rb_masculino.Checked = false;
            }
            else
            {
                rb_femenino.Checked = false;
                rb_masculino.Checked = true;
            }
        }
    }
}
