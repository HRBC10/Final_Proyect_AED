using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssFacturasAA4_Ferreteria
    {
        private int FidCliente;
        private string FNombres, FApellidos;
        private int Nfactura;
        private decimal TotalFactura;
        private DateTime fecha;

        public int EOIDFactura
        {
            set { Nfactura = value; }
            get { return Nfactura; }
        }
        public int EOID
        {
            set { FidCliente = value; }
            get { return FidCliente; }
        }

        public string EONombres
        {
            set { FNombres = value; }
            get { return FNombres; }
        }

        public string EOApellidos
        {
            set { FApellidos = value; }
            get { return FApellidos; }
        }

        public DateTime EOFecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public decimal EOTotalFactura
        {
            set { TotalFactura = value; }
            get { return TotalFactura; }
        }
    }
}
