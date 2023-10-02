using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proyect_AED
{
    public partial class FrmCodigo : Form
    {
        public FrmCodigo()
        {
            InitializeComponent();
        }
        
        private void btnMEstablecer_Click(object sender, EventArgs e)
        {
            lbTitulo.Text = "Codigo De botón Establecer";
            lbTexto.Text = " Esta función sirve para establecer la cantidad de elementos " +
            "que el usuario ingresara,\n" +
            "en otras palabras sirve para establecer el tamaño del array\n\n" +
            "Una vez Establecida la cantidad, se enviara un mesnaje de validación.";
           
        }

        private void btnMAgregar_Click(object sender, EventArgs e)
        {
            lbTitulo.Text = "Codigo De botón Agregar";
            lbTexto.Text = " Esta función sirve para Agregar cada elemento de tipo " +
            "entero que el usuario ingrese,\n" +
            "de acuerdo a la cantidad establecida en la función de establecer.\n\n" +
            "Si el usuario ingresa mas elementos que la cantidad establecida, " +
            "el programa enviara un mensaje de validación.";
        }

        private void btnMMostrar_Click(object sender, EventArgs e)
        {

            lbTitulo.Text = "Codigo De botón Mostrar";
            lbTexto.Text = " Esta función llama a la funcion de recursividad MostrarArray,\n" +
                "a esta función se le manda el array y el indice, que en este caso es 0\n\n" +
                "La función manda a imprimir el arreglo de manera en que se ingresarón los datos";

        }

        private void btnMMInvertido_Click(object sender, EventArgs e)
        {
           
            lbTitulo.Text = "Codigo De botón Mostrar Invertido";
            lbTexto.Text = " Esta funcion llama a la función de recursividad InvertirArray,\n" +
            "a esta función se le manda el array,el indice y el tamaño del arreglo,\n\n" +
             "Para mandar a Imprimir se ocupa el ciclo for.";
        }

        private void btnMMRecursividad_Click(object sender, EventArgs e)
        {
            lbTitulo.Text = "Función Recursividad MostrarArray";
            lbTexto.Text = "La condición establece que Si el indice " +
            "es mayor o igual al tamaño del arreglo,\n" +
            "que retorne 1, si no, que imprima el arreglo y que retorne la función";
        }

        private void btnMMIRecursividad_Click(object sender, EventArgs e)
        {

            lbTitulo.Text = "Función Recursividad InvertirArray";
            lbTexto.Text = " La condición establece que Si el indice" +
            " es mayor o igual al tamaño del arreglo,\n" +
            "que retorne 1, si no, reasingar el array de manera que se " +
            "logre invertirlo, luego retornar la función";
        }
        private void FrmCodigocs_Load(object sender, EventArgs e)
        {
            
        }
    }
}
