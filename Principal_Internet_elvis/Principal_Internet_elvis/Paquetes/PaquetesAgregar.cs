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
        SqlCommand cm,cm2,cm3,cm4;
        

        public static string P_servicio, S_servicio;
        public int inicio , actuarliza1, actuarliza2;
        public float presi;

        public void vinculo()
        {
            if (Text == "AGREGAR-PAQUETE")
            {
                cm = new SqlCommand("Select top(1) * from Paquete order by idpaquete desc", cn);
                inicio = int.Parse(cm.ExecuteScalar().ToString());

                cm = new SqlCommand("INSERT INTO ServicioPaquete(idservicio,idpaquete) VALUES (@id1 ,@idq1)", cn);
                cm.Parameters.AddWithValue("@id1", actuarliza1);
                cm.Parameters.AddWithValue("@idq1", inicio);
                cm.ExecuteNonQuery();

                cm2 = new SqlCommand("INSERT INTO ServicioPaquete(idservicio,idpaquete) VALUES (@id2 ,@idq2)", cn);
                cm2.Parameters.AddWithValue("@id2", actuarliza2);
                cm2.Parameters.AddWithValue("@idq2", inicio);
                cm2.ExecuteNonQuery();
            }
            else if(Text == "MODIFICAR-PAQUETE")
            {

                cm = new SqlCommand("UPDATE ServicioPaquete SET idservicio = @idservicio1 WHERE idpaquete = @pa1", cn);
                cm.Parameters.AddWithValue("@idservicio1", actuarliza1);
                cm.Parameters.AddWithValue("@pa1", txt_codigo.Text);
                cm.ExecuteNonQuery();

                cm2 = new SqlCommand("UPDATE ServicioPaquete SET idservicio = @idservicio2 WHERE idpaquete = @pa2", cn);
                cm2.Parameters.AddWithValue("@idservicio2", actuarliza2);
                cm2.Parameters.AddWithValue("@pa2", txt_codigo.Text);
                cm2.ExecuteNonQuery();
            }
            
        }

        public void valor()
        {
            float precio;
            
                try
                {
                    if (txt_descuento.Text == "")
                    {
                        precio = float.Parse(txt_pre_p_servicio.Text) + float.Parse(txt_pre_s_servicio.Text);
                    
                        txt_nuevo_presio.Text = Math.Round(precio).ToString();
                    }
                    else
                    {
                        precio = (float.Parse(txt_pre_p_servicio.Text) + float.Parse(txt_pre_s_servicio.Text)) * (float.Parse(txt_descuento.Text) / 100);

                        txt_nuevo_presio.Text = Math.Round(precio).ToString();
                }
                }
                catch (Exception ex)
                { }
            }
            
        

        public void infor1()
        {
            try
            {
                cm = new SqlCommand("SELECT idservicio FROM Servicio WHERE descripcion = @des", cn);
                cm2 = new SqlCommand("SELECT precio FROM Servicio WHERE descripcion = @pres", cn);

                cm.Parameters.AddWithValue("@des", P_servicio);
                cm2.Parameters.AddWithValue("@pres", P_servicio);

                actuarliza1 = int.Parse(cm.ExecuteScalar().ToString());
                presi = float.Parse(cm2.ExecuteScalar().ToString());

                txt_pre_p_servicio.Text = presi.ToString();
                txt_p_servicio.Text = P_servicio;
                
                valor();

            }
            catch (Exception ex)
            {}

        }
        public void infor2()
        {
            try
            {
                cm = new SqlCommand("SELECT idservicio FROM Servicio WHERE descripcion = @de2", cn);
                cm2 = new SqlCommand("SELECT precio FROM Servicio WHERE descripcion = @pre2", cn);

                cm.Parameters.AddWithValue("@de2", S_servicio);
                cm2.Parameters.AddWithValue("@pre2", S_servicio);

                actuarliza2 = int.Parse(cm.ExecuteScalar().ToString());
                presi = float.Parse(cm2.ExecuteScalar().ToString());

                txt_pre_s_servicio.Text = presi.ToString();
                txt_s_servicio.Text = S_servicio;

                

                valor();

            }
            catch (Exception ex)
            { }

        }

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
                txt_descuento.Text == ""  
                )
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
                        cm.Parameters.AddWithValue("@precio", float.Parse(txt_nuevo_presio.Text));
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

                string borrar2 = "DELETE FROM ServicioPaquete WHERE idpaquete = @id";
                cm2 = new SqlCommand(borrar2,cn);
                cm = new SqlCommand(borrar, cn);

                cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                cm2.Parameters.AddWithValue("@id", txt_codigo.Text);

                cm2.ExecuteNonQuery();
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
                    string actu = "UPDATE Paquete SET descripcion1 = @descripcion1 ,descripcion2 = @descripcion2, descuento = @descuento ,precio = @precio, estado = @estado WHERE idpaquete = @id";
                    cm = new SqlCommand(actu, cn);
                    cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                    cm.Parameters.AddWithValue("@descripcion1", txt_p_servicio.Text);
                    cm.Parameters.AddWithValue("@descripcion2", txt_s_servicio.Text);
                    cm.Parameters.AddWithValue("@descuento", txt_descuento.Text);
                    cm.Parameters.AddWithValue("@precio", float.Parse(txt_nuevo_presio.Text));
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
            P_servicio = "";
            S_servicio = "";

        }



        private void bt_aceptar_Click(object sender, EventArgs e)
        {

            if (Text == "AGREGAR-PAQUETE")
            {
                agregar();
                vinculo();
                limpiar();
            }
            else if(Text == "MODIFICAR-PAQUETE")
            {
                actualizar();
                vinculo();
                limpiar();
            }
            
        }
        
        private void txt_descuento_TextChanged(object sender, EventArgs e)
        {
            valor();
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
            txt_p_servicio.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            txt_s_servicio.Text = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_descuento.Text = dgv_tabla.CurrentRow.Cells[3].Value.ToString();
            txt_nuevo_presio.Text = dgv_tabla.CurrentRow.Cells[4].Value.ToString();

            S_servicio = txt_s_servicio.Text;
            P_servicio = txt_p_servicio.Text;

            infor1();
            infor2();
            valor();

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            cm3 = new SqlCommand("DBCC CHECKIDENT (Paquete, RESEED,0)",cn);
            cm3.ExecuteNonQuery();

            borrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.paquetesElegir = new PaquetesElegir();
            Program.paquetesElegir.Text = "ELEGIR EL PRIMER SERVICIO";
            Program.paquetesElegir.BringToFront();
            Program.paquetesElegir.Show();

        }
        
        private void PaquetesAgregar_Activated(object sender, EventArgs e)
        {
            infor1();
            infor2();

            cm = new SqlCommand("Select top(1) * from Paquete order by idpaquete desc", cn);
            try
            {
                inicio = int.Parse(cm.ExecuteScalar().ToString()) + 1;
            }
            catch (Exception ex)
            {
                inicio = 1;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.paquetesElegir = new PaquetesElegir();
            Program.paquetesElegir.Text = "ELEGIR EL SEGUNDO SERVICIO";
            Program.paquetesElegir.BringToFront();
            Program.paquetesElegir.Show();
        }
    }
}

