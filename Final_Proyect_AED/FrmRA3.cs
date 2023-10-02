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
    public partial class FrmRA3 : Form
    {
        public FrmRA3()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        int N = 0, Tam, i;
        int[] Edad;
        int[] Id;
        string[] Nombres;

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validacion";
            string message = string.Empty;

            if (txtId.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Id";
                MessageBox.Show(message, title);
            }

            if (txtNombre.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (txtEdad.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Edad";
                MessageBox.Show(message, title);
            }

            return flag;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() == true)
            {
                if (N <= Tam - 1)
                {
                    Id[N] = int.Parse(txtId.Text);
                    Edad[N] = int.Parse(txtEdad.Text);
                    Nombres[N] = txtNombre.Text;

                    N = N + 1;
                    MessageBox.Show("Se ingreso el registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Hay Espacio","Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int x;
                x = int.Parse(txtId.Text);
                while (i < N && x != Id[i])
                {
                    i = i + 1;
                }
                if (i >= N)
                {
                    MessageBox.Show(x + " No esta Registrado","Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int k = i; k < N - 1; k++)
                    {
                        Id[k] = Id[k + 1];
                        Nombres[k] = Nombres[k + 1];
                        Edad[k] = Edad[k + 1];

                        N = N - 1;
                        MessageBox.Show("La Persona con Id = " + x + " se ha eliminado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x;
            x = int.Parse(txtId.Text);
            while (i < N && x != Id[i])
            {
                i = i + 1;
            }
            if (i >= N)
            {
                MessageBox.Show(x + " No esta Registrado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id[i] = int.Parse(txtId.Text);
                Edad[i] = int.Parse(txtEdad.Text);
                Nombres[i] = txtNombre.Text;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            for (i = 0; i < N; i++)
            {
                lbImprimir.Items.Add(Id[i] + "\t" + Nombres[i] + "\t\t" + Edad[i]);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int x;
                x = int.Parse(txtId.Text);

                while (i < N && x != Id[i])
                {
                    i = i + 1;
                }
                if (i > N)
                {
                    MessageBox.Show(x + " No esta Registrado","Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add(Id[i] + "\t" + Nombres[i] + "\t" + Edad[i]);
                }
            }
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Tam = int.Parse(txtCantidad.Text);
                Id = new int[Tam];
                Edad = new int[Tam];
                Nombres = new string[Tam];
                N = 0;
                MessageBox.Show("Cantidad De Elementos Establecida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
