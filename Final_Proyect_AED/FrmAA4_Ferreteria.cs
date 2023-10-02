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
    public partial class FrmAA4_Ferreteria : Form
    {
        public FrmAA4_Ferreteria()
        {
            InitializeComponent();
        }
        FrmMenu Volver;
        FrmAA4_FerreteriaCliente InstanciaFerreteriaCliente = new FrmAA4_FerreteriaCliente();
        FrmAA4_FerreteriaProductos InstanciaFerreteriaProductos = new FrmAA4_FerreteriaProductos();
        FrmAA4_FerreteriaFacturas InstanciaFerreteriaFacturas = new FrmAA4_FerreteriaFacturas();

        FrmAA4_FerreteriaFlitroIDFactura InstanciaFiltroIDFactura = new FrmAA4_FerreteriaFlitroIDFactura();
        FrmAA4_FerreteriaFiltroIDCliente InstanciaFiltroIDCliente = new FrmAA4_FerreteriaFiltroIDCliente();
        FrmAA4_FerreteriaReporteCliente InstanciaReporteCliente = new FrmAA4_FerreteriaReporteCliente();
        FrmAA4_FerreteriaReporteProductos InstanciaReporteProductos = new FrmAA4_FerreteriaReporteProductos();

        void EsconderPrincipales()
        {
            InstanciaFerreteriaCliente.Hide();
            InstanciaFerreteriaProductos.Hide();
            InstanciaFerreteriaFacturas.Hide();
        }

        void EsconderFiltrosYReportes()
        {
            InstanciaFiltroIDCliente.Hide();
            InstanciaFiltroIDFactura.Hide();
            InstanciaReporteCliente.Hide();
            InstanciaReporteProductos.Hide();
        }
        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFerreteriaCliente.Show();
            InstanciaFerreteriaProductos.Hide();
            InstanciaFerreteriaFacturas.Hide();
            EsconderFiltrosYReportes();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFerreteriaCliente.Hide();
            InstanciaFerreteriaProductos.Show();
            InstanciaFerreteriaFacturas.Hide();
            EsconderFiltrosYReportes();
        }

        private void FacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFerreteriaFacturas.refrescardatos();
            InstanciaFerreteriaFacturas.Show();
            InstanciaFerreteriaCliente.Hide();
            InstanciaFerreteriaProductos.Hide();
            EsconderFiltrosYReportes();
        }

        private void buscarIDFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFiltroIDCliente.Hide();
            InstanciaFiltroIDFactura.Show();
            InstanciaReporteCliente.Hide();
            InstanciaReporteProductos.Hide();
            EsconderPrincipales();
        }

        private void busquedaFacturaPorIDClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFiltroIDCliente.Show();
            InstanciaFiltroIDFactura.Hide();
            InstanciaReporteCliente.Hide();
            InstanciaReporteProductos.Hide();
            EsconderPrincipales();
        }

        private void busquedaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFiltroIDCliente.Hide();
            InstanciaFiltroIDFactura.Hide();
            InstanciaReporteCliente.Hide();
            InstanciaReporteProductos.Show();
            EsconderPrincipales();
        }

        private void busquedaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaFiltroIDCliente.Hide();
            InstanciaFiltroIDFactura.Hide();
            InstanciaReporteCliente.Show();
            InstanciaReporteProductos.Hide();
            EsconderPrincipales();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Close();
        }

        private void FrmAA4_Ferreteria_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
