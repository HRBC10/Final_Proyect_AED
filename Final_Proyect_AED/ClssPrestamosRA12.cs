using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssPrestamosRA12
    {
        private int id, Plazo;
        double Monto;
        DateTime Fechapago;
        string Estado;
        public int EOID
        {
            set { id = value; }
            get { return id; }
        }

        public int EOPlazo
        {
            set { Plazo = value; }
            get { return Plazo; }
        }

        public double EOMonto
        {
            set { Monto = value; }
            get { return Monto; }
        }

        public string EOEstado
        {
            set { Estado = value; }
            get { return Estado; }
        }

        public DateTime EOFecha
        {
            set { Fechapago = value; }
            get { return Fechapago; }
        }
    }
}
