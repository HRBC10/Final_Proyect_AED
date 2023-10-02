using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proyect_AED
{
    public partial class FrmPrograma : Form
    {
        public FrmPrograma()
        {
            InitializeComponent();
        }

        int Tam,N;
        int[] array;

        private void FrmPrograma_Load(object sender, EventArgs e)
        {

        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if (txtEstablecer.Text != "")
            {
                Tam = int.Parse(txtEstablecer.Text);
                array = new int[Tam];
                MessageBox.Show("Cantidad De Elementos Establecida", "Actualización",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                N = 0;
            }
            else
            {
                MessageBox.Show("Caja De Texto Vacia, Ingrese un valor","Validación",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text != "")
            {
                if (N <= Tam - 1)
                {
                    array[N] = int.Parse(txtNumeros.Text);
                    N++;
                    txtNumeros.Text = "";
                }
                else
                {
                    MessageBox.Show("Cantidad De Elementos Maxima Alcanzada", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNumeros.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Caja De Texto Vacia, Ingrese un valor", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            mostrarArray(array,0);
        }

        private void btnMostrarInvertido_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            InvertirArray(array,0,array.Length - 1);
            for(int i =0;i < N; i++)
            {
                lbImprimir.Items.Add(array[i]);
            }
        }

        public int InvertirArray(int[]array,int indice,int N)
        {
            if(indice > N)
            {
                return 1;
            }
            int aux = array[indice];
            array[indice] = array[N];
            array[N] = aux;
            return InvertirArray(array,indice + 1,N - 1);

        }

        private void pbPregunta_Click(object sender, EventArgs e)
        {
            if (pnPregunta.Width == 170) //Comparacion
            {
                pnPregunta.Width = 10; //Size al Esconder
            }
            else
            {
                pnPregunta.Width = 170; //Size al Mostrar
            }
        }

        private void txtEstablecer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public int mostrarArray(int[] array, int indice)
        {
            if (indice >= array.Length)
            {
                return 1;
            }
            lbImprimir.Items.Add(array[indice]);
            return mostrarArray(array, indice + 1);
        }
    }
}
