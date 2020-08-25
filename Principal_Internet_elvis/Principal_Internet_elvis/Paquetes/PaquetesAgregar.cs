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


namespace Principal_Internet_elvis.Paquetes
{
    public partial class PaquetesAgregar : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public PaquetesAgregar()
        {
            InitializeComponent();
        }

        private void PaquetesAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MessageBox.Show("Conexion exitosa");
                tabla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion:" + ex.ToString());
            }
        }

        public void tabla()
        {

            try
            {
                cm = new SqlCommand("Select * from Paquete", cn);
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
            string insertar = "INSERT INTO Paquete(descripcion1,descripcion2,descuento,precio,estado) VALUES (@descripcion1,@descripcion2,@descuento,@precio,@estado)";
            if (txt_p_servicio.Text == "" ||
                txt_s_servicio.Text == "" ||
                txt_descuento.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            { 
            try
            {

                if (txt_codigo.Text != "")
                {
                    cm = new SqlCommand("Select idpaquete from Paquete where idpaquete= @id", cn);
                    cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Este registro ya existe");
                    limpiar();
                }
                else
                {
                    cm = new SqlCommand(insertar, cn);
                    cm.Parameters.AddWithValue("@descripcion1", txt_p_servicio.Text);
                    cm.Parameters.AddWithValue("@descripcion2", txt_s_servicio.Text);
                    cm.Parameters.AddWithValue("@descuento", txt_descuento.Text);
                    cm.Parameters.AddWithValue("@precio", txt_nuevo_presio.Text);
                    cm.Parameters.AddWithValue("@estado", "Desactivado");
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
        }

        public void borrar()
        {
            try
            {
                string borrar = "DELETE FROM Paquete WHERE idpaquete = @id";
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
            string actu = "UPDATE Paquete SET descripcion1 = @descripcion1, descripcion2 = @descripcion2,descuento = @descuento, precio = @precio,estado = @estado WHERE idpaquete = @id";
            if (txt_p_servicio.Text == "" ||
                txt_s_servicio.Text == "" ||
                txt_descuento.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacios");
            }
            else
            {
                try
                {
                    cm = new SqlCommand(actu, cn);
                    cm.Parameters.AddWithValue("@descripcion1", txt_p_servicio.Text);
                    cm.Parameters.AddWithValue("@descripcion2", txt_s_servicio.Text);
                    cm.Parameters.AddWithValue("@descuento", txt_descuento.Text);
                    cm.Parameters.AddWithValue("@precio", txt_nuevo_presio.Text);
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
            txt_descuento.Text = "";
            txt_nuevo_presio.Text = "";
            txt_pre_p_servicio.Text = "";
            txt_pre_s_servicio.Text = "";
            txt_p_servicio.Text = "";
            txt_s_servicio.Text = "";
            
        }

        

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
            txt_p_servicio.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            txt_s_servicio.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_descuento.Text = dgv_tabla.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            borrar();
        }
    }
}

