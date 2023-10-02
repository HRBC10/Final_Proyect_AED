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
    public partial class FrmRA8 : Form
    {
        public FrmRA8()
        {
            InitializeComponent();
        }

        FrmMenu Volver;
        int res = 1, ff;

        public int Fact(int n)
        {
            if (n == 0)
            {
                res = 1;
                return res;
            }
            else
            {
                ff = Fact(n - 1);
                res = n * ff;
                lbImprimir.Items.Add(Convert.ToString(n) + "x fact(" + Convert.ToString(n - 1) + ") ---> " + n + " x" + ff + " = " + res);
                return res;
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
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
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio","Validación",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int num;
                lbImprimir.Items.Clear();
                num = int.Parse(txtNumero.Text);
                txtResultado.Text = Convert.ToString(Fact(num));
            }    
        }
    }
}
