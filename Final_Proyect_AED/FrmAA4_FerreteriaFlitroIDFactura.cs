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
    public partial class FrmAA4_FerreteriaFlitroIDFactura : Form
    {
        public FrmAA4_FerreteriaFlitroIDFactura()
        {
            InitializeComponent();
        }

        void Buscar()
        {
            int idFactura = int.Parse(txtBIDFacturas.Text);

            var factMaestro = ClssModuloAA4Ferreteria.ListaFacturaMaestro.Where(x=> x.EOIDFactura == idFactura).ToList();

            foreach (var a in factMaestro)
            {
                lblIdFact.Text = a.EOIDFactura.ToString();
                lblFecha.Text = a.EOFecha.ToString();
                lblNom.Text = a.EONombres + " " + a.EOApellidos;
                lblCliente.Text = a.EOID.ToString();
                lbTotal.Text = a.EOTotalFactura.ToString();
            }

            var FactDetalle = ClssModuloAA4Ferreteria.ListaFacturaDetalle.Where(x => x.EOIDFactura == idFactura).ToList();
            dgIDFacturas.DataSource = FactDetalle;
        }

        private void txtBIDFacturas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmAA4_FerreteriaFlitroIDFactura_Load(object sender, EventArgs e)
        {
            dgIDFacturas.ReadOnly = true;
            dgIDFacturas.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgIDFacturas.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
        }
    }
}
