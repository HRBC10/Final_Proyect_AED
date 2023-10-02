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
    public partial class FrmRA7 : Form
    {
        public FrmRA7()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validacion";
            string message = string.Empty;


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

            if (txtTelefono.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Telefono";
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
        List<ClssPersonaRA7> Personas = new List<ClssPersonaRA7>();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos() == true)
            {
                Personas.Add(new ClssPersonaRA7
                {
                    EONombres = txtNombre.Text,
                    EOApellidos = txtApellido.Text,
                    EOTelefono = int.Parse(txtTelefono.Text),
                    EOAño = int.Parse(txtAño.Text)
                });
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dgImprimir.DataSource = null;
            dgImprimir.DataSource = Personas;
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            var resultado = Personas.Where(x => x.EOEdad > 20).Select(c => new { Nombres = c.EONombres }).ToList();
            dgImprimir.DataSource = resultado;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
