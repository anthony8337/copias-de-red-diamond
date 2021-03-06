﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Principal_Internet_elvis.Paquetes
{
    public partial class PaquetesElegir : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=proyecto;Integrated Security=True");
        SqlCommand cm;
        public int idpaquete;

        public PaquetesElegir()
        {
            InitializeComponent();
        }


        public void agregar_pc()
        {
            try
            {
                cm = new SqlCommand("INSERT INTO ClientePaquete(idcliente,idpaquete,estado) VALUES (@idcliente, @idpaquete, @estado)", cn);
                cm.Parameters.AddWithValue("@idcliente", ClientesCarpeta.ClientesPaquetes.idregistro);
                cm.Parameters.AddWithValue("@idpaquete", idpaquete);
                cm.Parameters.AddWithValue("@estado", "DESACTIVADO");
                cm.ExecuteNonQuery();
                MessageBox.Show("Paquete registrado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro fallos en: " +ex.ToString());
            }
            
        }

        public void tabla()
        {
            if (Text == "ELEGIR-PAQUETES")
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
            else
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


        }


        public void selecionar()
        {
            try
            {
                if (Text == "ELEGIR EL PRIMER SERVICIO")
                {
                    
                    PaquetesAgregar.P_servicio = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
                }
                else
                {
                    PaquetesAgregar.S_servicio = dgv_tabla.CurrentRow.Cells[1].Value.ToString();
                }

                this.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show("No hay ningun campo seleccionado");
                this.Close();
            }

        }

        private void PaquetesElegir_Load(object sender, EventArgs e)
        {
            cn.Open();
            tabla();
            idpaquete = int.Parse(dgv_tabla.CurrentRow.Cells[0].Value.ToString());
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            if (Text == "ELEGIR-PAQUETES")
            {
                agregar_pc();
                this.Dispose();
            }
            else
            {
                selecionar();
                this.Dispose();
            }
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idpaquete = int.Parse(dgv_tabla.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
