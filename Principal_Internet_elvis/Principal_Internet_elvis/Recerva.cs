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

namespace Principal_Internet_elvis.Copia_de_seguridad
{
    public partial class Backups : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;


        public void generarcopia()
        {

            string fecha = (System.DateTime.Today.Day.ToString()) +"-"+ (System.DateTime.Today.Month.ToString()) +"-"+ (System.DateTime.Today.Year.ToString()) + "-" + (System.DateTime.Today.Hour.ToString()) +":"+
                (System.DateTime.Today.Minute.ToString());
            string copia = "BACKUP DATABASE [proyecto] TO  DISK = N'C:\\no tocar\\proyecto "+fecha+".bak' WITH NOFORMAT, NOINIT,  NAME = N'proyecto-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            try { 
            cm = new SqlCommand(copia,cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Se realizo la copia de seguridad con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro fallos en: "+ex.ToString());
            }

        }


        public Backups()
        {
            InitializeComponent();
        }

        private void Backups_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generarcopia();
        }
    }
}
