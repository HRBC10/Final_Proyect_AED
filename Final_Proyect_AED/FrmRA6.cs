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
    public partial class FrmRA6 : Form
    {
        public FrmRA6()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validación";
            string message = string.Empty;


            if (txtID.Text == string.Empty)
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

            if (cbGanancia.Text == string.Empty)
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

            if (txtMinimo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Stock Mímimo";
                MessageBox.Show(message, title);
            }

            if (txtMaximo.Text == string.Empty)
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
        ClssProductoRA6[] Instancia;
        int i;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio","Validación",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txtID.Text);
                foreach (var elemento in Instancia)
                {
                    if (elemento.EOId == id)
                    {
                        txtDescripcion.Text = Convert.ToString(elemento.EODescripcion);
                        txtCosto.Text = Convert.ToString(elemento.EOCosto);
                        txtPrecio.Text = Convert.ToString(elemento.EOPrecio);
                        txtMinimo.Text = Convert.ToString(elemento.EOSMinimo);
                        txtMaximo.Text = Convert.ToString(elemento.EOSMaximo);
                        txtExistencia.Text = Convert.ToString(elemento.EOExistencia);
                        cbGanancia.Visible = false;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos() == true)
            {
                Array.Resize(ref Instancia, i + 1);
                Instancia[i] = new ClssProductoRA6();


                Instancia[i].EOId = int.Parse(txtID.Text);
                Instancia[i].EODescripcion = txtDescripcion.Text;
                Instancia[i].EOCosto = double.Parse(txtCosto.Text);
                Instancia[i].EOPrecio = double.Parse(txtPrecio.Text);
                Instancia[i].EOExistencia = int.Parse(txtExistencia.Text);

                i = i + 1;
                dgImprimir.DataSource = Instancia;
                cbGanancia.Visible = true;
            }
        }

        private void cbGanancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClssProductoRA6 Instancia1 = new ClssProductoRA6(); //Creación de la instancia

            txtPrecio.Text = Instancia1.CalcularPrecio(double.Parse(txtCosto.Text), Double.Parse(cbGanancia.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtExistencia.Clear();
            txtMaximo.Clear();
            txtMinimo.Clear();
            cbGanancia.Visible = true;

        }

        private void dgImprimir_SelectionChanged(object sender, EventArgs e)
        {
            int indice = dgImprimir.CurrentRow.Index;
            txtID.Text = Convert.ToString(Instancia[indice].EOId);
            txtDescripcion.Text = Instancia[indice].EODescripcion;
            txtCosto.Text = Convert.ToString(Instancia[indice].EOCosto);
            txtPrecio.Text = Convert.ToString(Instancia[indice].EOPrecio);
            txtMinimo.Text = Convert.ToString(Instancia[indice].EOSMinimo);
            txtMaximo.Text = Convert.ToString(Instancia[indice].EOSMaximo);
            txtExistencia.Text = Convert.ToString(Instancia[indice].EOExistencia);
            cbGanancia.Visible = false;
        }

        private void FrmRA6_Load(object sender, EventArgs e)
        {
            cbGanancia.Enabled = true;
            cbGanancia.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int a = 10; a <= 100; a = a + 10)
            {
                cbGanancia.Items.Add(a);
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaximo_KeyPress(object sender, KeyPressEventArgs e)
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
