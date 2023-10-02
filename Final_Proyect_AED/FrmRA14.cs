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
    public partial class FrmRA14 : Form
    {
        public FrmRA14()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        Queue<String> ColaNombre = new Queue<String>();

        void Agregar()
        {
            ColaNombre.Enqueue(txtnombre.Text);
            txtnombre.Clear();
            txtnombre.Focus();

            lbimprimir1.Items.Clear();
            foreach (var Elemento in ColaNombre)
            {
                lbimprimir1.Items.Add(Elemento);
                lbimprimir1.Items.Add("__________");
            }
        }
        
        private void btnenqueue_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Agregar();
            }
        }

        private void rbcopy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcopy.Checked == true)
            {
                lbimprimir2.Items.Clear();
                foreach (var Elemento in ColaNombre)
                {
                    lbimprimir2.Items.Add(Elemento);
                    lbimprimir2.Items.Add("__________");
                }
            }
        }

        private void rbdequeue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdequeue.Checked == true)
            {
                lbimprimir3.Items.Add("Primer elemento de la cola: " + ColaNombre.Dequeue());
                lbimprimir2.Items.Clear();
                foreach (var Elemento in ColaNombre)
                {
                    lbimprimir2.Items.Add(Elemento);
                    lbimprimir2.Items.Add("__________");
                }
                rbdequeue.Checked = false;
            }
        }

        private void rbpeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbpeek.Checked == true)
            {
                lbimprimir3.Items.Add("Primer elemento de la cola: " + ColaNombre.Peek());
                lbimprimir2.Items.Clear();
                foreach (var Elemento in ColaNombre)
                {
                    lbimprimir2.Items.Add(Elemento);
                    lbimprimir2.Items.Add("__________");
                }
                rbdequeue.Checked = false;
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ColaNombre.Contains(txtbuscar.Text) == true)
                {
                    MessageBox.Show("Existe","Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else MessageBox.Show(" No Existe", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Clear();
                txtbuscar.Focus();
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }
    }
}
