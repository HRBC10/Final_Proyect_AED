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
    public partial class FrmAA1_Alumnos : Form
    {
        public FrmAA1_Alumnos()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        //VARIABLES GLOBALES
        int N = 0, Tam, i;
        string[] Carnet;
        string[] Nombre;
        string[] Apellido;
        string[] Ruta;
        int[] Primer_Parcial;
        int[] Segundo_Parcial;
        int[] Sistem;
        int[] Proyecto;
        int[] Nota_Final;
        double Promedio;

        //FUNCION LIMPIAR CAJAS DE TEXTO
        void Limpiar()
        {
            txtCarnet.Clear();
            txtIParcial.Clear();
            txtIIParcial.Clear();
            txtSistem.Clear();
            txtProyecto.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtProyecto.Clear();
            txtRutaFoto.Clear();
        }

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "validación";
            string message = string.Empty;

            if (txtCarnet.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Carnet Del Estudiante";
                MessageBox.Show(message, title);
            }

            if (txtNombre.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nombre Del Estudiante";
                MessageBox.Show(message, title);
            }

            if (txtApellido.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido Del Estudiante";
                MessageBox.Show(message, title);
            }

            if (txtIParcial.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nota I Parcial Del Estudiante";
                MessageBox.Show(message, title);
            }

            if (txtIIParcial.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nota II Parcial Del Estudiante";
                MessageBox.Show(message, title);
            }
            if (txtSistem.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nota De Sistematicos Del Estudiante";
                MessageBox.Show(message, title);
            }

            if (txtProyecto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nota De Proyecto Final Del Estudiante";
                MessageBox.Show(message, title);
            }

            if (txtRutaFoto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Foto Del Estudiante";
                MessageBox.Show(message, title);
            }

            return flag;
        }

        private void FrmAA1_Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void txtEstablecer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIIParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEstablcer_Click(object sender, EventArgs e)
        {
            if (txtEstablecer.Text != "")//VALIDACION SI LA CAJA DE TEXTO TIENE DATOS
            {
                //ESTABLECIENDO EL TAMAÑO DE LOS ARREGLOS SEGUN EL USUARIO
                Tam = int.Parse(txtEstablecer.Text);
                Carnet = new string[Tam];
                Primer_Parcial = new int[Tam];
                Segundo_Parcial = new int[Tam];
                Sistem = new int[Tam];
                Proyecto = new int[Tam];
                Nota_Final = new int[Tam];
                Nombre = new string[Tam];
                Apellido = new string[Tam];
                Ruta = new string[Tam];
                N = 0;
                MessageBox.Show("Cantidad de almunos ha ingresar =" + Tam);
            }
            else //VALIDACION SI LA CAJA DE TEXTO NO TIENE DATOS
            {
                MessageBox.Show("No ha ingresado un valor",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos()==true) //VALIDACION AL INGRESAR DATOS EN CAJAS DE TEXTO
            { 
                if (N <= Tam - 1) //VALIDACION PARA SABER SI HAY ESPACIO
                {
                    int i = 0;
                    string x;
                    x = txtCarnet.Text;
                    while (i < N && x != Carnet[i])//CICLO PARA BUSCAR LA POSICION DEL ALUMNO
                    {
                        i = i + 1;
                    }
                    if (i >= N)//VALIDACION AL NO ENCONTRAR AL ALUMNO
                    {
                        Carnet[N] = txtCarnet.Text;
                        Nombre[N] = txtNombre.Text;
                        Apellido[N] = txtApellido.Text;
                        Primer_Parcial[N] = int.Parse(txtIParcial.Text);
                        Segundo_Parcial[N] = int.Parse(txtIIParcial.Text);
                        Sistem[N] = int.Parse(txtSistem.Text);
                        Proyecto[N] = int.Parse(txtProyecto.Text);
                        Ruta[N] = txtRutaFoto.Text;

                        Nota_Final[N] = Primer_Parcial[N] + Segundo_Parcial[N] + Sistem[N] + Proyecto[N];

                        if (Primer_Parcial[i] < 0 || Primer_Parcial[i] > 30) //VALIDACION
                        {
                            MessageBox.Show("La nota del primer parcial debe de ser menor o igual que 30 y mayor que 0",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (Segundo_Parcial[i] < 0 || Segundo_Parcial[i] > 30)//VALIDACION
                        {
                            MessageBox.Show("La nota del segundo parcial debe de ser menor o igual que 30 y mayor que 0",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (Sistem[i] < 0 || Sistem[i] > 10)//VALIDACION
                        {
                            MessageBox.Show("La nota de los sistemáticos debe de ser menor o igual que 10 y mayor que 0",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (Proyecto[i] < 0 || Proyecto[i] > 30)//VALIDACION
                        {
                            MessageBox.Show("La nota del proyecto debe de ser menor o igual que 30 y mayor que 0",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else //MENSAJE AL INGRESAR CON EXITO AL ALUMNO
                        {
                            N = N + 1;
                            MessageBox.Show("Alumno Ingresado");
                            Limpiar();
                            pbImagen.Visible = false;
                        }
                    }
                    else //SE ENCONTRO AL ALUMNO
                    {
                        MessageBox.Show("ID Ya Esta Registo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else //VALIDACION AL TENER REGISTROS LLENOS

                {
                    MessageBox.Show("Alumnos Completos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES PARA EL PROMEDIO DE NOTAS DE TODOS LOS ESTUDIANTES
            double Promedio_General;
            Promedio_General = 0;
            Promedio = 0;
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Carnet" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" +
            "IP" + "\t" + "IIP" + "\t" + "Sist" + "\t" + "PC" + "\t" + "NF");

            for (i = 0; i < N; i++) //CICLO PARA IMPRIMIR A LOS ALUMNOS REGISTRADOS
            {

                lbImprimir.Items.Add(Carnet[i] + "\t" + Nombre[i] + "\t" + Apellido[i] +
                "\t" + Primer_Parcial[i] + "\t" + Segundo_Parcial[i]
                + "\t" + Sistem[i] + "\t" + Proyecto[i] + "\t" + Nota_Final[i]);
                Promedio += Nota_Final[i];
            }
            Promedio_General = Promedio / N;
            txtPromedio.Text = Convert.ToString(Promedio_General);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBCarnet.Text != "")//VALIDACION AL INGRESAR DATOS EN CAJA DE TEXTO
            {
                //DECLARACION Y ASIGNACION DE VARIABLES
                int i = 0;
                string x;
                x = txtBCarnet.Text;
                while (i < N && x != Carnet[i])//CICLO PARA BUSCAR LA POSICION DEL ALUMNO
                {
                    i = i + 1;
                }
                if (i >= N)//VALIDACION AL NO ENCONTRAR AL ALUMNO
                {
                    MessageBox.Show(" Estudiante No Registrado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else //SE ENCONTRO AL ALUMNO
                {
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add("Carnet" + "\t\t" + "Nombre" + "\t" + "Apellido" + "\t" +
                    "IP" + "\t" + "IIP" + "\t" + "Sist" + "\t" + "PC" + "\t" + "NF");
                    lbImprimir.Items.Add(Carnet[i] + "\t" + Nombre[i] + "\t" + Apellido[i] +
                    "\t" + Primer_Parcial[i] + "\t" + Segundo_Parcial[i]
                    + "\t" + Sistem[i] + "\t" + Proyecto[i] + "\t" + Nota_Final[i]);

                    pbImagen.Visible = true;
                    pbImagen.ImageLocation = Ruta[i];
                    Limpiar();
                }
            }
            else //VALIDACION AL NO INGRESAR DATOS EN CAJAS DE TEXTO
            {
                MessageBox.Show("No se ingreso un valor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtBCarnet.Text != "")//VALIDACION AL INGRESAR DATOS EN CAJA DE TEXTO
            {
                //DECLARACION Y ASIGNACION DE VARIABLES 
                int i = 0;
                string x;

                x = txtBCarnet.Text;

                while (i < N && x != Carnet[i])//CICLO PARA BUSCAR LA POSICION DEL ALUMNO
                {
                    i = i + 1;
                }
                if (i >= N)//VALIDACION AL NO ENCONTRARSE AL ALUMNO
                {
                    MessageBox.Show(" No esta registrado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else //SE ENCONTRO AL ALUMNO
                {
                    for (int k = i; k < N - 1; k++)//CICLO PARA ELIMINAR AL ALUMNO
                    {
                        Carnet[k] = Carnet[k + 1];
                        Primer_Parcial[k] = Primer_Parcial[k + 1];
                        Segundo_Parcial[k] = Segundo_Parcial[k + 1];
                        Sistem[k] = Sistem[k + 1];
                        Proyecto[k] = Proyecto[k + 1];
                        Nota_Final[k] = Nota_Final[k + 1];
                        Nombre[k] = Nombre[k + 1];
                        Apellido[k] = Apellido[k + 1];
                        Ruta[k] = Ruta[k + 1];
                        Nota_Final[k] = Nota_Final[k + 1];
                        Nota_Final[k + 1] = Primer_Parcial[k + 1] + Segundo_Parcial[k + 1]
                        + Sistem[k + 1] + Proyecto[k + 1];

                    }
                    N = N - 1; //SE RESTA 1 POR QUE SE ACABA DE ELIMINAR UN ALUMNO 

                    MessageBox.Show("El Estudiante con el Carnet = " + x + " Se ha Eliminado");
                    Limpiar();
                    pbImagen.Visible = false;
                }
            }
            else //VALIDACION AL NO INGRESAR DATOS EN CAJA DE TEXTO
            {
                MessageBox.Show("No ha ingresado un valor",
                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos()==true) //VALIDACION SI LAS CAJAS DE TEXTO TIENEN DATOS
            {
                //DECLARACION Y ASIGNACION DE VARIABLES
                int i = 0;
                string x;
                x = txtCarnet.Text;
                while (i < N && x != Carnet[i])//CICLO PARA BUSCAR LA POSICION DEL ALUMNO
                {
                    i = i + 1;
                }
                if (i >= N)//VALIDACION AL NO ENCONTRARSE AL ALUMNO
                {
                    MessageBox.Show("No Esta Registrado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else // SE ENCONTRO AL ALUMNO 
                {
                    Primer_Parcial[i] = int.Parse(txtIParcial.Text);
                    Segundo_Parcial[i] = int.Parse(txtIIParcial.Text);
                    Sistem[i] = int.Parse(txtSistem.Text);
                    Proyecto[i] = int.Parse(txtProyecto.Text);
                    Ruta[i] = txtRutaFoto.Text;
                    Nota_Final[i] = Primer_Parcial[i] + Segundo_Parcial[i] + Sistem[i] + Proyecto[i];

                    if (Primer_Parcial[i] < 0 || Primer_Parcial[i] > 30)//VALIDACION
                    {
                        MessageBox.Show("La nota del primer parcial debe de ser menor o igual que 30 y mayor que 0",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Segundo_Parcial[i] < 0 || Segundo_Parcial[i] > 30)//VALIDACION
                    {
                        MessageBox.Show("La nota del segundo parcial debe de ser menor o igual que 30 y mayor que 0",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Sistem[i] < 0 || Sistem[i] > 10)//VALIDACION
                    {
                        MessageBox.Show("La nota de los sistemáticos debe de ser menor o igual que 10 y mayor que 0",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Proyecto[i] < 0 || Proyecto[i] > 30)//VALIDACION
                    {
                        MessageBox.Show("La nota del proyecto debe de ser menor o igual que 30 y mayor que 0",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else //MENSAJE AL MODIFICAR AL ALUMNO
                    {
                        MessageBox.Show("El Estudiante con el Carnet = " + x + " Se ha Modificado");
                        Limpiar();
                    }
                }
            }
        }

        private void btnMejorAlumno_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            int Comparacion = 0;
            string Mejor_Alumno = "";
            pbImagen.Visible = true;
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Nombre" + "\t" + "Apellido" + "\t" + "NF");
            for (i = 0; i < N; i++) //CICLO PARA BUSCAR AL ALUMNO
            {
                if (Comparacion < Nota_Final[i]) //CONDICION PARA SACAR AL MEJOR ALUMNO
                {
                    Mejor_Alumno = Nombre[i] + "\t" + Apellido[i];
                    Comparacion = Nota_Final[i];
                    pbImagen.ImageLocation = Ruta[i];
                }
            }
            lbImprimir.Items.Add(Mejor_Alumno + "\t" + Comparacion);
        }


        private void btnCImagen_Click(object sender, EventArgs e)
        {

                pbImagen.Visible = true;
                string Rutafoto = string.Empty;
                OpenFileDialog AbrirImagen = new OpenFileDialog();
                AbrirImagen.InitialDirectory = "C:\\";
                if (AbrirImagen.ShowDialog() == DialogResult.OK)
                {
                    pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                    pbImagen.ImageLocation = AbrirImagen.FileName;
                    Rutafoto = AbrirImagen.FileName;
                }
                txtRutaFoto.Text = Rutafoto;
                AbrirImagen.Dispose();

        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void txtSistem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
