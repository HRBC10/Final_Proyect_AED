using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssProductoRA6
    {
        private int Id;
        private string Descripcion;
        private double Precio;
        private double Costo;
        private int SMaximo;
        private int SMinimo;
        private int Existencia;

        public int EOId
        {
            set { Id = value; }
            get { return Id; }
        }

        public string EODescripcion
        {
            set { Descripcion = value; }
            get { return Descripcion; }
        }

        public double EOCosto
        {
            set { Costo = value; }
            get { return Costo; }
        }

        public double EOPrecio
        {
            set { Precio = value; }
            get { return Precio; }
        }

        public int EOSMaximo
        {
            set { SMaximo = value; }
            get { return SMaximo; }
        }

        public int EOSMinimo
        {
            set { SMinimo = value; }
            get { return SMinimo; }
        }

        public int EOExistencia
        {
            set { Existencia = value; }
            get { return Existencia; }
        }

        public string CalcularPrecio(double Costo, double Porcentaje)
        {
            double Ganancia;
            Ganancia = Costo * Porcentaje * 0.01;
            Precio = Costo + Ganancia;
            return Convert.ToString(Precio);
        }
    }
}
