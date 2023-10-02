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
    public partial class FrmAA4_FerreteriaProductos : Form
    {
        public FrmAA4_FerreteriaProductos()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            TxtIdProducto.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            TxtCosto.Text = string.Empty;
            TxtPrecioUnitario.Text = string.Empty;
            TxtPrecioMayorista.Text = string.Empty;
            txtExistencia.Text = string.Empty;
            txtStockMinimo.Text = string.Empty;
            txtStockMaximo.Text = string.Empty;
        }

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Ingreso de Productos";
            string message = string.Empty;

            if (TxtIdProducto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Id Producto";
                MessageBox.Show(message, title);
            }

            if (TxtDescripcion.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese la Descripcion Del Producto";
                MessageBox.Show(message, title);
            }

            if (TxtCosto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Costo";
                MessageBox.Show(message, title);
            }

            if (TxtPrecioUnitario.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Precio Unitario";
                MessageBox.Show(message, title);
            }

            if (TxtPrecioMayorista.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Precio Mayorista";
                MessageBox.Show(message, title);
            }

            if (txtStockMinimo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Minimo De Stock";
                MessageBox.Show(message, title);
            }

            if (txtStockMaximo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Maximo De Stock";
                MessageBox.Show(message, title);
            }

            if (txtExistencia.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese La Existencia Del Producto";
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

        private void FrmAA4_FerreteriaProductos_Load(object sender, EventArgs e)
        {
            DgProductos.ReadOnly = true;
            DgProductos.RowsDefaultCellStyle.BackColor = Color.Beige;
            DgProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

        }

        private void guardarProductos()
        {
            ClssProductosAA4_Ferreteria Instancia = new ClssProductosAA4_Ferreteria();
            Instancia.EOIDProducto = int.Parse(TxtIdProducto.Text);
            Instancia.EODescripcion = TxtDescripcion.Text;
            Instancia.EOCosto = decimal.Parse(TxtCosto.Text);
            Instancia.EOPUnitario = decimal.Parse(TxtPrecioUnitario.Text);
            Instancia.EOPMayorista = decimal.Parse(TxtPrecioMayorista.Text);
            Instancia.EOSTMimimo = int.Parse(txtStockMinimo.Text);
            Instancia.EOSTMaximo = int.Parse(txtStockMaximo.Text);
            Instancia.EOExistencia = int.Parse(txtExistencia.Text);

            var result = ClssModuloAA4Ferreteria.ListaProductos.Count(s => s.EOIDProducto.ToString() == Instancia.EOIDProducto.ToString());

            if (result > 0)
            {
                string message = "El Id Producto que intenta registrar ya existe";
                string title = "Ingreso de Productos";
                MessageBox.Show(message, title);
            }
            else if (Instancia.EOSTMimimo > Instancia.EOExistencia)
            {
                string message = "La Existencia debe ser mayor que el stock Minimo";
                string title = "Ingreso de Productos";
                MessageBox.Show(message, title);
            }
            else if (Instancia.EOSTMaximo < Instancia.EOExistencia)
            {
                string message = "La Existencia debe ser Menor que el stock Maximo";
                string title = "Ingreso de Productos";
                MessageBox.Show(message, title);
            }
            else
            {
                ClssModuloAA4Ferreteria.ListaProductos.Add(Instancia);
                DgProductos.DataSource = null;
                DgProductos.DataSource = ClssModuloAA4Ferreteria.ListaProductos;
                Limpiar();
            }
        }

        private void TxtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {   // solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecioMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {   // solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {   // solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {   // solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
