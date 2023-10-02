using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Proyect_AED
{
    public partial class Form1 : Form
    {
        ClssArbolAA3 ArbolBinario;
        FrmMenu Volver;
        public Form1()
        {
            InitializeComponent();
            ArbolBinario = new ClssArbolAA3();
        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInsertar.Text) == false)
            {
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = true;
                btnEliminar.Enabled = true;
                txtEliminar.Enabled = true;
                ArbolBinario.insertar(int.Parse(txtInsertar.Text));
                txtInsertar.Clear();
                string ruta = ArbolBinario.graficar();

                System.Threading.Thread.Sleep(1000);

                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
        }

        private void BtnInOrden_Click(object sender, EventArgs e)
        {
            Inorden.Text = ArbolBinario.inorden();
        }

        private void BtnPreOrden_Click(object sender, EventArgs e)
        {
            Preorden.Text = ArbolBinario.preorden();
        }

        private void BtnPosOrden_Click(object sender, EventArgs e)
        {
            Posorden.Text = ArbolBinario.postorden();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(ArbolBinario.Busqueda(int.Parse(txtBuscar.Text))==null)
            {
                MessageBox.Show("La informacion no se encuentra en el arbol");
            }
            else
            {
                MessageBox.Show("La informacion está en el arbol");
            }
            txtBuscar.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            txtEliminar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ArbolBinario.Eliminar(int.Parse(txtEliminar.Text)) == false)
            {
                MessageBox.Show("La informacion no se encuentra en el arbol");
            }
            else
            {
                MessageBox.Show("La informacion está en el arbol y ha sido eliminada");
                Inorden.Text = ArbolBinario.inorden();
                Preorden.Text = ArbolBinario.preorden();
                Posorden.Text = ArbolBinario.postorden();
            }
            txtEliminar.Clear();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
