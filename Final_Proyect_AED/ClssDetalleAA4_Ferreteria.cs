using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssDetalleAA4_Ferreteria
    {
        private int FidProducto, FidItem, Nfactura, FidCliente;
        private string Fdescripcion;
        private decimal Cantidad, Descuento, Precio, Total;

        public int EOIDItem
        {
            set { FidItem = value; }
            get { return FidItem; }
        }
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

        public int EOIDProducto
        {
            set { FidProducto = value; }
            get { return FidProducto; }
        }

        public string EODescripcion
        {
            set { Fdescripcion = value; }
            get { return Fdescripcion; }
        }

        public decimal EOCantidad
        {
            set { Cantidad = value; }
            get { return Cantidad; }
        }
        public decimal EODescuento
        {
            set { Descuento = value; }
            get { return Descuento; }
        }

        public decimal EOPrecio
        {
            set { Precio = value; }
            get { return Precio; }
        }

        public decimal EOTotal
        {
            set { Total = value; }
            get { return Total; }
        }
    }
}
