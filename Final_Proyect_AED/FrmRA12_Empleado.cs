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
    public partial class FrmRA12_Empleado : Form
    {
        public FrmRA12_Empleado()
        {
            InitializeComponent();
        }

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validación";
            string message = string.Empty;


            if (TxtId.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El ID";
                MessageBox.Show(message, title);
            }

            if (TxtNombres.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nombre";
                MessageBox.Show(message, title);
            }

            if (TxtApellidos.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido";
                MessageBox.Show(message, title);
            }

            if (TxtDni.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese DNI";
                MessageBox.Show(message, title);
            }

            if (TxtDireccion.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Dirección";
                MessageBox.Show(message, title);
            }

            if (TxtFechadeingreso.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Fecha De Ingreso";
                MessageBox.Show(message, title);
            }
            if (TxtCelular.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Celular";
                MessageBox.Show(message, title);
            }
            return flag;
        }
        private void Btningresar_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos()==true)
            {
                ClssEmpleadoRA12 Instancia = new ClssEmpleadoRA12();
                Instancia.EOID = int.Parse(TxtId.Text);
                Instancia.EONombres = TxtNombres.Text;
                Instancia.EOApellidos = TxtApellidos.Text;
                Instancia.EODNI = TxtDni.Text;
                Instancia.EOCelular = int.Parse(TxtCelular.Text);
                Instancia.EODireccion = TxtDireccion.Text;
                Instancia.EOFecha = DateTime.Parse(TxtFechadeingreso.Text);
                ClssModuloRA12.ListaEmpleados.Add(Instancia);
                DgEmpleados.DataSource = null;
                DgEmpleados.DataSource = ClssModuloRA12.ListaEmpleados;
            }
        }

        private void FrmRA12_Empleado_Load(object sender, EventArgs e)
        {
            TxtFechadeingreso.Text = Convert.ToString(DateTime.Now);
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
