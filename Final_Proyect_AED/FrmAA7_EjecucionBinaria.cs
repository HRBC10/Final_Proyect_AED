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
    public partial class FrmAA7_EjecucionBinaria : Form
    {
        public FrmAA7_EjecucionBinaria()
        {
            InitializeComponent();
        }

        int[] arreglo;
        int N = 0;
        bool Bandera;

        void Agregar(int x) //  Funcion para agregar
        {
            Array.Resize(ref arreglo, N + 1);
            arreglo[N] = x;
            lbNumeros.Items.Add(x);
            txtNum.Text = "";
            txtNum.Focus();
            N = N + 1;
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
                    if (arreglo[j - 1] > arreglo[j])
                    {
                        aux = arreglo[j - 1];
                        arreglo[j - 1] = arreglo[j];
                        arreglo[j] = aux;
                    }
                }
            }

            lbOrdenado.Items.Clear();

            for (i = 0; i < N; i++)
            {
                lbOrdenado.Items.Add(arreglo[i]);
            }
        }

        void Binaria(int X) //  Funcion Busqueda Binaria con Bandera
        {
            int IZQ, CEN, DER;
            bool BAN;

            IZQ = 0;
            DER = arreglo.Length - 1;
            BAN = false;

            CEN = ((IZQ + DER) / 2);

            while (IZQ <= DER && BAN == false)
            {
                CEN = ((IZQ + DER) / 2);

                if (X == arreglo[CEN])
                {
                    BAN = true;
                }
                else
                {
                    if (X > arreglo[CEN])
                    {
                        IZQ = CEN + 1;
                    }
                    else
                    {
                        DER = CEN - 1;
                    }
                }
            }

            if (BAN == true)
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + txtBusqueda.Text + ", se encuentra en la posición: " + CEN;
            }
            else
            {
                lblNotificacion.Text = "El número, cuyo valor es: " + txtBusqueda.Text + ", no se encuentra en el arreglo.";
            }
        }

        void Binario_sin_bandera(int x) //  Funcion Busqueda Binaria sin Bandera
        {
            int IZQ, DER, CEN;

            IZQ = 0;
            DER = N - 1;
            CEN = ((IZQ + DER) / 2);

            while (IZQ <= DER && x != arreglo[CEN])
            {
                if (x > arreglo[CEN])
                {
                    IZQ = CEN + 1;
                }
                else
                {
                    DER = CEN - 1;
                }
                CEN = ((IZQ + DER) / 2);
            }

            if (IZQ > DER)
            {
                lblNotificacion.Text = "El numero " + txtBusqueda.Text + ", no se encuentra en el arreglo.";
            }
            else
            {
                lblNotificacion.Text = "El numero " + txtBusqueda.Text + ", se encuentra en la posición: " + CEN;
            }
        }

        void Binario_Rcursivo(int IZQ, int DER, int X)
        {
            int CEN;

            if (IZQ > DER)
            {
                lblNotificacion.Text = "El numero " + X + ", no se encuentra en el arreglo.";
            }
            else
            {
                CEN = ((IZQ + DER) / 2);

                if (X == arreglo[CEN])
                {
                    lblNotificacion.Text = "El El numero" + X + ", se encuentra en la posición: " + CEN;
                }
                else
                {
                    if (X > arreglo[CEN])
                    {
                        Binario_Rcursivo(CEN + 1, DER, X);
                    }
                    else
                    {
                        Binario_Rcursivo(IZQ, CEN - 1, X);
                    }
                }
            }
        }

        void Analisis_Eficiencia()
        {
            if (N > 0)
            {
                double Cmed = (1 + Math.Log(N, 2) / 2);
                double Cmax = Math.Log(N, 2);

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

        private void btnIngresarNumeros_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "")  // Validacion para que el campo no este vacio
            {
                int i = 0;

                while (i < N && arreglo[i] != int.Parse(txtNum.Text)) // Ciclo para buscar valor existente
                {
                    i = i + 1;
                }

                if (i >= N)
                {
                    Bandera = true;
                }
                else
                {
                    Bandera = false;
                }

                if (Bandera == true) // Si no existe el numero se agrega
                {
                    Agregar(int.Parse(txtNum.Text));
                    Ordenar();
                }
                else
                {
                    lblNotificacion.Text = "EL numero " + txtNum.Text + "fue insertado";
                    txtNum.Text = "";
                }
            }
            else
            {
                lblNotificacion.Text = "Llenar el campo respectivo de inserción.";
            }
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            if(txtBusqueda.Text == string.Empty)
            {
                lblNotificacion.Text = "Campo Vacio";
            }
            else
            {
                Binaria(int.Parse(txtBusqueda.Text));
                Analisis_Eficiencia();
            }
        }

        private void btnBinariaSinbandera_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == string.Empty)
            {
                lblNotificacion.Text = "Campo Vacio";
            }
            else
            {
                Binario_sin_bandera(int.Parse(txtBusqueda.Text));
                Analisis_Eficiencia();
            }
        }

        private void btnBinariaRecursiva_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == string.Empty)
            {
                lblNotificacion.Text = "Campo Vacio";
            }
            else
            {
                Binario_Rcursivo(0, N - 1, int.Parse(txtBusqueda.Text));
                Analisis_Eficiencia();
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

                    while (i < N && arreglo[i] != int.Parse(txtNum.Text)) // Ciclo para buscar valor existente
                    {
                        i = i + 1;
                    }

                    if (i >= N)
                    {
                        Bandera = true;
                    }
                    else
                    {
                        Bandera = false;
                    }

                    if (Bandera == true) // Si no existe el numero se agrega
                    {
                        Agregar(int.Parse(txtNum.Text));
                        Ordenar();
                    }
                    else
                    {
                        lblNotificacion.Text = "El número " + txtNum.Text + " ya fue insertado, por lo tanto, debe insertar un nuevo número.";
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
    }
}
