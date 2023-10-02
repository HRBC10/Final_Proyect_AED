using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssPersonaRA9
    {
        private string Nombres;
        private string Apellidos;
        private int Telefono;
        private int Año;
        private int Edad;

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
            set { Telefono = value; }
            get { return Telefono; }
        }
        public int EOAño
        {
            set { Año = value; }
        }
        public int EOEdad
        {
            get { return Edad = DateTime.Now.Year - Año; }
        }
    }
}
