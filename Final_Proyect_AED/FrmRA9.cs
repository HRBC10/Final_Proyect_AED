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
    public partial class FrmRA9 : Form
    {
        public FrmRA9()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        List<ClssEstudianteRA9> ListaEstudiante = new List<ClssEstudianteRA9>();
        List<ClssDocenteRA9> ListaDocente = new List<ClssDocenteRA9>();

        private bool ValidaCamaposE()
        {
            bool flag = true;
            string title = "Validacion";
            string message = string.Empty;


            if (TxtNombreE.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (TxtApellidoE.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido";
                MessageBox.Show(message, title);
            }

            if (TxtTelefonoE.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Telefono";
                MessageBox.Show(message, title);
            }

            if (TxtañoE.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Año";
                MessageBox.Show(message, title);
            }

            if (TxtCarrerasE.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Carrera";
                MessageBox.Show(message, title);
            }
            if (TxtBecaE.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Beca";
                MessageBox.Show(message, title);
            }
            return flag;
        }
        private bool ValidaCamaposD()
        {
            bool flag = true;
            string title = "Validacion";
            string message = string.Empty;


            if (TxtNombreD.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (TxtApellidoD.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido";
                MessageBox.Show(message, title);
            }

            if (TxtTelefonoD.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Telefono";
                MessageBox.Show(message, title);
            }

            if (TxtañoD.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Año";
                MessageBox.Show(message, title);
            }
            if (TxtSalarioD.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Salario";
                MessageBox.Show(message, title);
            }
            return flag;
        }
        private void BtonIngresarE_Click(object sender, EventArgs e)
        {
            if(ValidaCamaposE()==true)
            {
                ListaEstudiante.Add(
                new ClssEstudianteRA9
                {
                    EONombres = TxtNombreE.Text,
                    EOApellidos = TxtApellidoE.Text,
                    EOTelefono = int.Parse(TxtTelefonoE.Text),
                    EOAño = int.Parse(TxtañoE.Text),
                    EOCarrera = TxtCarrerasE.Text,
                    EOTipobeca = TxtBecaE.Text,

                });
                ImprimirE.DataSource = null;
                ImprimirE.DataSource = ListaEstudiante;
            }
        }

        private void Btningresa_Click(object sender, EventArgs e)
        {
            if(ValidaCamaposD()==true)
            {
                ClssDocenteRA9 Instancia = new ClssDocenteRA9();
                Instancia.EONombres = TxtNombreD.Text;
                Instancia.EOApellidos = TxtApellidoD.Text;
                Instancia.EOTelefono = int.Parse(TxtTelefonoD.Text);
                Instancia.EOFacultad = TxtCarrerasD.Text;
                Instancia.EOAño = int.Parse(TxtañoD.Text);
                Instancia.EOSalario = double.Parse(TxtSalarioD.Text);
                ListaDocente.Add(Instancia);
                ImprimirD.DataSource = null;
                ImprimirD.DataSource = ListaDocente;
            }
        }

        private void FrmRA9_Load(object sender, EventArgs e)
        {
            ClssDocenteRA9 Instancia1 = new ClssDocenteRA9(); //llenó la lista llamada Facultades
            TxtCarrerasD.DataSource = Instancia1.OFacultades();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void TxtTelefonoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtañoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtañoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTelefonoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSalarioD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
