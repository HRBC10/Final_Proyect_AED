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
    public partial class FrmRA10 : Form
    {
        public FrmRA10()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        List<ClssProductoRA10> ListaProducto = new List<ClssProductoRA10>();
        DataTable dt = new DataTable();
        bool Band = false;
        int i;
        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validación";
            string message = string.Empty;


            if (txtId.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El ID";
                MessageBox.Show(message, title);
            }

            if (txtDescripcion.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Descrpicion";
                MessageBox.Show(message, title);
            }

            if (cbPorcentaje.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese % De Ganancia";
                MessageBox.Show(message, title);
            }

            if (txtPrecio.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Precio";
                MessageBox.Show(message, title);
            }

            if (txtSMinimo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Stock Mímimo";
                MessageBox.Show(message, title);
            }

            if (txtSMaximo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Stock Máximo";
                MessageBox.Show(message, title);
            }
            if (txtExistencia.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Existencia";
                MessageBox.Show(message, title);
            }
            return flag;
        }

        void Procedimiento()
        {
            dt.Clear();
            if (Band == false)
            {
                foreach (DataGridViewColumn col in dgProductos.Columns)
                {
                    dt.Columns.Add(col.Name);
                }
                Band = true;
            }
            foreach (DataGridViewRow row in dgProductos.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() ==true)
            {
                ClssProductoRA10 Instancia = new ClssProductoRA10();
                Instancia.EOID = int.Parse(txtId.Text);
                Instancia.EODescripcion = txtDescripcion.Text;
                Instancia.EOCosto = double.Parse(txtCosto.Text);
                Instancia.EOPrecio = double.Parse(txtPrecio.Text);
                Instancia.EOSMaximo = int.Parse(txtSMaximo.Text);
                Instancia.EOSMinimo = int.Parse(txtSMinimo.Text);
                Instancia.EOExistencia = int.Parse(txtExistencia.Text);
                ListaProducto.Add(Instancia);
                
            }
        }

        private void FrmRA10_Load(object sender, EventArgs e)
        {
            cbPorcentaje.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 10; i <= 180; i = i + 10)
            {
                cbPorcentaje.Items.Add(i);
            }
        }

        private void cbPorcentaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClssProductoRA10 Instancia = new ClssProductoRA10();
            txtPrecio.Text = Convert.ToString(Instancia.CalcularPrecio(double.Parse(txtCosto.Text), double.Parse(cbPorcentaje.Text)));
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = $"EODescripcion LIKE '{txtBuscar.Text}%'";
            dgProductos.DataSource = null;
            dgProductos.DataSource = dt;
        }

        private void txtIdb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Buscar();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dgProductos.DataSource = null;
            dgProductos.DataSource = ListaProducto;
            Procedimiento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        void Buscar()
        {
            int id = int.Parse(txtIdb.Text);
            var t = ListaProducto.Where(x => x.EOID == id).ToList();
            dgProductos.DataSource = t;
        }

        private void rbExistencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExistencia.Checked == true)
            {
                var t = ListaProducto.Sum(x => x.EOExistencia);
                txtResultado.Text = Convert.ToString(t);
                rbExistencia.Checked = false;
            }
        }

        private void rbPromedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPromedio.Checked == true)
            {
                var t = ListaProducto.Average(x => x.EOPrecio);
                txtResultado.Text = Convert.ToString(t);
                rbPromedio.Checked = false;
            }
        }

        private void rbListMayores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbListMayores.Checked == true)
            {
                var t = ListaProducto.Where(x => x.EOPrecio > ListaProducto.Average(c => c.EOPrecio)).ToList();
                dgProductos.DataSource = t;
                rbListMayores.Checked = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdb.Text);
            ListaProducto = ListaProducto.Where(x => x.EOID != id).ToList();
            dgProductos.DataSource = ListaProducto;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
