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
    public partial class FrmAA4_FerreteriaFiltroIDCliente : Form
    {
        public FrmAA4_FerreteriaFiltroIDCliente()
        {
            InitializeComponent();
        }

        void Buscar()
        {
            int idCliente = int.Parse(txtBFClientes.Text);

            var FactMaestro = ClssModuloAA4Ferreteria.ListaFacturaMaestro.Where(x => x.EOID == idCliente).ToList();

            foreach (var a in FactMaestro)
            {
                lblIdFact.Text = a.EOIDFactura.ToString();
                lblFecha.Text = a.EOFecha.ToString();
                lblNom.Text = a.EONombres + " " + a.EOApellidos;
                lblCliente.Text = a.EOID.ToString();
                lbTotal.Text = a.EOTotalFactura.ToString();
            }

            var FactDetalle = ClssModuloAA4Ferreteria.ListaFacturaDetalle.Where(x => x.EOID == idCliente).ToList();
            DgBFacturasClientes.DataSource = FactDetalle;
        }

        private void txtBFClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                Buscar();
            }
        }

        private void FrmAA4_FerreteriaFiltroIDCliente_Load(object sender, EventArgs e)
        {
            DgBFacturasClientes.ReadOnly = true;
            DgBFacturasClientes.RowsDefaultCellStyle.BackColor = Color.Beige;
            DgBFacturasClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
        }
    }
}
