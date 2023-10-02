using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssPersonaRA7
    {
        private string Nombre;
        private string Apellido;
        private int Telefono;
        private int Año;

        public string EONombres
        {
            set { Nombre = value; }
            get { return Nombre; }
        }

        public string EOApellidos
        {
            set { Apellido = value; }
            get { return Apellido; }
        }

        public int EOTelefono
        {
            set { Telefono = value; }
            get { return Telefono; }
        }

        public int EOAño
        {
            set { Año = value; }
            //  get { return Año; }
        }

        public int EOEdad
        {
            get { return DateTime.Now.Year - Año; }
        }
    }
}
