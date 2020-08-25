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
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void Socios_Load(object sender, EventArgs e)
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
