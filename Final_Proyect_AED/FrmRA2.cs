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
    public partial class FrmRA2 : Form
    {
        public FrmRA2()
        {
            InitializeComponent();
        }

        FrmMenu Volver;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                int Numero, i, Suma;
                Numero = int.Parse(txtNumero.Text);
                Suma = 0;
                lbimprimir.Items.Clear();
                for (i = 0; i <= Numero; i++)
                {
                    lbimprimir.Items.Add(Convert.ToString(i));
                    Suma = Suma + i;
                }
                txtNumero.Text = string.Empty;
                txtSuma.Text = Convert.ToString(Suma);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }
    }
}
