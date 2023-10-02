using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssProductosAA4_Ferreteria
    {
        private int idProducto, Existencia, STMimimo, STMaximo;
        private decimal costo, PUnitario, PMayorista;
        private string descripcion;

        public int EOIDProducto
        {
            set { idProducto = value; }
            get { return idProducto; }
        }

        public string EODescripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public decimal EOCosto
        {
            set { costo = value; }
            get { return costo; }
        }

        public decimal EOPUnitario
        {
            set { PUnitario = value; }
            get { return PUnitario; }
        }

        public decimal EOPMayorista
        {
            set { PMayorista = value; }
            get { return PMayorista; }
        }

        public int EOExistencia
        {
            set { Existencia = value; }
            get { return Existencia; }
        }

        public int EOSTMimimo
        {
            set { STMimimo = value; }
            get { return STMimimo; }
        }

        public int EOSTMaximo
        {
            set { STMaximo = value; }
            get { return STMaximo; }
        }
    }
}
