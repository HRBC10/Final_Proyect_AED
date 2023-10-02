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
    public partial class FrmRA12 : Form
    {
        FrmMenu Volver;
        public FrmRA12()
        {
            InitializeComponent();
        }
        FrmRA12_Empleado Nathi = new FrmRA12_Empleado();
        FrmRA12_Solicitud Nathi1 = new FrmRA12_Solicitud();

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nathi.Show();
            Nathi1.Hide();
        }

        private void solicitudPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nathi1.refrescardatos();
            Nathi1.Show();
            Nathi.Hide();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void volverMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void FrmRA12_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

    }
}
