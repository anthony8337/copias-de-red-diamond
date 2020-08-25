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
using System.Data.SqlTypes;

namespace Principal_Internet_elvis.Paquetes
{
    public partial class Servicios : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                tabla();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion: "+ex.ToString());
            }
        }

        public void tabla()
        {

            try
            {
                cm = new SqlCommand("Select * from Servicio", cn);
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

        public void agregar()
        {
            string i = "INSERT INTO Servicio(descripcion,precio,estado) VALUES (@descripcion,@precio,@estado)";
            if (txt_p_servicio.Text == "" ||
                txt_pre_p_servicio.Text == "")
            {
                limpiar();
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            { 
                try
                {
                    float f = (float)Convert.ToDouble(txt_pre_p_servicio.Text);
                    cm = new SqlCommand(i, cn);
                    cm.Parameters.AddWithValue("@descripcion", txt_p_servicio.Text);
                    cm.Parameters.AddWithValue("@precio", f);
                    cm.Parameters.AddWithValue("@estado", "DESACTIVADO");
                    cm.ExecuteNonQuery();
                    tabla();
                    limpiar();
                }
                catch (Exception ex)
                { MessageBox.Show("Fallo en la conexion: " + ex.ToString()); }
        }
        }

        public void borrar()
        {
            try
            {
                string borrar = "DELETE FROM Servicio WHERE idservicio = @id";
                cm = new SqlCommand(borrar, cn);
                cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                cm.ExecuteNonQuery();
                limpiar();
                tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La accion no se pudo realizar: " + ex.ToString());
            }

        }

        public void actualizar()
        {
            string actu = "UPDATE Servicio SET descripcion = @descripcion,precio = @precio,estado = @estado WHERE idservicio = @id";
            if (txt_p_servicio.Text == "" ||
                txt_pre_p_servicio.Text == "" )
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            {
                try
                {
                    cm = new SqlCommand(actu, cn);
                    cm.Parameters.AddWithValue("@descripcion", txt_p_servicio.Text);
                    cm.Parameters.AddWithValue("@precio", txt_pre_p_servicio.Text);
                    cm.Parameters.AddWithValue("@estado", "Desactivado");
                    cm.ExecuteNonQuery();
                    tabla();
                    limpiar();
                    cm.Parameters.AddWithValue("@estado", "Desactivado");
                    cm.ExecuteNonQuery();
                    tabla();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo al actualizar: " + ex.ToString());
                }
            }
        }

        public void limpiar()
        {
            txt_codigo.Text = "";
            txt_p_servicio.Text = "";
            txt_pre_p_servicio.Text = "";

        }

        public void selecionar()
        {
            txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
            txt_p_servicio.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            txt_pre_p_servicio.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionar();
        }
    }
}
