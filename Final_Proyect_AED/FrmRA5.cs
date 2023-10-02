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
    public partial class FrmRA5 : Form
    {
        FrmMenu Volver;
        public FrmRA5()
        {
            InitializeComponent();
        }

        int N = 0, Tam, i, Pos, x, x2;
        int[] Id;
        int[] Edad;
        String[] Nombres;

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if(txtEstablecer.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tam = int.Parse(txtEstablecer.Text);
                Id = new int[Tam];
                Edad = new int[Tam];
                Nombres = new string[Tam];
                N = 0;
                MessageBox.Show("Cantidad De Elementos Establecida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                x = int.Parse(txtId.Text);
                Insertar(x);
                limpiar();
                btnActualizar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                x = int.Parse(txtId.Text);
                Eliminar(x);
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                x = int.Parse(txtId.Text);
                Actualizar();
                btnActualizar.Enabled = true;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (N > 0)
                {
                    x2 = int.Parse(txtId.Text);
                    Pos = Busca(x2);
                    if (Pos <= -1)
                    {
                        MessageBox.Show("No está registrado","Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtEdad.Text = Convert.ToString(Edad[Pos]);
                        txtNombre.Text = Nombres[Pos];
                    }
                }
                else
                {
                    MessageBox.Show("No hay elemntos registrados");
                }
            }
        }

        private void FrmRA5_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void txtEstablecer_KeyPress(object sender, KeyPressEventArgs e)
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

        void limpiar()
        {
            txtEdad.Clear();
            txtId.Clear();
            txtNombre.Clear();
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

        public int Busca(int x)
        {
            i = 0;
            while (i < N && Id[i] < x)
            {
                i++;
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
                Pos = Busca(x);
                if (Pos <= -1)
                {
                    MessageBox.Show(x + " No está registrado");
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
                    MessageBox.Show("la persona " + x + " se ha eliminado");
                }
            }
            else
            {
                MessageBox.Show("No hay registros");
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
                            Nombres[i] = Nombres[i - 1];
                            Edad[i] = Edad[i - 1];
                        }
                        Id[Pos] = int.Parse(txtId.Text);
                        Nombres[Pos] = txtNombre.Text;
                        Edad[Pos] = int.Parse(txtEdad.Text);
                        N++;
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
                Nombres[N] = txtNombre.Text;
                Edad[N] = int.Parse(txtEdad.Text);
                N++;
            }
        }
    }
}
