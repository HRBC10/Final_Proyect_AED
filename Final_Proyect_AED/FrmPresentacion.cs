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
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }
        FrmMenu RegresarPresentacion;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            RegresarPresentacion = new FrmMenu();
            RegresarPresentacion.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {

        }
    }
}
