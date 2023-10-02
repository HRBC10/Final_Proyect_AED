using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssDocenteRA9:ClssPersonaRA9
    {
        private string Facultad;
        private double Salario;
        List<string> Facultades = new List<string>();
        public string EOFacultad
        {
            set { Facultad = value; }
            get { return Facultad; }
        }
        public double EOSalario
        {
            set { Salario = value; }
            get { return Salario; }
        }
        public ClssDocenteRA9()
        {
            Facultades.Add("FEC");
            Facultades.Add("FIQ");
            Facultades.Add("FARQ");
            Facultades.Add("FIT");
            Facultades.Add("FTC");
        }
        public List<string> OFacultades()
        {
            return Facultades;
        }
    }
}
