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
    public partial class FrmAA7_EjecucionBusquedaSecuencial : Form
    {
        public FrmAA7_EjecucionBusquedaSecuencial()
        {
            InitializeComponent();
        }
        int[] Array_Desordenado, Array_Ordenado;
        int N = 0;
        bool Band;

        void Agregar(int x) //  Funcion para agregar
        {
            Array.Resize(ref Array_Desordenado, N + 1);
            Array.Resize(ref Array_Ordenado, N + 1);
            Array_Desordenado[N] = x;
            Array_Ordenado[N] = x;
            lbNumeros.Items.Add(x);
            lbDesordanado.Items.Add(x);
            txtNum.Text = "";
            txtNum.Focus();
            N = N + 1;
        }

        void Analisis_Eficiencia()
        {
            if (N > 0)
            {
                double Cmed = (1 + N) / 2;
                double Cmax = N;

                label11.Text = "1";
                label12.Text = Cmed.ToString();
                label13.Text = Cmax.ToString();
            }
            else
            {
                label11.Text = "...";
                label12.Text = "...";
                label13.Text = "...";
            }
        }
        void Ordenar()  //  Funcaion para Ordenar el arreglo 
        {
            int aux;
            int i;

            //  Metodo de burbuja menor
            for (i = 0; i < N - 1; i++)
            {
                for (int j = N - 1; j > 0; j--)
                {
                    if (Array_Ordenado[j - 1] > Array_Ordenado[j])
                    {
                        aux = Array_Ordenado[j - 1];
                        Array_Ordenado[j - 1] = Array_Ordenado[j];
                        Array_Ordenado[j] = aux;
                    }
                }
            }

            lbOrdenado.Items.Clear();

            for (i = 0; i < N; i++)
            {
                lbOrdenado.Items.Add(Array_Ordenado[i]);
            }
        }

        void Buscar_Iterativo_desordenado(int x)    //  Funcion Busqueda Iterativa Desordenado
        {
            int z = 0;

            while (z < N && Array_Desordenado[z] != x)
            {
                z = z + 1;
            }

            if (z >= N)
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + x + ", no se encuentra en el arreglo.";
                txtBusqueda.Clear();
            }
            else
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + x + ", se encuentra en la posición: " + z;
                txtBusqueda.Clear();
            }
        }

        void Buscar_Iterativo_Ordenado(int x)   //  Funcion Busqueda Iterativa Ordenado
        {
            int i = 0;

            while (i < N && x > Array_Ordenado[i])
            {
                i = i + 1;
            }

            if (i >= N || x < Array_Ordenado[i])
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + x + ", no se encuentra en el arreglo.";
                txtBusqueda.Clear();
            }
            else
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + x + ", se encuentra en la posición: " + i;
                txtBusqueda.Clear();
            }
        }

        void Buscar_Recursivo_Desordenado(int x, int i)  //  Funcion Busqueda Recursiva Desordenada
        {
            if (i >= N)
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + x + ", no se encuentra en el arreglo.";
                txtBusqueda.Clear();
            }
            else
            {
                if (Array_Desordenado[i] == x)
                {
                    lblNotificacion.Text = "El número, cuyo valor es: " + x + ", se encuentra en la posición: " + i;
                    txtBusqueda.Clear();
                }
                else
                {
                    Buscar_Recursivo_Desordenado(x, i + 1);
                }
            }
        }

        void Buscar_Recursivo_Ordenado(int x, int i)    //  Funcion Busqueda Recursiva Ordenado
        {
            if (i < N && x > Array_Ordenado[i])
            {
                Buscar_Recursivo_Ordenado(x, i + 1);
            }
            else
            {
                if (i >= N || x < Array_Ordenado[i])
                {
                    lblNotificacion.Text = "El número, cuyo valor es: " + x + ", no se encuentra en el arreglo.";
                    txtBusqueda.Clear();
                }
                else
                {
                    lblNotificacion.Text = "El número, cuyo valor es: " + x + ", se encuentra en la posición: " + i;
                    txtBusqueda.Clear();
                }
            }
        }

        private void btnBuscarDesordenado_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                if (N > 0)
                {
                    Buscar_Iterativo_desordenado(int.Parse(txtBusqueda.Text));
                    Analisis_Eficiencia();
                }
                else
                {
                    lblNotificacion.Text = "El arreglo se encuentra vacío.";
                    txtBusqueda.Clear();
                }
            }
        }

        private void btnBuscarOrdenado_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                if (N > 0)
                {
                    Buscar_Iterativo_Ordenado(int.Parse(txtBusqueda.Text));
                    Analisis_Eficiencia();
                }
                else
                {
                    lblNotificacion.Text = "El arreglo se encuentra vacío.";
                    txtBusqueda.Clear();
                }
            }
        }

        private void btnRecursivaOrdenado_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                if (N > 0)
                {
                    Buscar_Recursivo_Ordenado(int.Parse(txtBusqueda.Text), 0);
                    Analisis_Eficiencia();
                }
                else
                {
                    lblNotificacion.Text = "El arreglo se encuentra vacío.";
                    txtNum.Clear();
                }
            }
        }

        private void btnIngresarNumeros_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "")  // Validacion para que el campo no este vacio
            {
                int i = 0;

                while (i < N && Array_Desordenado[i] != int.Parse(txtNum.Text)) // Ciclo para buscar valor existente
                {
                    i = i + 1;
                }

                if (i >= N)
                {
                    Band = true;
                }
                else
                {
                    Band = false;
                }

                if (Band == true) // Si no existe el numero se agrega
                {
                    Agregar(int.Parse(txtNum.Text));
                    Ordenar();
                }
                else
                {
                    lblNotificacion.Text = "El número " + txtNum.Text + "fue insertado";
                    txtNum.Text = "";
                }
            }
            else
            {
                lblNotificacion.Text = "Llenar el campo respectivo de inserción.";
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txtNum.Text != "")  // Validacion para que el campo no este vacio
                {
                    int i = 0;

                    while (i < N && Array_Desordenado[i] != int.Parse(txtNum.Text)) // Ciclo para buscar valor existente
                    {
                        i = i + 1;
                    }

                    if (i >= N)
                    {
                        Band = true;
                    }
                    else
                    {
                        Band = false;
                    }

                    if (Band == true) // Si no existe el numero se agrega
                    {
                        Agregar(int.Parse(txtNum.Text));
                        Ordenar();
                    }
                    else
                    {
                        lblNotificacion.Text = "El número " + txtNum.Text + " ya fue insertado";
                        txtNum.Text = "";
                    }
                }
                else
                {
                    lblNotificacion.Text = "Llenar el campo respectivo de inserción.";
                }
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRecursivaDesordenado_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                if (N > 0)
                {
                    Buscar_Recursivo_Desordenado(int.Parse(txtBusqueda.Text), 0);
                    Analisis_Eficiencia();
                }
                else
                {
                    lblNotificacion.Text = "El arreglo se encuentra vacío.";
                    txtBusqueda.Clear();
                }
            }
        }
    }
}
