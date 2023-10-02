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
    public partial class FrmAA4_FerreteriaCliente : Form
    {
        public FrmAA4_FerreteriaCliente()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            TxtIdCliente.Text = string.Empty;
            TxtNombres.Text = string.Empty;
            TxtApellidos.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
        }

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Ingreso de Clientes";
            string message = string.Empty;

            if (TxtIdCliente.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Id Del Cliente";
                MessageBox.Show(message, title);
            }

            if (TxtNombres.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nombre Del Cliente";
                MessageBox.Show(message, title);
            }

            if (TxtApellidos.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido Del Cliente";
                MessageBox.Show(message, title);
            }

            if (TxtTelefono.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Telefono Del Cliente";
                MessageBox.Show(message, title);
            }

            if (TxtDireccion.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Direccion Del Cliente";
                MessageBox.Show(message, title);
            }

            return flag;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() == true)
            {
                guardarProductos();
            }
        }
        private void guardarProductos()
        {
            ClssClientesAA4_Ferreteria Instancia = new ClssClientesAA4_Ferreteria();
            Instancia.EOID = int.Parse(TxtIdCliente.Text);
            Instancia.EONombres = TxtNombres.Text;
            Instancia.EOApellidos = TxtApellidos.Text;
            Instancia.EOTelefono = int.Parse(TxtTelefono.Text);
            Instancia.EODireccion = TxtDireccion.Text;

            var result = ClssModuloAA4Ferreteria.ListaClientes.Count(s => s.EOID.ToString() == Instancia.EOID.ToString());

            if (result > 0)
            {
                string message = "El Id Cliente que intenta registrar ya existe";
                string title = "Ingreso de Clientes";
                MessageBox.Show(message, title);
            }
            else
            {
                ClssModuloAA4Ferreteria.ListaClientes.Add(Instancia);
                DgClientes.DataSource = null;
                DgClientes.DataSource = ClssModuloAA4Ferreteria.ListaClientes;
                Limpiar();
            }
        }

        private void TxtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmAA4_FerreteriaCliente_Load(object sender, EventArgs e)
        {
            DgClientes.ReadOnly = true;
            DgClientes.RowsDefaultCellStyle.BackColor = Color.Beige;
            DgClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
        }
    }
}
