using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssEstudianteRA9:ClssPersonaRA9
    {
        private string Carrera;
        private string Tipobeca;

        public string EOCarrera
        {
            set { Carrera = value; }
            get { return Carrera; }
        }
        public string EOTipobeca
        {
            set { Tipobeca = value; }
            get { return Tipobeca; }
        }
    }
}
