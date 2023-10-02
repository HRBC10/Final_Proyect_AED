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
    public partial class FrmRA13 : Form
    {
        public FrmRA13()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        Stack<String> PilaNombre = new Stack<String>();

        void Agregar()
        {
            PilaNombre.Push(txtingresar.Text);

            lbimprimir.Items.Clear();
            foreach (var item in PilaNombre)
            {
                lbimprimir.Items.Add(item);
                lbimprimir.Items.Add("__________");
            }
            txtingresar.Clear();
            txtingresar.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Copy_CheckedChanged(object sender, EventArgs e)
        {
            if (Copy.Checked == true)
            {
                foreach (var item in PilaNombre)
                {
                    lbimprimir2.Items.Add(item);
                    lbimprimir2.Items.Add("__________");
                }
            }
        }

        private void Pop_CheckedChanged(object sender, EventArgs e)
        {
            if (Pop.Checked == true)
            {
                listBox3.Items.Add("Elemento {0} " + PilaNombre.Pop());
                lbimprimir.Items.Clear();
                foreach (var item in PilaNombre)
                {
                    lbimprimir2.Items.Add(item);
                    lbimprimir2.Items.Add("__________");
                }
                Pop.Checked = false;
            }
        }

        private void Peek_CheckedChanged(object sender, EventArgs e)
        {
            if (Peek.Checked == true)
            {
                listBox3.Items.Add("Elemento {0} " + PilaNombre.Peek());
                lbimprimir.Items.Clear();
                foreach (var item in PilaNombre)
                {
                    lbimprimir2.Items.Add(item);
                    lbimprimir2.Items.Add("__________");
                }

                Peek.Checked = false;
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void txtingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Agregar();
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
