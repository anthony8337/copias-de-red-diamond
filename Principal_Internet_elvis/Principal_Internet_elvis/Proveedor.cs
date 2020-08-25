using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            rb_activado.Checked = true;

            if (rb_activado.Checked == true)
            {
                rb_desactivado.Checked = false;
            }
            else
            {
                rb_activado.Checked = false;
            }
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
