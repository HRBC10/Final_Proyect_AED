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
    public partial class FrmAA2_EntregaDeProyectos : Form
    {
        public FrmAA2_EntregaDeProyectos()
        {
            InitializeComponent();
        }
        FrmMenu Volver;
        public struct Estudiantes
        {
            public int Carnet;
            public string Nombre;
            public string Apellido;
            public string Proyecto;
            public int Calificacion;
            public string Ruta;
            public DateTime FechaLimite;
            public DateTime FechaEntrega;
        }
        Estudiantes[] Instancia;

        //VARIABLES GLOBALES
        int N = 0, Tam, i, Pos, x, x2=0;

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tam = int.Parse(txtCantidad.Text);
                Instancia = new Estudiantes[Tam];
                MessageBox.Show("Cantidad de almunos ha ingresar =" + Tam);
                N = 0;
            }
        }

        private void cbCImagen_Click(object sender, EventArgs e)
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

        void Limpiar()
        {
            txtCarnet.Text = string.Empty;
            txtNombreEstudiante.Text = string.Empty;
            txtApellidoEstudiante.Text = string.Empty;
            txtProyectoNombre.Text = string.Empty;
            txtFechaEntrega.Text = string.Empty;
            txtRutaFoto.Text = string.Empty;
            txtFechaLimite.Text = string.Empty;
            txtCalificacion.Text = string.Empty;
        }
        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validación";
            string message = string.Empty;

            if (txtCarnet.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Id";
                MessageBox.Show(message, title);
            }

            if (txtNombreEstudiante.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (txtApellidoEstudiante.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido";
                MessageBox.Show(message, title);
            }

            if (txtProyectoNombre.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Nombre Del Proyecto";
                MessageBox.Show(message, title);
            }

            if (txtFechaEntrega.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Fecha De Entrega";
                MessageBox.Show(message, title);
            }

            if (txtRutaFoto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Ruta De La Foto";
                MessageBox.Show(message, title);
            }

            if (txtFechaLimite.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Fecha Limite";
                MessageBox.Show(message, title);
            }

            if (txtCalificacion.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Calificación";
                MessageBox.Show(message, title);
            }

            return flag;
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if(ValidaCamapos()==true)
            {
                if(int.Parse(txtCalificacion.Text)<=100 && int.Parse(txtCalificacion.Text) >=0)
                {
                    x = int.Parse(txtCarnet.Text);
                    Insertar(x);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Digite La Calificación Correctamente","Validacion");
                }
            }
        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            Listar();
        }

        void Listar()
        {
            //VARIABLES LOCALES
            string FechaEntrega, FechaLimite;
            lbImprimir.Items.Clear();//LIMPIAR LISTBOX
            lbImprimir.Items.Add("Carnet" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" + "Proyecto" + "\t\t"
            + "Fecha Entrega" + "\t" + "Fecha Limite" + "\t" + "Calificacion");//TITULO

            for (i = 0; i < N; i++)//CICLO PARA RECORRER ARREGLO
            {
                FechaEntrega = Instancia[i].FechaEntrega.ToString("dd/MM/yyyy");//ASIGNACION DE FORMATO DE FECHA AL GUSTO
                FechaLimite = Instancia[i].FechaLimite.ToString("dd/MM/yyyy");//ASIGNACION DE FORMATO DE FECHA AL GUSTO
                lbImprimir.Items.Add(Instancia[i].Carnet + "\t" + Instancia[i].Nombre + "\t" + Instancia[i].Apellido + "\t" +
                Instancia[i].Proyecto + "\t" + FechaEntrega + "\t\t" + FechaLimite + "\t\t" + Instancia[i].Calificacion);
            }
        }

        private void btnProyectosAtrasados_Click(object sender, EventArgs e)
        {
            //VARIABLES LOCALES
            string FechaEntrega, FechaLimite;
            lbImprimir.Items.Clear();//LIMPIAR LISTBOX
            lbImprimir.Items.Add("Carnet" + "\t\t" + "Nombre" + "\t" + "Apellido" + "\t" + "Proyecto" + "\t\t"
            + "Fecha de Entrega" + "\t" + " Fecha Limite de Entrega" + "\t" + "Calificacion");//TITULO
            for (i = 0; i < N; i++)//CICLO PARA RECORRER ARREGLO
            {
                if (Instancia[i].FechaEntrega > Instancia[i].FechaLimite)//SI FECHA DE ENTREGA ES MAYOR A LA FECHA LIMITE
                {
                    FechaEntrega = Instancia[i].FechaEntrega.ToString("dd/MM/yyyy");//ASIGNACION DE FORMATO DE FECHA AL GUSTO
                    FechaLimite = Instancia[i].FechaLimite.ToString("dd//MM/yyyy");//ASIGNACION DE FORMATO DE FECHA AL GUSTO
                    lbImprimir.Items.Add(Instancia[i].Carnet + "\t" + Instancia[i].Nombre + "\t" + Instancia[i].Apellido + "\t" +
                    Instancia[i].Proyecto + "\t" + FechaEntrega + "\t" + FechaLimite + "\t\t" + Instancia[i].Calificacion);
                }
            }
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio");
            }
            else
            {

                int x = int.Parse(txtBId.Text);
                Pos = Busca(x);
                if (Pos >= 0)
                {
                    //VARIABLES LOCALES
                    string FechaEntrega, FechaLimite;
                    lbImprimir.Items.Clear();//LIMPIAR LISTBOX
                    lbImprimir.Items.Clear();//LIMPIAR LISTBOX
                    lbImprimir.Items.Add("Carnet" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" + "Proyecto" + "\t\t"
                    + "Fecha Entrega" + "\t" + "Fecha Limite" + "\t" + "Calificacion");//TITULO

                    FechaEntrega = Instancia[Pos].FechaEntrega.ToString("dd/MM/yyyy");//ASIGNACION DE FORMATO DE FECHA AL GUSTO
                    FechaLimite = Instancia[Pos].FechaLimite.ToString("dd/MM/yyyy");//ASIGNACION DE FORMATO DE FECHA AL GUSTO
                    lbImprimir.Items.Add(Instancia[Pos].Carnet + "\t" + Instancia[Pos].Nombre + "\t" + Instancia[Pos].Apellido + "\t" +
                    Instancia[Pos].Proyecto + "\t" + FechaEntrega + "\t\t" + FechaLimite + "\t\t" + Instancia[Pos].Calificacion);
                    pbImagen.Visible = true;
                    pbImagen.ImageLocation = Instancia[Pos].Ruta;
                }
                else
                {
                    MessageBox.Show("Deudor No Registrado");
                }
            }
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio");
            }
            else
            {
                int x = int.Parse(txtBId.Text);
                Eliminar(x);
                Limpiar();
            }
        }

        private void btnModificarProyecto_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() == true)
            {
                int x = int.Parse(txtCarnet.Text);
                Actualizar(x);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBId_KeyPress(object sender, KeyPressEventArgs e)
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

        public int Busca(int x)
        {
            i = 0;
            while (i < N && Instancia[i].Carnet < x)
            {
                i = i + 1;
            }
            if (i >= N || Instancia[i].Carnet > x)
            {
                Pos = -i;
            }
            else
            {

                Pos = i;
            }
            return Pos;
        }
        void Eliminar(int x)
        {
            if (N > 0)
            {
                //x = int.Parse(txtId.Text);
                Pos = Busca(x);
                if (Pos <= -1)
                {
                    MessageBox.Show(x + " No está Registrado");
                }
                else
                {
                    for (i = Pos; i < N - 1; i++)
                    {
                        Instancia[i].Carnet = Instancia[i + 1].Carnet;
                        Instancia[i].Nombre = Instancia[i + 1].Nombre;
                        Instancia[i].Apellido = Instancia[i + 1].Apellido;
                        Instancia[i].Proyecto = Instancia[i + 1].Proyecto;
                        Instancia[i].FechaEntrega = Instancia[i + 1].FechaEntrega;
                        Instancia[i].FechaLimite = Instancia[i + 1].FechaLimite;
                        Instancia[i].Calificacion = Instancia[i + 1].Calificacion;
                        Instancia[i].Ruta = Instancia[i + 1].Ruta;
                    }
                    N = N - 1;
                    MessageBox.Show("La persona con Id=" + x + " se ha eliminada");
                }
            }
            else
            {
                MessageBox.Show("No hay Registros");
            }
        }
        void Insertar(int x)
        {
            if (N > 0)
            {
                if (N <= Tam - 1)
                {
                    Pos = Busca(x);
                    if (Pos > 0)
                    {
                        MessageBox.Show("El elemento ya existe");
                    }
                    else
                    {
                        Pos = Pos * -1;
                        for (i = N; i >= Pos + 1; i--)
                        {
                            Instancia[i].Carnet = Instancia[i - 1].Carnet;
                            Instancia[i].Nombre = Instancia[i - 1].Nombre;
                            Instancia[i].Apellido = Instancia[i - 1].Apellido;
                            Instancia[i].Proyecto = Instancia[i - 1].Proyecto;
                            Instancia[i].FechaEntrega = Instancia[i - 1].FechaEntrega;
                            Instancia[i].FechaLimite = Instancia[i - 1].FechaLimite;
                            Instancia[i].Calificacion = Instancia[i - 1].Calificacion;
                            Instancia[i].Ruta = Instancia[i - 1].Ruta;
                        }
                        Instancia[Pos].Carnet = int.Parse(txtCarnet.Text);
                        Instancia[Pos].Nombre = txtNombreEstudiante.Text;
                        Instancia[Pos].Apellido = txtApellidoEstudiante.Text;
                        Instancia[Pos].Proyecto = txtProyectoNombre.Text;
                        Instancia[Pos].FechaEntrega = DateTime.Parse(txtFechaEntrega.Text);
                        Instancia[Pos].FechaLimite = DateTime.Parse(txtFechaLimite.Text);
                        Instancia[Pos].Calificacion = int.Parse(txtCalificacion.Text);
                        Instancia[Pos].Ruta = txtRutaFoto.Text;
                        N = N + 1;
                        pbImagen.Visible = false;
                        MessageBox.Show("Elemento Insertado");
                    }
                }
                else
                {
                    MessageBox.Show("No hay espacio");
                }
            }
            else
            {
                Instancia[N].Carnet = int.Parse(txtCarnet.Text);
                Instancia[N].Nombre = txtNombreEstudiante.Text;
                Instancia[N].Apellido = txtApellidoEstudiante.Text;
                Instancia[N].Proyecto = txtProyectoNombre.Text;
                Instancia[N].FechaEntrega = DateTime.Parse(txtFechaEntrega.Text);
                Instancia[N].FechaLimite = DateTime.Parse(txtFechaLimite.Text);
                Instancia[N].Calificacion = int.Parse(txtCalificacion.Text);
                Instancia[N].Ruta = txtRutaFoto.Text;
                N = N + 1;
                MessageBox.Show("Elemento Insertado");
                pbImagen.Visible = false;
            }
        }

        void Actualizar(int x)
        {
            //Pos = Pos * -1;
            x = int.Parse(txtCarnet.Text);
            if (Pos == 0)
            {
                if (x > Instancia[Pos + 1].Carnet)
                {
                    Eliminar(x2);
                    Insertar(x);
                }
                else
                {
                    Instancia[Pos].Carnet = int.Parse(txtCarnet.Text);
                    Instancia[Pos].Nombre = txtNombreEstudiante.Text;
                    Instancia[Pos].Apellido = txtApellidoEstudiante.Text;
                    Instancia[Pos].Proyecto = txtProyectoNombre.Text;
                    Instancia[Pos].FechaEntrega = DateTime.Parse(txtFechaEntrega.Text);
                    Instancia[Pos].FechaLimite = DateTime.Parse(txtFechaLimite.Text);
                    Instancia[Pos].Calificacion = int.Parse(txtCalificacion.Text);
                    Instancia[Pos].Ruta = txtRutaFoto.Text;
                    MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                    pbImagen.Visible = false;
                }

            }
            else
            {
                if (Pos == N - 1)
                {
                    if (x < Instancia[Pos - 1].Carnet)
                    {
                        Eliminar(x2);
                        Insertar(x);
                    }
                    else
                    {
                        Instancia[Pos].Carnet = int.Parse(txtCarnet.Text);
                        Instancia[Pos].Nombre = txtNombreEstudiante.Text;
                        Instancia[Pos].Apellido = txtApellidoEstudiante.Text;
                        Instancia[Pos].Proyecto = txtProyectoNombre.Text;
                        Instancia[Pos].FechaEntrega = DateTime.Parse(txtFechaEntrega.Text);
                        Instancia[Pos].FechaLimite = DateTime.Parse(txtFechaLimite.Text);
                        Instancia[Pos].Calificacion = int.Parse(txtCalificacion.Text);
                        Instancia[Pos].Ruta = txtRutaFoto.Text;
                        MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                        pbImagen.Visible = false;
                    }

                }

                else
                {
                    if ((x > Instancia[Pos + 1].Carnet) || (x < Instancia[Pos - 1].Carnet))
                    {
                        Eliminar(x2);
                        Insertar(x);

                    }
                    else
                    {
                        Instancia[Pos].Carnet = int.Parse(txtCarnet.Text);
                        Instancia[Pos].Nombre = txtNombreEstudiante.Text;
                        Instancia[Pos].Apellido = txtApellidoEstudiante.Text;
                        Instancia[Pos].Proyecto = txtProyectoNombre.Text;
                        Instancia[Pos].FechaEntrega = DateTime.Parse(txtFechaEntrega.Text);
                        Instancia[Pos].FechaLimite = DateTime.Parse(txtFechaLimite.Text);
                        Instancia[Pos].Calificacion = int.Parse(txtCalificacion.Text);
                        Instancia[Pos].Ruta = txtRutaFoto.Text;
                        MessageBox.Show("La persona con Id =" + x + " se ha actualizado");
                        pbImagen.Visible = false;
                    }
                }
            }
        }
        private void FrmAA2_EntregaDeProyectos_Load(object sender, EventArgs e)
        {
        }
    }
}
