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
    public partial class FrmRA17 : Form
    {
        public FrmRA17()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        int Tam, N, i;
        public struct Fecha
        {
            public int Dia;
            public string Mes;
            public int Año;
        }
        public struct Datos
        {
            public string Carnet;
            public string Nombres;
            public string Apellidos;
            public string Sexo;
            public Fecha FechaNac;
        }
        Datos[] Registro;

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validacion";
            string message = string.Empty;

            if (txtCarnet.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Id";
                MessageBox.Show(message, title);
            }

            if (txtNombres.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (txtApellidos.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido";
                MessageBox.Show(message, title);
            }

            if (cbDia.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Dia";
                MessageBox.Show(message, title);
            }

            if (cbMes.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Mes";
                MessageBox.Show(message, title);
            }

            if (cbSexo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Sexo";
                MessageBox.Show(message, title);
            }

            if (txtAño.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Año";
                MessageBox.Show(message, title);
            }
            return flag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Carnet" + "\t" + "Nombres" + "\t" + "Apellidos" + "\t" + "Nacimiento");

            for (i = 0; i < N; i++)
            {
                lbImprimir.Items.Add(Registro[i].Carnet + "\t" + Registro[i].Nombres + "\t" + Registro[i].Apellidos + "\t" + Registro[i].FechaNac.Mes + Registro[i].FechaNac.Dia + Registro[i].FechaNac.Año);
            }
        }

        void Limpiar()
        {
            txtCarnet.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtAño.Clear();
        }

        private void btnIterativa_Click(object sender, EventArgs e)
        {
            if(txtCarnet.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                string X = txtCarnet.Text;
                while (i < Registro.Length && Registro[i].Carnet != X)
                {
                    i = i + 1;
                }
                if (i >= N)
                {
                    MessageBox.Show("El estudiante con el carnet " + X + " No se encuentra");
                }
                else
                {
                    MessageBox.Show("El estudiante con el carnet " + X + " se encuentra en la posicion " + i);
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add("Carnet" + "\t" + "Nombres" + "\t" + "Apellidos" + "\t" + "Nacimiento");
                    lbImprimir.Items.Add(Registro[i].Carnet + "\t" + Registro[i].Nombres + "\t" + Registro[i].Apellidos + "\t" + Registro[i].FechaNac.Mes + Registro[i].FechaNac.Dia + Registro[i].FechaNac.Año);
                }
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tam = int.Parse(txtCantidad.Text);
                Registro = new Datos[Tam];
                N = 0;
                MessageBox.Show("Cantidad De Elementos Establecida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() == true)
            {
                if (N <= Tam - 1)
                {
                    Registro[N].Carnet = txtCarnet.Text;
                    Registro[N].Nombres = txtNombres.Text;
                    Registro[N].Apellidos = txtApellidos.Text;
                    Registro[N].Sexo = cbSexo.Text;
                    Registro[N].FechaNac.Dia = int.Parse(cbDia.Text);
                    Registro[N].FechaNac.Mes = cbMes.Text;
                    Registro[N].FechaNac.Año = int.Parse(txtAño.Text);
                    Limpiar();
                    N = N + 1;
                    MessageBox.Show("Se ingreso el registro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Hay Espacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                string x;
                x = txtCarnet.Text;
                while (i < N && x != Registro[i].Carnet)
                {
                    i = i + 1;
                }
                if (i >= N)
                {
                    MessageBox.Show(x + " No Esta Registrado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Registro[i].Nombres = txtNombres.Text;
                    Registro[i].Apellidos = txtApellidos.Text;
                    Registro[i].Sexo = cbSexo.Text;
                    Registro[i].FechaNac.Dia = int.Parse(cbDia.Text);
                    Registro[i].FechaNac.Mes = cbMes.Text;
                    Registro[i].FechaNac.Año = int.Parse(txtAño.Text);
                    Limpiar();
                    MessageBox.Show("El Estudiante con carnet " + x + " Ha sido Actualizado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                string x;
                x = txtCarnet.Text;
                while (i < N && x != Registro[i].Carnet)
                {
                    i = i + 1;
                }
                if (i >= N)
                {
                    MessageBox.Show(x + " No Esta Registrado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int k = i; k < N - 1; k++)
                    {
                        Registro[k].Carnet = Registro[k + 1].Carnet;
                        Registro[k].Nombres = Registro[k + 1].Nombres;
                        Registro[k].Apellidos = Registro[k + 1].Apellidos;
                        Registro[k].Sexo = Registro[k + 1].Sexo;
                        Registro[k].FechaNac.Dia = Registro[k + 1].FechaNac.Dia;
                        Registro[k].FechaNac.Mes = Registro[k + 1].FechaNac.Mes;
                        Registro[k].FechaNac.Año = Registro[k + 1].FechaNac.Año;
                    }
                    N = N - 1;
                    MessageBox.Show("El Estudiante con carnet " + x + " Ha sido eliminado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmRA17_Load(object sender, EventArgs e)
        {
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDia.DropDownStyle = ComboBoxStyle.DropDownList;

            cbSexo.Items.Add("M");
            cbSexo.Items.Add("F");

            for (int a = 1; a <= 31; a++)
            {
                cbDia.Items.Add(Convert.ToString(a));
            }

            cbMes.Items.Add("Enero");
            cbMes.Items.Add("Febreo");
            cbMes.Items.Add("Marzo");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Mayo");
            cbMes.Items.Add("Junio");
            cbMes.Items.Add("Julio");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Septiembre");
            cbMes.Items.Add("Octubre");
            cbMes.Items.Add("Noviembre");
            cbMes.Items.Add("Diciembre");
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

        void SecuencialRecursivo(string X, int i)
        {
            if (i >= N)
            {
                MessageBox.Show("No se encuentra el arreglo");
            }
            else
            {
                if (Registro[i].Carnet == X)
                {
                    MessageBox.Show("El estudiante con el carnet" + X + "se encuentra en la posicion" + i);
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add("Carnet" + "\t" + "Nombres" + "\t" + "Apellidos" + "\t" + "Nacimiento");
                    lbImprimir.Items.Add(Registro[i].Carnet + "\t" + Registro[i].Nombres + "\t" + Registro[i].Apellidos + "\t" + Registro[i].FechaNac.Mes + Registro[i].FechaNac.Dia + Registro[i].FechaNac.Año);
                }
                else
                {
                    SecuencialRecursivo(X, i + 1);
                }
            }
        }

        private void btnRecursiva_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = 0;
                string X = txtCarnet.Text;
                SecuencialRecursivo(X, i);
            }
        }
    }
}
