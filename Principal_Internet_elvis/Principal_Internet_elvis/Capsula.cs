using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal_Internet_elvis
{
    [Serializable]
    class Capsula
    {
        private List<string> campos = new List<string>();
        private Font fuente;

        public Capsula()
        {
            campos.Clear();
        }

        public void addCampo(string d)
        {
            campos.Add(d);
        }

        public List<string> getCampos()
        {
            return campos;
        }

        public void setFuente(Font f)
        {
            this.fuente = f;
        }

        public Font getFuente()
        {
            return fuente;
        }
    }
}
