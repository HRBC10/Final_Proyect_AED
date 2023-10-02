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
    public partial class FrmSBancarios : Form
    {
        public FrmSBancarios()
        {
            InitializeComponent();
        }

        private void FrmSBancarios_Load(object sender, EventArgs e)
        {
            Agregar();
        }

        public void Agregar()
        {
            if (ClssModulo.ClienteServicioBancario.Count > 0)
            {
                lbImprimirFilaSBancariosSiguiente.Items.Clear();
                lbImprimirFilaSBancariosSiguiente.Items.Add("------------------------------------------------------------------------------------------");
                lbImprimirFilaSBancariosSiguiente.Items.Add(ClssModulo.ClienteServicioBancario.Peek());
                lbImprimirFilaSBancariosSiguiente.Items.Add("------------------------------------------------------------------------------------------");
            }
            else
            {
                lbImprimirFilaSBancariosSiguiente.Items.Clear();
            }
        }

        private void btnSigEnLista_Click(object sender, EventArgs e)
        {
            lbImprimirFilaSBancariosSiguiente.Items.Clear();
            if(ClssModulo.ClienteServicioBancario.Count > 0)
            {
               ClssModulo.ClienteServicioBancario.Dequeue();   
            }
            else
            {
                MessageBox.Show("No Hay Elementos en la Cola", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Agregar();
        }

    }
}
