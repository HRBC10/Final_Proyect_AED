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
    public partial class FrmAA1_Empleados : Form
    {
        public FrmAA1_Empleados()
        {
            InitializeComponent();
        }

        FrmMenu Volver;

        //VARIABLES GLOBALES
        int N = 0, Tam, i;

        //ESTRUCTURA DE DATOS A OCUPAR
        public struct Datos
        {
            public int NumeroHijos;
            public double Salario;
            public string Nombre;
            public string Apellido;
            public string Cedula;
            public string Ruta;
        }
        Datos[] Empleados;

        //FUNCION LIMPIAR CAJAS DE TEXTO
        void Limpiar()
        {
            txtCedula.Clear();
            txtSalario.Clear();
            txtHijos.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtRutaFoto.Clear();
        }
        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "validación";
            string message = string.Empty;

            if (txtCedula.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese La Cedula Del Empleado";
                MessageBox.Show(message, title);
            }

            if (txtNombre.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Nombre Del Empleado";
                MessageBox.Show(message, title);
            }

            if (txtApellido.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido Del Empleado";
                MessageBox.Show(message, title);
            }

            if (txtSalario.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Salario Del Empleado";
                MessageBox.Show(message, title);
            }

            if (txtHijos.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Numero De Hijos";
                MessageBox.Show(message, title);
            }

            if (txtRutaFoto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Foto Del Empleado";
                MessageBox.Show(message, title);
            }

            return flag;
        }

        private void FrmAA1_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos()==true)//VALIDACION AL INGRESAR DATOS EN CAJAS DE TEXTO
            {
                if (N <= Tam - 1)//VALIDACION PARA SABER SI HAY ESPACIO
                {
                    int i = 0;
                    string x;
                    x = txtCedula.Text;

                    while (i < N && x != Empleados[i].Cedula)//CICLO PARA BUSCAR LA POSICION DEL EMPLEADO
                    {
                        i = i + 1;
                    }
                    if (i >= N)//VALIDACION AL NO ENCONTRARSE AL EMPLEADO
                    {
                        Empleados[N].Cedula = txtCedula.Text;
                        Empleados[N].Nombre = txtNombre.Text;
                        Empleados[N].Apellido = txtApellido.Text;
                        Empleados[N].Salario = double.Parse(txtSalario.Text);
                        Empleados[N].NumeroHijos = int.Parse(txtHijos.Text);
                        Empleados[N].Ruta = txtRutaFoto.Text;

                        if (Empleados[i].NumeroHijos < 0)//VALIDACION
                        {
                            MessageBox.Show("El total de numeros de hijos no puede ser menor que 0",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (!(Empleados[i].Salario > 0))//VALIDACION
                        {
                            MessageBox.Show("El empleado no puede tener un salario menor o igual a 0",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else //MENSAJE AL INGRESAR CON EXITO AL EMPLEADO
                        {
                            N = N + 1;
                            MessageBox.Show("Empleado Ingresado");
                            Limpiar();
                            pbImagen.Visible = false;
                        }
                    }
                    else //SE ENCONTRO ID DEL EMPLEADO
                    {
                        MessageBox.Show("ID Ya Esta Registo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else//VALIDACION AL TENER REGISTROS LLENOS
                {
                    MessageBox.Show("Empleados Completos");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBCedula.Text != "") //VALIDACION AL INGRESAR DATOS EN CAJA DE TEXTO
            {
                //DECLARACION Y ASIGNACION DE VARIABLES
                int i = 0;
                string x;
                x = txtBCedula.Text;

                while (i < N && x != Empleados[i].Cedula)//CICLO PARA BUSCAR LA POSICION DEL EMPLEADO
                {
                    i = i + 1;
                }
                if (i >= N)//VALIDACION AL NO ENCONTRARSE AL EMPLEADO
                {
                    MessageBox.Show(x + " No esta registrado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else //SE ENCONTRO AL EMPLEADO
                {
                    lbImprimir.Items.Clear();
                    lbImprimir.Items.Add("Cedula" + "\t\t" + "Nombre" + "\t" + "Apellido" + "\t" +
                    "Salario" + "\t" + "N° Hijos");
                    lbImprimir.Items.Add(Empleados[i].Cedula + "\t" + Empleados[i].Nombre + "\t"
                    + Empleados[i].Apellido + "\t" + Empleados[i].Salario + "\t" + Empleados[i].NumeroHijos);
                    Limpiar();
                    pbImagen.Visible = true;
                    pbImagen.ImageLocation = Empleados[i].Ruta;
                }
            }
            else // VALIDACION AL NO INGRESAR DATOS EN CAJAS DE TEXTO
            {
                MessageBox.Show("No se ingreso ningun valor",
                "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            double Promedio_general = 0;
            double Promedio = 0;
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Cedula" + "\t\t" + "Nombre" + "\t" + "Apellido" + "\t" +
            "Salario" + "\t" + "N° Hijos");
            for (i = 0; i < N; i++)//CICLO PARA IMPRIMIR A LOS EMPLEADOS
            {
                lbImprimir.Items.Add(Empleados[i].Cedula + "\t" + Empleados[i].Nombre + "\t"
                + Empleados[i].Apellido + "\t" + Empleados[i].Salario + "\t" + Empleados[i].NumeroHijos);
                Promedio += Empleados[i].Salario;
            }
            Promedio_general = Promedio / N;
            txtPromedio.Text = Convert.ToString(Promedio_general);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtBCedula.Text != "") //VALIDACION AL INGRESAR DATOS EN CAJA DE TEXTO
            {
                //DECLARACION Y ASIGNACION DE VARIABLES 
                int i = 0;
                string x;
                x = txtBCedula.Text;

                while (i < N && x != Empleados[i].Cedula)//CICLO PARA BUSCAR LA POSICION DEL EMPLEADO
                {
                    i = i + 1;
                }
                if (i >= N)//VALIDACION AL NO ENCONTRARSE AL EMPLEADO
                {
                    MessageBox.Show(x + " No esta registrado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else//SE ENCONTRO AL EMPLEADO
                {
                    for (int k = i; k < N - 1; k++)//CICLO PARA ELIMINAR AL EMPLEADO
                    {
                        Empleados[k].Cedula = Empleados[k + 1].Cedula;
                        Empleados[k].Nombre = Empleados[k + 1].Nombre;
                        Empleados[k].Apellido = Empleados[k + 1].Apellido;
                        Empleados[k].Salario = Empleados[k + 1].Salario;
                        Empleados[k].NumeroHijos = Empleados[k + 1].NumeroHijos;
                        Empleados[k].Ruta = Empleados[k + 1].Ruta;
                    }

                    N = N - 1; //SE RESTA 1 POR QUE SE ACABA DE ELIMINAR UN EMPLEADO

                    MessageBox.Show("El Empleado con la Cedula = " + x + " Se ha Eliminado");
                    Limpiar();
                    pbImagen.Visible = false;
                }
            }
            else  //VALIDACION AL NO INGRESAR DATOS EN CAJA DE TEXTO
            {
                MessageBox.Show("No se ha ingresado ningun valor ",
                        "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAumentarSalario_Click(object sender, EventArgs e)
        {
            double Aumento = 0.1; //AUMENTO DE SALARIO EN 10%
            string EmpleadoSalarioMenorQueElPromedio = "";
            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Nombre" + "\t" + "Apellido" + "\t" + "Salario Aumentado");
            for (i = 0; i < N; i++)//CICLO PARA BUSCAR A LOS EMPLEADOS CON MENOR SUELDO
            {
                if (Convert.ToDouble(txtPromedio.Text) > Empleados[i].Salario) //CONDICION A CUMPLIR PARA AUMENTO
                {
                    EmpleadoSalarioMenorQueElPromedio = Empleados[i].Nombre + "\t" + Empleados[i].Apellido;
                    Empleados[i].Salario = Empleados[i].Salario + (Empleados[i].Salario * Aumento);
                    lbImprimir.Items.Add(EmpleadoSalarioMenorQueElPromedio + "\t" + Empleados[i].Salario);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" || txtSalario.Text != "")//VALIDACION SI LAS CAJAS DE TEXTO TIENEN DATOS
            {
                //DECLARACION Y ASIGNACION DE VARIABLES
                int i = 0;
                string x;
                x = txtCedula.Text;
                while (i < N && x != Empleados[i].Cedula)//CICLO PARA BUSCAR LA POSICION DEL ALUMNO
                {
                    i = i + 1;
                }
                if (i >= N)//VALIDACION AL NO ENCONTRARSE AL ALUMNO
                {
                    MessageBox.Show(x + " No esta registrado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else// SE ENCONTRO AL ALUMNO
                {
                    if (txtSalario.Text != "") //VALIDACION SI CAJA DE TEXTO TIENE DATOS
                    {
                        Empleados[i].Salario = double.Parse(txtSalario.Text);
                        MessageBox.Show("El salario del empleado con cedula = " + x + " Se ha Modificado");
                        Limpiar();
                    }
                    else //VALIDACION SI CAJA DE TEXTO NO TIENE DATOS
                    {
                        MessageBox.Show("No se ingreso un valor en la sección Salario",
                            "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            else //VALIDACION SI LAS CAJAS DE TEXTO  NO TIENEN DATOS
            {
                MessageBox.Show("No ha ingresado ningun valor",
                            "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "") //VALIDACION AL INGRESAR DATOS EN CAJA DE TEXTO
            {
                Tam = int.Parse(txtCantidad.Text);
                Empleados = new Datos[Tam]; //ASIGNANDO EL TAMAÑO A TODA LA ESTRUCTURA DE DATOS
                N = 0;
                MessageBox.Show("Cantidad de empleados ha ingresar =" + Tam);
            }
            else //VALIDACION AL NO INGRESAR DATOS EN CAJA DE TEXTO
            {
                MessageBox.Show("No ha ingresado un valor",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
