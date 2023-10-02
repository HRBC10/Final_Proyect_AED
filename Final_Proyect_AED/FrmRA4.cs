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
    public partial class FrmRA4 : Form
    {
        public FrmRA4()
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
            public string Nombre;
            public string Apellido;
            public string Sexo;
            public Fecha FechaNacimiento;
        }Datos[] Registro;

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

            if (txtNombre.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (txtApellido.Text == string.Empty)
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos() == true)
            {
                if (N <= Tam - 1)
                {
                    Registro[N].Carnet = txtCarnet.Text;
                    Registro[N].Nombre = txtNombre.Text;
                    Registro[N].Apellido = txtApellido.Text;
                    Registro[N].Sexo = cbSexo.Text;
                    Registro[N].FechaNacimiento.Dia = int.Parse(cbDia.Text);
                    Registro[N].FechaNacimiento.Mes = cbMes.Text;
                    Registro[N].FechaNacimiento.Año = int.Parse(txtAño.Text);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtCarnet.Text == string.Empty)
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
                        Registro[k].Nombre = Registro[k + 1].Nombre;
                        Registro[k].Apellido = Registro[k + 1].Apellido;
                        Registro[k].Sexo = Registro[k + 1].Sexo;
                        Registro[k].FechaNacimiento.Dia = Registro[k + 1].FechaNacimiento.Dia;
                        Registro[k].FechaNacimiento.Mes = Registro[k + 1].FechaNacimiento.Mes;
                        Registro[k].FechaNacimiento.Año = Registro[k + 1].FechaNacimiento.Año;
                    }
                    N = N - 1;
                    MessageBox.Show("El Estudiante con carnet " + x + " Ha sido eliminado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtCarnet.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío","Validación",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Registro[i].Nombre = txtNombre.Text;
                    Registro[i].Apellido = txtApellido.Text;
                    Registro[i].Sexo = cbSexo.Text;
                    Registro[i].FechaNacimiento.Dia = int.Parse(cbDia.Text);
                    Registro[i].FechaNacimiento.Mes = cbMes.Text;
                    Registro[i].FechaNacimiento.Año = int.Parse(txtAño.Text);
                    Limpiar();
                    MessageBox.Show("El Estudiante con carnet " + x + " Ha sido Actualizado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Carnet     Nombres     Apellidos   Sexo    Dia    /   mes     /   Año");
            for (i = 0; i < N; i++)
            {
                lbImprimir.Items.Add(Registro[i].Carnet + "\t" + Registro[i].Nombre + "\t" + Registro[i].Apellido + "\t"
                + Registro[i].Sexo + "\t" + Registro[i].FechaNacimiento.Dia + " / " + Registro[i].FechaNacimiento.Mes + " / "
                + Registro[i].FechaNacimiento.Año);
            }
        }

        private void FrmRA4_Load(object sender, EventArgs e)
        {
            cbSexo.Items.Add("M");
            cbSexo.Items.Add("F");
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDia.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int a = 1; a <= 31; a++)
            {
                cbDia.Items.Add(Convert.ToString(a));
            }

            cbMes.Items.Add("Enero");
            cbMes.Items.Add("Febrero");
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

        private void txtEstablecer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if(txtEstablecer.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tam = int.Parse(txtEstablecer.Text);
                Registro = new Datos[Tam];
                N = 0;
                MessageBox.Show("Numero de Estudiantes Establecido","Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Limpiar()
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtAño.Clear();
        }

    }
}
