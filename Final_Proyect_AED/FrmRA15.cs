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
    public partial class FrmRA15 : Form
    {
        public FrmRA15()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        //Declaraciones Globales
        int[] Numeros;
        int aux, N = 0;

        //Función ImprimirA
        void ImprimirA(string Metodo)
        {
            string Cadena = "";
            for (int i = 0; i < N; i++)
            {
                Cadena += Numeros[i] + " ";
            }
            lbOrdenados.Items.Add(Metodo + " -> " + Cadena);
        }

        //Función Imprimir1 Menores
        void Imprimir1()
        {
            for (int i = 0; i < N; i++)
            {
                txtMenor.Text = txtMenor.Text + Numeros[i] + "";
            }
            txtMenor.Text = txtMenor.Text + "\r\n";
        }

        //Función Imprimir2 para imprimir Mayores
        void Imprimir2()
        {
            for (int i = 0; i < N; i++)
            {
                txtMayor.Text = txtMayor.Text + Numeros[i] + "";
            }
            txtMayor.Text = txtMayor.Text + "\r\n";
        }

        //Función Imprimir3 para imprimir por Señal
        void Imprimir3()
        {
            for (int i = 0; i < N; i++)
            {
                txtSeñal.Text = txtSeñal.Text + Numeros[i] + "";
            }
            txtSeñal.Text = txtSeñal.Text + "\r\n";
        }

        void Imprimir4()
        {
            for (int i = 0; i < N; i++)
            {
                txtSacudida.Text = txtSacudida.Text + (Numeros[i] + " ");
            }
            txtSacudida.Text = txtSacudida.Text + "\r\n";
        }
        void Imprimir5()
        {
            for (int i = 0; i < N; i++)
            {
                txtDirecta.Text = txtDirecta.Text + (Numeros[i] + " ");
            }
            txtDirecta.Text = txtDirecta.Text + "\r\n";
        }
        void Imprimir6()
        {
            for (int i = 0; i < N; i++)
            {
                txtShell.Text = txtShell.Text + (Numeros[i] + " ");
            }
            txtShell.Text = txtShell.Text + "\r\n";
        }

        //Evento click del item Mayor
        private void mayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }

            Imprimir2();

            for (i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Numeros[j] > Numeros[j + 1])
                    {
                        aux = Numeros[j];
                        Numeros[j] = Numeros[j + 1];
                        Numeros[j + 1] = aux;
                    }
                }
                Imprimir2();
            }
            ImprimirA("Burbuja Mayor");
        }

        //Evento click del item Con Señal
        private void conSeñalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool Band = false;

            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }

            Imprimir3();
            i = 0;

            while (i < N - 1 && Band == false)
            {
                Band = true;

                for (int j = 0; j < N - 1; j++)
                {
                    if (Numeros[j] > Numeros[j + 1])
                    {
                        aux = Numeros[j];
                        Numeros[j] = Numeros[j + 1];
                        Numeros[j + 1] = aux;
                        Band = false;
                    }
                }
                Imprimir3();
                i = i + 1;
            }
            ImprimirA("Señal");
        }

        private void shakerSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intercambios = 0, Comparaciones = 0;
            int i = 0, izq, der, k, aux;
            izq = 1;
            der = Numeros.Length - 1;
            k = Numeros.Length - 1;

            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }
            while (izq <= der)
            {
                for (i = der; i >= izq; i--)
                {
                    Comparaciones++;
                    if (Numeros[i - 1] > Numeros[i])
                    {
                        intercambios++;
                        aux = Numeros[i - 1];
                        Numeros[i - 1] = Numeros[i];
                        Numeros[i] = aux;
                        k = i;
                    }
                }
                izq = k + 1;

                for (i = izq; i <= der; i++)
                {
                    Comparaciones++;
                    if (Numeros[i - 1] > Numeros[i])
                    {
                        intercambios++;
                        aux = Numeros[i - 1];
                        Numeros[i - 1] = Numeros[i];
                        Numeros[i] = aux;
                        k = i;
                    }
                }
                der = k - 1;
                Imprimir4();
            }
            ImprimirA("Sacudidad");
        }

        private void inserciónDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0, j;
            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }
            for (i = 1; i < Numeros.Length; i++)
            {
                aux = Numeros[i];
                j = i - 1;
                while ((j >= 0) && (aux < Numeros[j]))
                {
                    Numeros[j + 1] = Numeros[j];
                    j--;
                }
                Numeros[j + 1] = aux;
                Imprimir5();
            }
            ImprimirA("Inserccion Directa");
        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int inta, i, aux;
            bool band;
            inta = Numeros.Length;
            while (inta > 0)
            {
                inta = inta / 2;
                band = true;
                while (band)
                {
                    band = false;
                    i = 0;
                    while ((i + inta) <= Numeros.Length - 1)
                    {
                        if (Numeros[i] > Numeros[i + inta])
                        {
                            aux = Numeros[i];
                            Numeros[i] = Numeros[i + inta];
                            Numeros[i + inta] = aux;
                            band = true;
                        }
                        i++;
                    }
                }
                Imprimir6();
            }
            ImprimirA("Shell");
        }

        //Evento click del item Menor
        private void menorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }

            for (i = 0; i < N - 1; i++)
            {
                for (int j = N - 1; j > 0; j--)
                {
                    if (Numeros[j - 1] > Numeros[j])
                    {
                        aux = Numeros[j - 1];
                        Numeros[j - 1] = Numeros[j];
                        Numeros[j] = aux;
                    }
                }
                Imprimir1();
            }
            ImprimirA("Burbuja Menor");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Array.Resize(ref Numeros, N + 1);
                int Num = int.Parse(txtNumero.Text);
                Numeros[N] = Num;
                lbNumeros.Items.Add(Num);
                txtNumero.Text = "";
                txtNumero.Focus();
                N = N + 1;
            }
        }
    }
}
