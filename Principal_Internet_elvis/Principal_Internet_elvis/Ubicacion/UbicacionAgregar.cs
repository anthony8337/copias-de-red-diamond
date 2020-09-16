using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Principal_Internet_elvis.Ubicacion
{
    public partial class UbicacionAgregar : Form
    {

        public static string sector;
        public static int idsector;

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public void buscar()
        {
            if (Text == "AGREGAR-COLONIA" || Text == "MODIFICAR-COLONIA")
            {
                try
                {
                    if (txt_nombre.Text != "")
                    {
                        dgv_tabla.Columns.Clear();
                        cm = new SqlCommand("Select * from V_colonia WHERE colonia like '%" + txt_nombre.Text + "%'", cn);
                        cm.ExecuteNonQuery();
                        SqlDataAdapter adp = new SqlDataAdapter();
                        adp.SelectCommand = cm;
                        DataTable tabla = new DataTable();
                        adp.Fill(tabla);
                        dgv_tabla.DataSource = tabla;
                    }
                    else
                    {
                        tablaColonia();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
                }


            }
            else if (Text == "AGREGAR-BARRIO" || Text == "MODIFICAR-BARRIO")
            {
                try
                {

                    if (txt_nombre.Text != "")
                    {
                        dgv_tabla.Columns.Clear();
                        cm = new SqlCommand("Select * from V_barrio WHERE barrio like '%" + txt_nombre.Text + "%'", cn);
                    cm.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    dgv_tabla.DataSource = tabla;
                    }
                    else
                    {
                        tablaColonia();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
                }
            }
            else if (Text == "AGREGAR-SECTOR" || Text == "MODIFICAR-SECTOR")
            {
                try
                {
                    if (txt_nombre.Text != "")
                    {
                        cm = new SqlCommand("Select * from Sector WHERE sector like '%" + txt_nombre.Text + "%'", cn);
                    cm.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cm;
                    DataTable tabla = new DataTable();
                    adp.Fill(tabla);
                    dgv_tabla.DataSource = tabla;
                    }
                    else
                    {
                        tablaSector();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
                }

            }
        }

        public void buscar_por_sector()
        
            {
                if (Text == "AGREGAR-COLONIA" || Text == "MODIFICAR-COLONIA")
                {
                    try
                    {
                        if (txt_sec.Text != "")
                        {
                            dgv_tabla.Columns.Clear();
                            cm = new SqlCommand("Select * from V_colonia WHERE sector like '%" + txt_sec.Text + "%'", cn);
                            cm.ExecuteNonQuery();
                            SqlDataAdapter adp = new SqlDataAdapter();
                            adp.SelectCommand = cm;
                            DataTable tabla = new DataTable();
                            adp.Fill(tabla);
                            dgv_tabla.DataSource = tabla;
                        limpiar();
                    }
                        else
                        {
                            tablaColonia();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
                    }


                }
                else if (Text == "AGREGAR-BARRIO" || Text == "MODIFICAR-BARRIO")
                {
                    try
                    {

                        if (txt_nombre.Text != "")
                        {
                        dgv_tabla.Columns.Clear();
                        cm = new SqlCommand("Select * from V_barrio WHERE sector like '%" + txt_sec.Text + "%'", cn);
                            cm.ExecuteNonQuery();
                            SqlDataAdapter adp = new SqlDataAdapter();
                            adp.SelectCommand = cm;
                            DataTable tabla = new DataTable();
                            adp.Fill(tabla);
                            dgv_tabla.DataSource = tabla;
                        limpiar();
                        }
                        else
                        {
                            tablaColonia();
                        }

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
                    }
                }


            }


            public void idse()
        {
            try
            {
                cm = new SqlCommand("Select idsector from Sector WHERE sector = @sector", cn);
                cm.Parameters.AddWithValue("@sector", sector);
                idsector = int.Parse(cm.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            { }
        }

        public UbicacionAgregar()
        {
            InitializeComponent();
        }

        private void UbicacionAgregar_Load(object sender, EventArgs e)
        {
            sector = "";
            idsector = 0;
            disponible();
            cn.Open();
            selecciona_tabla();
        }


        public void agregar()
        {
            

            string agregar;

            if (Text == "AGREGAR-COLONIA" )
            {
                agregar = "INSERT INTO Colonia (colonia,idsector,estado)VALUES(@colonia, @idsector, @estado)";
                try
                {
                    idse();
                    cm = new SqlCommand(agregar, cn);
                    cm.Parameters.AddWithValue("@colonia",txt_nombre.Text);
                    cm.Parameters.AddWithValue("@idsector", idsector);
                    cm.Parameters.AddWithValue("@estado", "DESCONECTADO");
                    cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se encontro fallas en: "+ex.ToString());
                }
                
            }
            else if (Text == "AGREGAR-BARRIO" )
            {
                agregar = "INSERT INTO Barrio (barrio,idsector,estado)VALUES(@barrio, @idsector, @estado)";
                try
                {
                    idse();
                    cm = new SqlCommand(agregar, cn);
                    cm.Parameters.AddWithValue("@barrio", txt_nombre.Text);
                    cm.Parameters.AddWithValue("@idsector", idsector);
                    cm.Parameters.AddWithValue("@estado", "DESCONECTADO");
                    cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se encontro fallas en: " + ex.ToString());
                }
            }
            else if (Text == "AGREGAR-SECTOR" )
            {
                agregar = "INSERT INTO Sector (Sector,estado)VALUES(@Sector , @estado)";
                try
                {
                    cm = new SqlCommand(agregar, cn);
                    cm.Parameters.AddWithValue("@Sector", txt_nombre.Text);
                    cm.Parameters.AddWithValue("@estado", "DESCONECTADO");
                    cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se encontro fallas en: " + ex.ToString());
                }
            }
        }



        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        private void bt_agregar_Click(object sender, EventArgs e)
        {

            

                if (Text == "MODIFICAR-COLONIA" || Text == "MODIFICAR-BARRIO" || Text == "MODIFICAR-SECTOR")
                {
                    modificar();
                }
                else
                {

                    if (txt_codigo.Text == "")
                    {
                        agregar();
                    }
                    else
                    {
                        MessageBox.Show("Este valor ya existe");
                    }

                }

                selecciona_tabla();
                limpiar();

        }

        public void selecciona_tabla()
        {
            if (Text == "AGREGAR-COLONIA" || Text == "MODIFICAR-COLONIA" )
            {
                groupBox3.Text = "NOMBRE DE LA COLONIA";
                tablaColonia();
            }
            else if (Text == "AGREGAR-BARRIO" || Text == "MODIFICAR-BARRIO" )
            {
                groupBox3.Text = "NOMBRE DEL BARRIO";
                tablaBarrio();
            }
            else if (Text == "AGREGAR-SECTOR" || Text == "MODIFICAR-SECTOR" )
            {
                groupBox3.Text = "NOMBRE DEL SECTOR";
                tablaSector();
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                
            }
        }
        
        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Text == "AGREGAR-SECTOR" || Text == "MODIFICAR-SECTOR")
            {
                txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                
                txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
                sector = dgv_tabla.CurrentRow.Cells[2].Value.ToString();
                idse();
                txt_sec.Text = sector;
                
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
                dgv_tabla.DataSource = tabla;
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
                dgv_tabla.DataSource = tabla;
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
                dgv_tabla.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizo la conecxion correctamente: " + e.ToString());
            }

        }
        
        public void limpiar()
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_sec.Text = "";
            sector = "";
            idsector = 0;

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


        public void disponible()
        {
            if(Text == "AGREGAR-SECTOR" || Text == "MODIFICAR-SECTOR")
            {

                groupBox1.Enabled = false;
                groupBox1.Visible = false;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
                Program.ubicacionElegir = new UbicacionElegir();
                Program.ubicacionElegir.Show();
                Program.ubicacionElegir.TopMost = true;
                Program.ubicacionElegir.Focus();
                Program.ubicacionElegir.BringToFront();
            


        }

        private void UbicacionAgregar_Activated(object sender, EventArgs e)
        {
            caja();
        }

        public void caja()
        {
            txt_sec.Text = sector;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            borrar();
        }


        public void borrar()
        {
            if (Text == "AGREGAR-COLONIA")
            {

                try
                {
                    string borrar = "DELETE FROM Colonia WHERE idcolonia = @id";
                    cm = new SqlCommand(borrar, cn);
                    cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                    cm.ExecuteNonQuery();
                    limpiar();
                    tablaColonia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este valor esta en uso \nPor favor, verifique si no hay componentes usandolo.");
                    limpiar();
                }

            }
            else if (Text == "AGREGAR-BARRIO")
            {

                try
                {
                    string borrar = "DELETE FROM Barrio WHERE idbarrio = @id";
                    cm = new SqlCommand(borrar, cn);
                    cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                    cm.ExecuteNonQuery();
                    limpiar();
                    tablaBarrio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este valor esta en uso \nPor favor, verifique si no hay componentes usandolo.");
                    limpiar();
                }

            }
            else if (Text == "AGREGAR-SECTOR")
            {

                try
                {
                    string borrar = "DELETE FROM Sector WHERE idsector = @id";
                    cm = new SqlCommand(borrar, cn);
                    cm.Parameters.AddWithValue("@id", txt_codigo.Text);
                    cm.ExecuteNonQuery();
                    limpiar();
                    tablaSector();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Este valor esta en uso \nPor favor, verifique si no hay componentes usandolo.");
                    limpiar();
                }

            }
            
        }

        public void modificar()
        {
            idse();

            string comando;

            try
            {
                if (Text == "MODIFICAR-COLONIA")
                {
                    comando = "UPDATE Colonia SET colonia = @colonia,idsector = @idsector WHERE idcolonia = @id";
                    cm = new SqlCommand(comando, cn);
                    cm.Parameters.AddWithValue("@colonia", txt_nombre.Text);
                    cm.Parameters.AddWithValue("@id", int.Parse(txt_codigo.Text));
                    cm.Parameters.AddWithValue("@idsector", idsector);
                    cm.ExecuteNonQuery();
                }
                else if (Text == "MODIFICAR-BARRIO")
                {
                    comando = "UPDATE Barrio SET barrio = @barrio,idsector = @idsector WHERE idbarrio = @id";
                    cm = new SqlCommand(comando, cn);
                    cm.Parameters.AddWithValue("@barrio", txt_nombre.Text);
                    cm.Parameters.AddWithValue("@id", int.Parse(txt_codigo.Text));
                    cm.Parameters.AddWithValue("@idsector", idsector);
                    cm.ExecuteNonQuery();
                }
                else if (Text == "MODIFICAR-SECTOR")
                {
                    comando = "UPDATE Sector SET sector = @sector WHERE idsector = @id";
                    cm = new SqlCommand(comando, cn);
                    cm.Parameters.AddWithValue("@sector", txt_nombre.Text);
                    cm.Parameters.AddWithValue("@id", int.Parse(txt_codigo.Text));
                    cm.Parameters.AddWithValue("@idsector", idsector);
                    cm.ExecuteNonQuery();
                }

                MessageBox.Show("Actualizacion realizada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la actualizacion: " +ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscar();
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscar_por_sector();
        }
    }
}
