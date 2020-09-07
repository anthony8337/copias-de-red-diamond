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

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public UbicacionAgregar()
        {
            InitializeComponent();
        }

        private void UbicacionAgregar_Load(object sender, EventArgs e)
        {
            disponible();
            cn.Open();
            selecciona_tabla();
        }


        public void agregar()
        {
            string agregar;

            if (Text == "AGREGAR-COLONIA" )
            {
                agregar = "INSERT INTO Colonia (colonia,estado)VALUES(@colonia , @estado)";
                try
                {
                    cm = new SqlCommand(agregar, cn);
                    cm.Parameters.AddWithValue("@colonia",txt_nombre.Text);
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
                agregar = "INSERT INTO Barrio (barrio,estado)VALUES(@barrio , @estado)";
                try
                {
                    cm = new SqlCommand(agregar, cn);
                    cm.Parameters.AddWithValue("@barrio", txt_nombre.Text);
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
        
        public void agregarDatos(int id, string nombre)
        {}

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            agregar();
            selecciona_tabla();
        }

        public void selecciona_tabla()
        {
            if (Text == "AGREGAR-COLONIA" || Text == "MODIFICAR-COLONIA" || Text == "BUSCAR-COLONIA")
            {
                groupBox3.Text = "NOMBRE DE LA COLONIA";
                tablaColonia();
            }
            else if (Text == "AGREGAR-BARRIO" || Text == "MODIFICAR-BARRIO" || Text == "BUSCAR-BARRIO")
            {
                groupBox3.Text = "NOMBRE DEL BARRIO";
                tablaBarrio();
            }
            else if (Text == "AGREGAR-SECTOR" || Text == "MODIFICAR-SECTOR" || Text == "BUSCAR-SECTOR")
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

            txt_codigo.Text = dgv_tabla.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = dgv_tabla.CurrentRow.Cells[1].Value.ToString();

        }



        public void tablaColonia()
        {

            try
            {
                cm = new SqlCommand("Select * from Colonia", cn);
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
                cm = new SqlCommand("Select * from Barrio", cn);
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
            if(Text == "AGREGAR-SECTOR" || Text == "MODIFICAR-SECTOR" || Text == "BUSCAR-SECTOR")
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
            textBox1.Text = sector;
        }

    }
}
