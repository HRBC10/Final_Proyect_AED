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
    public partial class FrmRA12_Solicitud : Form
    {
        public FrmRA12_Solicitud()
        {
            InitializeComponent();
        }

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validación";
            string message = string.Empty;


            if (TxtMonto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Monto";
                MessageBox.Show(message, title);
            }

            if (TxtNombre2.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nombre";
                MessageBox.Show(message, title);
            }

            if (Txtplazo.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Plazo";
                MessageBox.Show(message, title);
            }

            if (TxtFecha.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Fecha";
                MessageBox.Show(message, title);
            }
            if (CbTrabajador.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese ID de Trabajador";
                MessageBox.Show(message, title);
            }
            return flag;
        }

        public void refrescardatos()
        {
            CbTrabajador.DisplayMember = "EOId";
            CbTrabajador.ValueMember = "EOId";
            CbTrabajador.DataSource = ClssModuloRA12.ListaEmpleados.ToList();
        }

        private void CbTrabajador_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbTrabajador.SelectedValue != null)
            {
                var Consulta1 = ClssModuloRA12.ListaEmpleados.Where(x => x.EOID.ToString() == CbTrabajador.SelectedValue.ToString()).FirstOrDefault().EONombres;
                TxtNombre2.Text = Consulta1;
                var Consulta2 = ClssModuloRA12.ListaEmpleados.Where(x => x.EOID.ToString() == CbTrabajador.SelectedValue.ToString()).FirstOrDefault().EOApellidos;
                Txtapellido2.Text = Consulta2;
                var Consulta3 = ClssModuloRA12.ListaEmpleados.Where(x => x.EOID.ToString() == CbTrabajador.SelectedValue.ToString()).FirstOrDefault()?.Prestamos.ToList();
                DgIngresar2.DataSource = Consulta3;
            }
        }

        private void BtnIngresar2_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos()==true)
            {
                ClssPrestamosRA12 prest = new ClssPrestamosRA12();
                prest.EOID = int.Parse(CbTrabajador.SelectedValue.ToString());
                prest.EOMonto = double.Parse(TxtMonto.Text);
                prest.EOPlazo = int.Parse(Txtplazo.Text);
                prest.EOFecha = DateTime.Parse(TxtFecha.Text);
                prest.EOEstado = CbEstado.Text;
                var indiceempleado = ClssModuloRA12.ListaEmpleados.IndexOf(ClssModuloRA12.ListaEmpleados.Find(x => x.EOID == int.Parse(CbTrabajador.SelectedValue.ToString())));
                if (indiceempleado > -1)
                {
                    ClssModuloRA12.ListaEmpleados[indiceempleado].Prestamos.Add(prest);
                    DgIngresar2.DataSource = ClssModuloRA12.ListaEmpleados[indiceempleado].Prestamos.ToList();
                }
            }
        }

        private void FrmRA12_Solicitud_Load(object sender, EventArgs e)
        {
            CbEstado.Items.Add("Cancelada");
            CbEstado.Items.Add("Pendiente");
            TxtNombre2.Enabled = false;
            Txtapellido2.Enabled = false;

            TxtFecha.Text = Convert.ToString(DateTime.Now);
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtplazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
