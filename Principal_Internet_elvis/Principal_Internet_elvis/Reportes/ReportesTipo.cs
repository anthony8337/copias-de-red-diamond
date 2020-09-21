using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Reportes
{
    public partial class ReportesTipo : Form
    {
        public ReportesTipo()
        {
            InitializeComponent();
        }

        public void limpiar()
        {

            rb_barrio.Checked = true;
            r_cli_a.Checked = true;
            txt_cliente.Text = "";
            cb_rango.Checked = false;
            rb_servicio.Checked = true;
            txt_nombre_sector.Text = "";

        }

        private void ReportesTipo_Resize(object sender, EventArgs e)
        {
            vgb_tabla.Left = this.Width - (vgb_tabla.Width + 25);
            vgb_tabla.Top = this.Height - (vgb_tabla.Height + 50);
        }

        private void ReportesTipo_Load(object sender, EventArgs e)
        {

        }
    }
}
