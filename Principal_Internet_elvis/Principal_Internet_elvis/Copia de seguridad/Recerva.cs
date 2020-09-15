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
using System.Diagnostics;

namespace Principal_Internet_elvis.Copia_de_seguridad
{
    public partial class Backups : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
        SqlCommand cm;
        SqlCommand cm2,cm3,cm4;

        string fecha = (System.DateTime.Today.Day.ToString())+"_"+(System.DateTime.Today.Month.ToString()) + "_" + (System.DateTime.Today.Year.ToString());


        public void generarcopia()
        {
            string copia = "BACKUP DATABASE proyecto TO  DISK = N'C:\\no tocar\\proyecto"+fecha+".bak' WITH NOFORMAT, NOINIT,  NAME = N'proyecto-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            try {
                
                cm = new SqlCommand(copia,cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Se realizo la copia de seguridad con exito");
                this.timer1.Stop();
                this.progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro fallos en: "+ex.ToString());
            }

        }

        public void restaurar()
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string k = openFileDialog1.FileName;
                string a1 = "ALTER DATABASE proyecto SET  SINGLE_USER WITH ROLLBACK IMMEDIATE";
                string a2 = "DROP DATABASE proyecto";
                string a3 = "RESTORE DATABASE proyecto FROM  DISK = N'" + k + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5";




                try
                {
                    this.timer1.Start();
                    
                    cm = new SqlCommand("use master", cn);
                    cm2 = new SqlCommand(a2, cn);
                    cm3 = new SqlCommand(a3, cn);
                    
                    cm.ExecuteNonQuery();
                    cm2.ExecuteNonQuery();
                    cm3.ExecuteNonQuery();
                    
                    MessageBox.Show("Se realizo la restauracion con exito");
                    this.timer1.Stop();
                    this.progressBar1.Value = 0;

                }
                catch (Exception ex)
                {
                    try
                    {
                        this.timer1.Start();

                        cm = new SqlCommand("use master", cn);
                        cm3 = new SqlCommand(a3, cn);

                        cm.ExecuteNonQuery();
                        cm3.ExecuteNonQuery();

                        MessageBox.Show("Se realizo la restauracion con exito");
                        this.timer1.Stop();
                        this.progressBar1.Value = 0;
                    }
                    catch (Exception ea)
                    {
                        try
                        {
                            this.timer1.Start();

                            cm = new SqlCommand("use master", cn);
                            cm2 = new SqlCommand(a1, cn);
                            cm3 = new SqlCommand(a2, cn);
                            cm4 = new SqlCommand(a3, cn);


                            cm.ExecuteNonQuery();
                            cm2.ExecuteNonQuery();
                            cm3.ExecuteNonQuery();
                            cm4.ExecuteNonQuery();


                            MessageBox.Show("Se realizo la restauracion con exito");
                            this.timer1.Stop();
                            this.progressBar1.Value = 0;
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show("Se encontro fallos en: " + ea.ToString());
                            this.timer1.Stop();
                            this.progressBar1.Value = 0;
                        }
                    }
                }
            }
        }
        


        public Backups()
        {
            InitializeComponent();
        }

        private void Backups_Load(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la conexion");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            generarcopia();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            restaurar();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar bar = new ProgressBar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\no tocar");
        }
    }
}
