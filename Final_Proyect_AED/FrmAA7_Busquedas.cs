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
    public partial class FrmAA7_Busquedas : Form
    {
        public FrmAA7_Busquedas()
        {
            InitializeComponent();
        }
        FrmMenu Volver;
        FrmAA7_TeoriaSecuencial TeoriaSecuencial = new FrmAA7_TeoriaSecuencial();
        FrmAA7_TeoriaBinaria TeoriaBinaria = new FrmAA7_TeoriaBinaria();
        FrmAA7_BusquedaIterativa BusquedaIterativa = new FrmAA7_BusquedaIterativa();
        FrmAA7_BusquedaRecursiva BusquedaRecursiva = new FrmAA7_BusquedaRecursiva();
        FrmAA7_AlgoritmosBRecursivo AlgoritmosBRecursivo = new FrmAA7_AlgoritmosBRecursivo();
        FrmAA7_Algoritmos_RConBandera Algoritmos_RConBandera = new FrmAA7_Algoritmos_RConBandera();
        FrmAA7_Algoritmos_RSinBandera Algoritmos_RSinBandera = new FrmAA7_Algoritmos_RSinBandera();
        FrmAA7_EjecucionBusquedaSecuencial EjecucionBusquedaSecuencial = new FrmAA7_EjecucionBusquedaSecuencial();
        FrmAA7_EjecucionBinaria EjecucionBinaria = new FrmAA7_EjecucionBinaria();
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }
        void EsconderIterativos()
        {
            TeoriaSecuencial.Hide();
            BusquedaIterativa.Hide();
            BusquedaRecursiva.Hide();
            EjecucionBusquedaSecuencial.Hide();
        }
        void EsconderBinarios()
        {
            TeoriaBinaria.Hide();
            Algoritmos_RConBandera.Hide();
            AlgoritmosBRecursivo.Hide();
            Algoritmos_RSinBandera.Hide();
            EjecucionBinaria.Hide();
        }

        private void teoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaSecuencial.Show();
            BusquedaIterativa.Hide();
            BusquedaRecursiva.Hide();
            EjecucionBusquedaSecuencial.Hide();
            EsconderBinarios();
        }

        private void busquedaIterativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaSecuencial.Hide();
            BusquedaIterativa.Show();
            BusquedaRecursiva.Hide();
            EjecucionBusquedaSecuencial.Hide();
            EsconderBinarios();
        }

        private void busquedaRecursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaSecuencial.Hide();
            BusquedaIterativa.Hide();
            BusquedaRecursiva.Show();
            EjecucionBusquedaSecuencial.Hide();
            EsconderBinarios();
        }

        private void ejecucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaSecuencial.Hide();
            BusquedaIterativa.Hide();
            BusquedaRecursiva.Hide();
            EjecucionBusquedaSecuencial.Show();
            EsconderBinarios();
        }
        private void teoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeoriaBinaria.Show();
            Algoritmos_RConBandera.Hide();
            AlgoritmosBRecursivo.Hide();
            Algoritmos_RSinBandera.Hide();
            EjecucionBinaria.Hide();
            EsconderIterativos();
        }

        private void ejecucionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeoriaBinaria.Hide();
            Algoritmos_RConBandera.Hide();
            AlgoritmosBRecursivo.Hide();
            Algoritmos_RSinBandera.Hide();
            EjecucionBinaria.Show();
            EsconderIterativos();
        }

        private void conBanderaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaBinaria.Hide();
            Algoritmos_RConBandera.Show();
            AlgoritmosBRecursivo.Hide();
            Algoritmos_RSinBandera.Hide();
            EjecucionBinaria.Hide();
            EsconderIterativos();
        }

        private void sinBanderaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaBinaria.Hide();
            Algoritmos_RConBandera.Hide();
            AlgoritmosBRecursivo.Hide();
            Algoritmos_RSinBandera.Show();
            EjecucionBinaria.Hide();
            EsconderIterativos();
        }

        private void binariarecursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeoriaBinaria.Hide();
            Algoritmos_RConBandera.Hide();
            AlgoritmosBRecursivo.Show();
            Algoritmos_RSinBandera.Hide();
            EjecucionBinaria.Hide();
            EsconderIterativos();
        }
    }
}
