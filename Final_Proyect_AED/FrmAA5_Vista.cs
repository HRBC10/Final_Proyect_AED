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
    public partial class FrmVista : Form
    {
        public FrmVista()
        {
            InitializeComponent();
        }

        public void AgregarVista()
        {
            if(ClssModulo.ClienteServicioBancario.Count > 0)
            {
                txtVerSBancarios.Text = ClssModulo.ClienteServicioBancario.Peek();
            }
            else
            {
                txtVerSBancarios.Text = "";
            }
            if (ClssModulo.ClienteCaja.Count > 0)
            {
                txtVerCaja.Text = ClssModulo.ClienteCaja.Peek();
            }
            else
            {
                txtVerCaja.Text = "";
            }

            lbImprimirFilaCaja.Items.Clear();
            foreach (var ImprimirCaja in ClssModulo.ClienteCaja)
            {
                lbImprimirFilaCaja.Items.Add("-----------------------------------------------------------------------------");
                lbImprimirFilaCaja.Items.Add(ImprimirCaja);
                lbImprimirFilaCaja.Items.Add("-----------------------------------------------------------------------------");


            }

            lbImprimirFilaSBancarios.Items.Clear();
            foreach (var ImprimirSBancarios in ClssModulo.ClienteServicioBancario)
            {
                lbImprimirFilaSBancarios.Items.Add("-----------------------------------------------------------------------------");
                lbImprimirFilaSBancarios.Items.Add(ImprimirSBancarios);
                lbImprimirFilaSBancarios.Items.Add("-----------------------------------------------------------------------------");
            }
        }

        private void FrmVista_Load(object sender, EventArgs e)
        {
           
        }

        private void lbImprimirFilaCaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
