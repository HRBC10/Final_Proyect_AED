using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssEmpleadoRA12
    {
        DateTime Fechaingreso;
        private int id, Celular;
        private string Nombres, Apellidos, DNI, Direccion;
        public List<ClssPrestamosRA12> Prestamos { get; set; }
        public ClssEmpleadoRA12()
        {
            Prestamos = new List<ClssPrestamosRA12>();
        }

        public int EOID
        {
            set { id = value; }
            get { return id; }
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

        public string EODNI
        {
            set { DNI = value; }
            get { return DNI; }
        }

        public string EODireccion
        {
            set { Direccion = value; }
            get { return Direccion; }
        }

        public int EOCelular
        {
            set { Celular = value; }
            get { return Celular; }
        }

        public DateTime EOFecha
        {
            set { Fechaingreso = value; }
            get { return Fechaingreso; }
        }
    }
}
