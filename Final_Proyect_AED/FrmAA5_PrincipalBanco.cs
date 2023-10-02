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
    public partial class FrmAA5_PrincipalBanco : Form
    {
        public FrmAA5_PrincipalBanco()
        {
            InitializeComponent();
        }

        FrmMenu Volver;
        FrmRegistroBanco IrRegitro = new FrmRegistroBanco();
        FrmVista IrVista = new FrmVista();
        FrmAA5_Caja IrCaja = new FrmAA5_Caja();
        FrmSBancarios IrSBancarios = new FrmSBancarios();

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IrRegitro.Show();
            IrVista.Hide();
            IrCaja.Hide();
            IrSBancarios.Hide();
        }

        private void clientesAtendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IrRegitro.Hide();
            IrVista.AgregarVista();
            IrVista.Show();
            IrCaja.Hide();
            IrSBancarios.Hide();
        }

        private void serviciosCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IrRegitro.Hide();
            IrVista.Hide();
            IrCaja.Agregar();
            IrCaja.Show();
            IrSBancarios.Hide();
        }

        private void serviciosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IrRegitro.Hide();
            IrVista.Hide();
            IrCaja.Hide();
            IrSBancarios.Agregar();
            IrSBancarios.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void FrmAA5_PrincipalBanco_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
