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
    public partial class FrmRA11 : Form
    {
        public FrmRA11()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        int[] Numero;
        int aux, N = 0;

        void Imprimir1()
        {
            for (int i = 0; i < N; i++)
            {
                Txt1.Text = Txt1.Text + Numero[i] + " ";
            }
            Txt1.Text = Txt1.Text + "\r\n";
        }

        void Imprimir2()
        {
            for (int i = 0; i < N; i++)
            {
                Txt2.Text = Txt2.Text + Numero[i] + " ";
            }
            Txt2.Text = Txt2.Text + "\r\n";
        }


        private void BtnOrdenar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = N - 1; j > 0; j--)
                {
                    if (Numero[j - 1] > Numero[j])
                    {
                        aux = Numero[j - 1];
                        Numero[j - 1] = Numero[j];
                        Numero[j] = aux;
                    }
                }
                Imprimir1();
            }
            for (int i = 0; i < N; i++)
            {
                List1.Items.Add(Numero[i]);
            }
        }

        private void TxtImpresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                Array.Resize(ref Numero, N + 1);
                int Num = int.Parse(TxtImpresar.Text);
                Numero[N] = Num;
                ListNumero.Items.Add(Num);
                TxtImpresar.Text = "";
                TxtImpresar.Focus();
                Lbetiqueta.Text = Convert.ToString(Numero.Count()) + " elementos insertados";
                N = N + 1;
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void BtnOrdenar2_Click(object sender, EventArgs e)
        {
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Numero[j] > Numero[j + 1])
                    {
                        aux = Numero[j];
                        Numero[j] = Numero[j + 1];
                        Numero[j + 1] = aux;
                    }
                }
                Imprimir2();
            }
            for (int i = 0; i < N; i++)
            {
                List2.Items.Add(Numero[i]);
            }
        }
    }
}
