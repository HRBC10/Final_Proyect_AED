using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proyect_AED
{
    class ClssProductoRA10
    {
        private int Id;
        private string Descripcion;
        private double Precio;
        private double Costo;
        private int SMaximo;
        private int SMinimo;
        private int Existencia;

        public int EOID
        {
            set { Id = value; }
            get { return Id; }
        }
        public string EODescripcion
        {
            set { Descripcion = value; }
            get { return Descripcion; }
        }
        public double EOPrecio
        {
            set { Precio = value; }
            get { return Precio; }
        }
        public double EOCosto
        {
            set { Costo = value; }
            get { return Costo; }
        }
        public int EOSMinimo
        {
            set { SMinimo = value; }
            get { return SMinimo; }
        }
        public int EOSMaximo
        {
            set { SMaximo = value; }
            get { return SMaximo; }
        }
        public int EOExistencia
        {
            set { Existencia = value; }
            get { return Existencia; }
        }

        public string CalcularPrecio(double Costo, double Porcentaje)
        {
            double ganancia;
            ganancia = Costo * Porcentaje * 0.01;
            Precio = Costo + ganancia;
            return Convert.ToString(Precio);
        }
    }
}
