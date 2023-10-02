using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssNodoAA3
    {
        public int dato { get; set; }
        public ClssNodoAA3 izquierdo { get; set; }
        public ClssNodoAA3 derecho { get; set; }

        public ClssNodoAA3(int dato)
        {
            this.dato = dato;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}
