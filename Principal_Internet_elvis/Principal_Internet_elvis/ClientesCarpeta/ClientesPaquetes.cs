using Principal_Internet_elvis.Paquetes;
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

namespace Principal_Internet_elvis.ClientesCarpeta
{
    public partial class ClientesPaquetes : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;

        public static int idregistro;
        public static string nombre;

        public void tabla()
        {
            try
            {
                cm = new SqlCommand("Select * from V_clientepaquete WHERE idcliente = '"+idregistro+"'", cn);
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

            public ClientesPaquetes()
        {
            InitializeComponent();
        }
        
        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Program.paquetesElegir = new PaquetesElegir();
            Program.paquetesElegir.TopMost = true;
            Program.paquetesElegir.BringToFront();
            Program.paquetesElegir.Text = "ELEGIR-PAQUETES";
            Program.paquetesElegir.Show();
            Program.paquetesElegir.Focus();
        }
        
        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void ClientesPaquetes_Load(object sender, EventArgs e)
        {
            cn.Open();
            groupBox1.Text = "PAQUETES REGISTRADOS DE: " + nombre;
            tabla();
        }

        private void ClientesPaquetes_Activated(object sender, EventArgs e)
        {
            tabla();
        }
    }
}
