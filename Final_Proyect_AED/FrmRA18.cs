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
    public partial class FrmRA18 : Form
    {
        FrmMenu Volver;
        public FrmRA18()
        {
            InitializeComponent();
        }

        int N = 0, Tam, i, Pos, x, x2;
        int[] Edad;
        int[] Id;
        string[] Nombres;
        void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
        }
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
        public int Busca(int x)
        {
            i = 0;
            while (i < N && Id[i] < x)
            {
                i = i + 1;
            }
            if (i >= N || Id[i] > x)
            {
                Pos = -i;
            }
            else
            {
                Pos = i;
            }
            return Pos;
        }
        void Eliminar(int x)
        {
            if (N > 0)
            {
                //x = int.Parse(txtId.Text);
                Pos = Busca(x);
                if (Pos <= -1)
                {
                    MessageBox.Show(x + " No está Registrado");
                }
                else
                {
                    for (i = Pos; i < N - 1; i++)
                    {
                        Id[i] = Id[i + 1];
                        Nombres[i] = Nombres[i + 1];
                        Edad[i] = Edad[i + 1];
                    }
                    N = N - 1;
                    MessageBox.Show("La persona con Id=" + x + " se ha eliminada");
                }
            }
            else
            {
                MessageBox.Show("No hay Registros");
            }
        }
        void Insertar(int x)
        {
            if (N > 0)
            {
                if (N <= Tam - 1)
                {
                    Pos = Busca(x);
                    if (Pos > 0)
                    {
                        MessageBox.Show("El elemento ya existe");
                    }
                    else
                    {

                        Pos = Pos * -1;
                        for (i = N; i >= Pos + 1; i--)
                        {
                            Id[i] = Id[i - 1];
                            Edad[i] = Edad[i - 1];
                            Nombres[i] = Nombres[i - 1];
                        }
                        Id[Pos] = int.Parse(txtId.Text);
                        Edad[Pos] = int.Parse(txtEdad.Text);
                        Nombres[Pos] = txtNombre.Text;
                        N = N + 1;
                        MessageBox.Show("Elemento Insertado");
                    }
                }
                else
                {
                    MessageBox.Show("No hay espacio");
                }
            }
            else
            {
                Id[N] = int.Parse(txtId.Text);
                Edad[N] = int.Parse(txtEdad.Text);
                Nombres[N] = txtNombre.Text;
                N = N + 1;
                MessageBox.Show("Elemento Insertado");
            }
        }

        void Actualizar()
        {
            //Pos = Pos * -1;
            x = int.Parse(txtId.Text);
            if (Pos == 0)
            {
                if (x > Id[Pos + 1])
                {
                    Eliminar(x2);
                    Insertar(x);
                }
                else
                {
                    Id[Pos] = int.Parse(txtId.Text);
                    Edad[Pos] = int.Parse(txtEdad.Text);
                    Nombres[Pos] = txtNombre.Text;
                    MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                }

            }
            else
            {
                if (Pos == N - 1)
                {
                    if (x < Id[Pos - 1])
                    {
                        Eliminar(x2);
                        Insertar(x);
                    }
                    else
                    {
                        Id[Pos] = int.Parse(txtId.Text);
                        Edad[Pos] = int.Parse(txtEdad.Text);
                        Nombres[Pos] = txtNombre.Text;
                        MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                    }

                }

                else
                {
                    if ((x > Id[Pos + 1]) || (x < Id[Pos - 1]))
                    {
                        Eliminar(x2);
                        Insertar(x);

                    }
                    else
                    {
                        Id[Pos] = int.Parse(txtId.Text);
                        Edad[Pos] = int.Parse(txtEdad.Text);
                        Nombres[Pos] = txtNombre.Text;
                        MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                    }
                }
            }
        }

        void SecuencialRecursivo(int X, int i)
        {
            if (i < Id.Length && X > Id[i])
            {
                SecuencialRecursivo(X, i + 1);

            }
            else
            {
                if (i >= Id.Length || X < Id[i])
                {
                    MessageBox.Show("No se encuentra el arreglo");
                }
                else
                {
                    MessageBox.Show("El ID" + X + "se encuentra en la posicion" + i);
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add("ID" + "\t" + "Nombres" + "\t" + "Edad");
                    lbImprimir.Items.Add(Id[i] + "\t" + Nombres[i] + "\t" + Edad[i]);
                }
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
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
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos()==true)
            {
                x = int.Parse(txtId.Text);
                Insertar(x);
                Limpiar();
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                x = int.Parse(txtId.Text);
                Eliminar(x);
                Limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Actualizar();
                btnActualizar.Enabled = false;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            for (i = 0; i < N; i++)
            {
                lbImprimir.Items.Add(Id[i] + "\t" + Nombres[i] + "\t" + Edad[i]);
            }
        }

        private void btnIterativa_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int X = int.Parse(txtId.Text);
                while (i < Id.Length && X > Id[i])
                {
                    i++;
                }
                if (i >= Id.Length || X < Id[i])
                {
                    MessageBox.Show("No se Encuentra el Arrelgo");
                }
                else
                {
                    MessageBox.Show("El ID " + X + " se encuentra en la posicion " + i);
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add("ID" + "\t" + "Nombres" + "\t" + "Edad");
                    lbImprimir.Items.Add(Id[i] + "\t" + Nombres[i] + "\t" + Edad[i]);
                }
            }
        }

        private void btnRecursiva_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                int X = int.Parse(txtId.Text);
                SecuencialRecursivo(X, i);
            }
        }
    }
}
