using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Principal_Internet_elvis.Ubicacion
{
    public partial class UbicacionTipo : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public UbicacionTipo()
        {
            InitializeComponent();
        }

        private void bt_sector_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar.Text = "AGREGAR-SECTOR";
            }
            else if (this.Text.Equals("UBICACION-BUSCAR"))
            {
                Program.ubicacionAgregar.Text = "BUSCAR-SECTOR";
            }
            else if (this.Text.Equals("UBICACION-MODIFICAR"))
            {
                Program.ubicacionAgregar.Text = "MODIFICAR-SECTOR";
            }
            else if (this.Text.Equals("UBICACION-ESTADO"))
            {
                Program.ubicacionAgregar.Text = "ESTADO-SECTOR";
            }
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
            this.Close();
        }

        private void bt_barrio_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar.Text = "AGREGAR-BARRIO";
            }
            else if (this.Text.Equals("UBICACION-BUSCAR"))
            {
                Program.ubicacionAgregar.Text = "BUSCAR-BARRIO";
            }
            else if (this.Text.Equals("UBICACION-MODIFICAR"))
            {
                Program.ubicacionAgregar.Text = "MODIFICAR-BARRIO";
            }
            else if (this.Text.Equals("UBICACION-ESTADO"))
            {
                Program.ubicacionAgregar.Text = "ESTADO-BARRIO";
            }
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
            this.Close();
        }

        private void bt_lugar_Click(object sender, EventArgs e)
        {
            Program.ubicacionAgregar = new UbicacionAgregar();
            if (this.Text.Equals("UBICACION-AGREGAR"))
            {
                Program.ubicacionAgregar.Text = "AGREGAR-COLONIA";
            }
            else if (this.Text.Equals("UBICACION-BUSCAR"))
            {
                Program.ubicacionAgregar.Text = "BUSCAR-COLONIA";
            }
            else if (this.Text.Equals("UBICACION-MODIFICAR"))
            {
                Program.ubicacionAgregar.Text = "MODIFICAR-COLONIA";
            }
            else if (this.Text.Equals("UBICACION-ESTADO"))
            {
                Program.ubicacionAgregar.Text = "ESTADO-COLONIA";
            }
            Program.ubicacionAgregar.Show();
            Program.ubicacionAgregar.Focus();
            this.Close();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            groupBox3.Text = "SE ESTA MOSTRANDO LA TABLA: COLONIA";
            groupBox4.Visible = true;
            dgv_tabla.Columns.Clear();
            tablaColonia();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Text = "SE ESTA MOSTRANDO LA TABLA: BARRIO";
            groupBox4.Visible = true;
            dgv_tabla.Columns.Clear();
            tablaBarrio();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Text = "SE ESTA MOSTRANDO LA TABLA: SECTOR";
            groupBox4.Visible = false;
            dgv_tabla.Columns.Clear();
            tablaSector();
        }

        private void UbicacionTipo_Load(object sender, EventArgs e)
        {
            groupBox3.Text = "POR FAVOR, SELECCIONA ALGUNA UBICACION";
        }




    }
}
