using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proyect_AED
{
    public partial class FrmRegistroBanco : Form
    {
        public FrmRegistroBanco()
        {
            InitializeComponent();
        }


        void Agregar()
        {
            if (cbServicio.Text == "Caja")
            {

                ClssModulo.ClienteCaja.Enqueue(txtNombreCliente.Text+ "\t" + txtApellidoCliente.Text);
                txtNombreCliente.Clear();
                txtApellidoCliente.Clear();
                txtNombreCliente.Focus();
                txtApellidoCliente.Focus();
                cbServicio.Focus();
            }
            else
            {
                ClssModulo.ClienteServicioBancario.Enqueue(txtNombreCliente.Text + "\t" + txtApellidoCliente.Text);
                txtNombreCliente.Clear();
                txtApellidoCliente.Clear();
                txtNombreCliente.Focus();
                txtApellidoCliente.Focus();
                cbServicio.Focus();
            }
        }


        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text != "" && cbServicio.Text != "" && txtApellidoCliente.Text !="")
            {
                Agregar();
            }
            else
            {
                MessageBox.Show("Campos Vacios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmRegistroBanco_Load(object sender, EventArgs e)
        {
            cbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServicio.Items.Add("Caja");
            cbServicio.Items.Add("Servicios Bancarios");
        }
    }
}
