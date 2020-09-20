using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Internet_elvis
{
    class letras_numero
    {

        public void sololetra(KeyPressEventArgs e)
        {
                try
                {
                    if (char.IsLetter(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                catch (Exception ex)
                { }
        }

        public void solonumero(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            { }
        }
        }

    }

