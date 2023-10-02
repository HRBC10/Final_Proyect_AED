using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssClientesAA4_Ferreteria
    {
        private int idCliente, telefono;
        private string Nombres, Apellidos, Direccion;

        public List<ClssFacturasAA4_Ferreteria> Facturar { get; set; }

        public ClssClientesAA4_Ferreteria()
        {
            Facturar = new List<ClssFacturasAA4_Ferreteria>();
        }

        public int EOID
        {
            set { idCliente = value; }
            get { return idCliente; }
        }
        public string EONombres
        {
            set { Nombres = value; }
            get { return Nombres; }
        }

        public string EOApellidos
        {
            set { Apellidos = value; }
            get { return Apellidos; }
        }

        public int EOTelefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string EODireccion
        {
            set { Direccion = value; }
            get { return Direccion; }
        }
    }
}
