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
    public partial class FrmAA5_Caja : Form
    {
        public FrmAA5_Caja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {

        }

        public void Agregar()
        {
            if(ClssModulo.ClienteCaja.Count >0)
            {
                lbImprimirFilaCajaSiguiente.Items.Clear();
                lbImprimirFilaCajaSiguiente.Items.Add("------------------------------------------------------------------------------------------");
                lbImprimirFilaCajaSiguiente.Items.Add(ClssModulo.ClienteCaja.Peek());
                lbImprimirFilaCajaSiguiente.Items.Add("------------------------------------------------------------------------------------------");
            }
            else
            {
                lbImprimirFilaCajaSiguiente.Items.Clear();
            }
        }

        private void BtnSigEnLista_Click(object sender, EventArgs e)
        {
            lbImprimirFilaCajaSiguiente.Items.Clear();
            if (ClssModulo.ClienteCaja.Count > 0)
            {
                ClssModulo.ClienteCaja.Dequeue();
            }
            else
            {
                MessageBox.Show("No Hay Elementos en la Cola", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Agregar();
        }

    }
}
