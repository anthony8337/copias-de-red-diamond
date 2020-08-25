using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis.Configuraciones
{
    public partial class ConfiguracionLogo : Form
    {
        private Byte[] file = null;
        public ConfiguracionLogo()
        {
            InitializeComponent();
        }

        private void bt_logo_Click(object sender, EventArgs e)
        {
            pfd_logo.InitialDirectory = "c:\\";
            pfd_logo.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png|Archivos jpeg (*.jpeg)|*.jpeg";
            pfd_logo.FilterIndex = 1;
            pfd_logo.RestoreDirectory = true;
            if(pfd_logo.ShowDialog() == DialogResult.OK)
            {
                txt_logo.Text = pfd_logo.FileName;

                pb_logo.Image = Image.FromFile(pfd_logo.FileName);
            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        { }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfiguracionLogo_Load(object sender, EventArgs e)
        { }

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

            foreach (DateTimePicker e in Program.GetAllChildren(this).OfType<DateTimePicker>())
            {
                e.Font = f;
            }
        }
    }
}
