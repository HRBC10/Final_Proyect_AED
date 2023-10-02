using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace Final_Proyect_AED
{
    public partial class FrmAA5_Directorio : Form
    {
        public FrmAA5_Directorio()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        Stack<String> Pilas = new Stack<String>();
        String Directorio;
        String[] Directorio2 = new String[20];
        String Direccion, Buscar, Anexar, UltimoStringAnexo, Construir;
        int i = 0, j = 0;

        int PilasBuscar(String Direccion)
        {
            int acceso;
            acceso = lbPilas.Items.IndexOf(Direccion);
            if (acceso != -1)
            {
                return acceso;
            }
            else
            {
                return -99;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPilas.Text != string.Empty)
            {
                Pilas.Push(System.Convert.ToString(txtPilas.Text));
                lbPilas.Items.Insert(0, Pilas.Pop());
                if (i == 0)
                {
                    Directorio = txtPilas.Text + ":";
                    Directorio2[i] = txtPilas.Text + ":";
                }
                else
                {
                    Directorio = Directorio + "\\" + txtPilas.Text;
                    Directorio2[i] = Directorio2[i] + "\\" + txtPilas.Text;
                }
                i++;
                txtPilas.Clear();
                txtPilas.Focus();
                txtDirectorio.Clear();
                txtDirectorio.Text = Directorio;
            }
            else
            {
                MessageBox.Show("Campo Vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volver = new FrmMenu();
            Volver.Show();

        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            String Carpeta = Directorio;
            try
            {
                if (Directory.Exists(Carpeta))
                {
                    MessageBox.Show("Carpeta Existente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("creando Carpeta...");
                    Directory.CreateDirectory(Carpeta);
                }
                Process.Start("explorer.exe", Directorio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int acceso;
                Direccion = txtBuscar.Text;
                acceso = PilasBuscar(Direccion);
                if (acceso != -99)
                {
                    if (acceso == 0)
                    {
                        for (int a = acceso; a < i; a++)
                        {
                            Buscar = Buscar + Directorio2[a];
                        }
                    }
                    else
                    {
                        for (int a = 0; a < i - acceso; a++)
                        {
                            Buscar = Buscar + Directorio2[a];
                        }
                    }
                    MessageBox.Show(Buscar);
                }
                else
                {
                    MessageBox.Show("No se encontro elemento");
                    txtBuscar.Text = "";
                }
                Buscar = "";
            }
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            if (txtAñadir.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Anexo; int acceso;
                UltimoStringAnexo = Anexo = txtAñadir.Text;
                acceso = PilasBuscar(Anexo);
                if (acceso != -99)
                {
                    lbConstruir.Items.Insert(0, Anexo);
                    if (j == 0)
                    {
                        Anexar = txtAñadir.Text + ":";
                        txtAñadir.Text = "";
                    }
                    else
                    {
                        Anexar = Anexar + "\\" + txtAñadir.Text;
                        txtAñadir.Text = "";
                    }
                    j++;
                }
                else
                {
                    MessageBox.Show("No se encontro elemento");
                    UltimoStringAnexo = "";
                    txtAñadir.Text = "";
                }
            }
        }

        private void btnConstruir_Click(object sender, EventArgs e)
        {
            if (Anexar != "")
            {
                int acceso;
                acceso = PilasBuscar(UltimoStringAnexo);
                if (acceso == 0)
                {
                    for (int a = acceso; a < i; a++)
                    {
                        Construir = Construir + Directorio2[a];
                    }
                }
                else
                {
                    for (int a = 0; a < i - acceso; a++)
                    {
                        Construir = Construir + Directorio2[a];
                    }
                }
                if (Anexar != Construir)
                {
                    MessageBox.Show("El acceso construido no esta bien estructurado (No hay ruta): " + Anexar);
                }
                else
                {
                    MessageBox.Show("La ruta existe en la pilas: " + Anexar);
                }
            }
            else
            {
                MessageBox.Show("No ha creado una ruta");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbConstruir.Items.Clear();
            Construir = "";
            txtAñadir.Clear();
            Anexar = "";
            j = 0;
        }
    }
}
