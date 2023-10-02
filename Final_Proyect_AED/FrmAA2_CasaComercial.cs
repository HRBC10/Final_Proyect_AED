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
    public partial class FrmAA2_CasaComercial : Form
    {
        public FrmAA2_CasaComercial()
        {
            InitializeComponent();
        }

        FrmMenu Volver;
        public struct Deudores
        {
            public int Id;
            public String Nombre;
            public string Apellido;
            public double Deuda;
            public int Telefono;
            public String Direccion;
            public bool Estado;
            public string Ruta;
        }
        Deudores[] Instancia;

        //VARIABLES GLOBALES
        int N = 0, Tam, i, Pos, x=0, x2=0;

        void Limpiar()
        {
            txtId.Text = string.Empty;
            txtNombreDeudores.Text = string.Empty;
            txtApellidoDeudores.Text = string.Empty;
            txtDireccionDeudores.Text = String.Empty;
            txtDireccionDeudores.Text = string.Empty;
            txtTelefonoDeudores.Text = string.Empty;
            txtDeudaDeudores.Text = string.Empty;
            txtRutaFoto.Text = string.Empty;
        }
        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Validación";
            string message = string.Empty;

            if (txtId.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el Id";
                MessageBox.Show(message, title);
            }

            if (txtNombreDeudores.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (txtApellidoDeudores.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Apellido";
                MessageBox.Show(message, title);
            }

            if (txtDireccionDeudores.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Dirección";
                MessageBox.Show(message, title);
            }

            if (txtTelefonoDeudores.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese El Nombre";
                MessageBox.Show(message, title);
            }

            if (txtRutaFoto.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Ruta De La Foto";
                MessageBox.Show(message, title);
            }

            if (txtDeudaDeudores.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese La Deuda";
                MessageBox.Show(message, title);
            }

            if (cbEstadoDeuda.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese Estado De Deuda";
                MessageBox.Show(message, title);
            }

            return flag;
        }

        private void btnAgregarDeudores_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() == true)
            {
                x = int.Parse(txtId.Text);
                Insertar(x);
                Limpiar();
                lbImprimir.Items.Clear();
            }
        }

        private void btnModificarDeudores_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos()==true)
            {
                int x = int.Parse(txtId.Text);
                Actualizar(x);
            }
        }

        private void btnBuscarDeudores_Click(object sender, EventArgs e)
        {
            if(txtBId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio");
            }
            else
            {

                int x = int.Parse(txtBId.Text);
                Pos=Busca(x);
                if (Pos >= 0)
                {
                    lbImprimir.Items.Clear(); //LIMPIAR LISTBOX
                    lbImprimir.Items.Add("ID" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" + " Telefono " + "\t" +
                    "Direccion" + "\t\t" + " Deuda " + "\t" + "Estado");
                    if (Instancia[Pos].Estado == true)//CONDICION SI LA DEUDA ESTA PAGADA
                    {
                        lbImprimir.Items.Add(Instancia[Pos].Id + "\t" + Instancia[Pos].Nombre + "\t"
                        + Instancia[Pos].Apellido + "\t" + Instancia[Pos].Telefono + "\t" + Instancia[Pos].Direccion + "\t\t" + Instancia[Pos].Deuda
                        + "\t" + "Pagada");
                        pbImagen.Visible = true;
                        pbImagen.ImageLocation = Instancia[Pos].Ruta;
                    }
                    else//CONDICION SI LA DEUDA NO ESTA PAGAGA
                    {
                        lbImprimir.Items.Add(Instancia[Pos].Id + "\t" + Instancia[Pos].Nombre + "\t"
                        + Instancia[Pos].Apellido + "\t" + Instancia[Pos].Telefono + "\t" + Instancia[Pos].Direccion + "\t\t" + Instancia[Pos].Deuda
                        + "\t" + "Pendiente");
                        pbImagen.Visible = true;
                        pbImagen.ImageLocation = Instancia[Pos].Ruta;
                    }
                }
                else
                {
                    MessageBox.Show("Deudor No Registrado");
                }
            }
        }
        void Listar()
        {
            lbImprimir.Items.Clear(); //LIMPIAR LISTBOX
            lbImprimir.Items.Add("ID" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" + " Telefono " + "\t" +
            "Direccion" + "\t\t" + " Deuda " + "\t" + "Estado");//TITULO 
            for (i = 0; i < N; i++)//CICLO PARA RECORRER LOS ARREGLOS
            {
                if (Instancia[i].Estado == true)//CONDICION SI LA DEUDA ESTA PAGADA
                {
                    lbImprimir.Items.Add(Instancia[i].Id + "\t" + Instancia[i].Nombre + "\t"
                    + Instancia[i].Apellido + "\t" + +Instancia[i].Telefono + "\t" + Instancia[i].Direccion + "\t\t" + Instancia[i].Deuda
                    + "\t" + "Pagada");
                }
                else//CONDICION SI LA DEUDA NO ESTA PAGAGA
                {
                    lbImprimir.Items.Add(Instancia[i].Id + "\t" + Instancia[i].Nombre + "\t"
                    + Instancia[i].Apellido + "\t" + +Instancia[i].Telefono + "\t" + Instancia[i].Direccion + "\t\t" + Instancia[i].Deuda
                   + "\t" + "Pendiente");
                }
            }
            pbImagen.Visible = false;
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnClientesSolventes_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();//Limpiar
            lbImprimir.Items.Add("ID" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" + " Telefono " + "\t" +
            "Direccion" + "\t\t" + " Deuda " + "\t" + "Estado");//Titulo
            for (i = 0; i < N; i++)//Ciclo para recorrer Arreglos
            {
                if (Instancia[i].Estado == true)//Condicion si la deuda esta pagada
                {
                    lbImprimir.Items.Add(Instancia[i].Id + "\t" + Instancia[i].Nombre +
                    "\t" + Instancia[i].Apellido + "\t" + +Instancia[i].Telefono + "\t" + Instancia[i].Direccion + "\t\t"
                    + Instancia[i].Deuda + "\t"  + "Pagada");
                }
            }
            pbImagen.Visible = false;
        }

        private void btnClientesDeudores_Click(object sender, EventArgs e)
        {
            lbImprimir.Items.Clear();//Limpiar
            lbImprimir.Items.Add("ID" + "\t" + "Nombre" + "\t" + "Apellido" + "\t" + " Telefono " + "\t" +
            "Direccion" + "\t\t" + " Deuda " + "\t" + "Estado");//Titulo
            for (i = 0; i < N; i++)//Ciclo para recorrer Arreglos
            {
                if (Instancia[i].Estado == false)//Condicion si la deuda NO esta pagada
                {
                    lbImprimir.Items.Add(Instancia[i].Id + "\t" + Instancia[i].Nombre +
                    "\t" + Instancia[i].Apellido + "\t" + +Instancia[i].Telefono + "\t" + Instancia[i].Direccion + "\t"
                    + Instancia[i].Deuda  + "\t" + "Pendiente");
                }
            }
            pbImagen.Visible = false;
        }

        private void btnEliminarDeudores_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacio");
            }
            else
            {
                int x = int.Parse(txtBId.Text);
                Eliminar(x);
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoDeudores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeudaDeudores_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmAA2_CasaComercial_Load(object sender, EventArgs e)
        {
            cbEstadoDeuda.DropDownStyle = ComboBoxStyle.DropDownList; // ComboBox lista Abajo
            cbEstadoDeuda.Items.Add("Pagada");
            cbEstadoDeuda.Items.Add("No Pagada");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
            while (i < N && Instancia[i].Id < x)
            {
                i = i + 1;
            }
            if (i >= N || Instancia[i].Id > x)
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
                        Instancia[i].Id = Instancia[i + 1].Id;
                        Instancia[i].Nombre = Instancia[i + 1].Nombre;
                        Instancia[i].Apellido = Instancia[i + 1].Apellido;
                        Instancia[i].Direccion = Instancia[i + 1].Direccion;
                        Instancia[i].Telefono = Instancia[i + 1].Telefono;
                        Instancia[i].Deuda = Instancia[i + 1].Deuda;
                        Instancia[i].Estado = Instancia[i + 1].Estado;
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
                            Instancia[i].Id = Instancia[i - 1].Id;
                            Instancia[i].Nombre = Instancia[i - 1].Nombre;
                            Instancia[i].Apellido = Instancia[i - 1].Apellido;
                            Instancia[i].Direccion = Instancia[i - 1].Direccion;
                            Instancia[i].Telefono = Instancia[i - 1].Telefono;
                            Instancia[i].Deuda = Instancia[i - 1].Deuda;
                            Instancia[i].Estado = Instancia[i - 1].Estado;
                            Instancia[i].Ruta = Instancia[i - 1].Ruta;
                        }
                        Instancia[Pos].Id = int.Parse(txtId.Text);
                        Instancia[Pos].Nombre = txtNombreDeudores.Text;
                        Instancia[Pos].Apellido = txtApellidoDeudores.Text;
                        Instancia[Pos].Direccion = txtDireccionDeudores.Text;
                        Instancia[Pos].Telefono = int.Parse(txtTelefonoDeudores.Text);
                        Instancia[Pos].Deuda = int.Parse(txtDeudaDeudores.Text);
                        Instancia[Pos].Ruta = txtRutaFoto.Text;
                        if (cbEstadoDeuda.Text == "Pagada")
                        {
                            Instancia[Pos].Estado = true;
                        }
                        else
                        {
                            Instancia[Pos].Estado = false;
                        }

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
                Instancia[N].Id = int.Parse(txtId.Text);
                Instancia[N].Nombre = txtNombreDeudores.Text;
                Instancia[N].Apellido = txtApellidoDeudores.Text;
                Instancia[N].Direccion = txtDireccionDeudores.Text;
                Instancia[N].Telefono = int.Parse(txtTelefonoDeudores.Text);
                Instancia[N].Deuda = int.Parse(txtDeudaDeudores.Text);
                Instancia[N].Ruta = txtRutaFoto.Text;
                if (cbEstadoDeuda.Text == "Pagada")
                {
                    Instancia[N].Estado = true;
                }
                else
                {
                    Instancia[N].Estado = false;
                }
                N = N + 1;
                MessageBox.Show("Elemento Insertado");
                pbImagen.Visible = false;
            }
        }

        void Actualizar(int x)
        {
            //Pos = Pos * -1;
            x = int.Parse(txtId.Text);
            if (Pos == 0)
            {
                if (x > Instancia[Pos+1].Id)
                {
                    Eliminar(x2);
                    Insertar(x);
                }
                else
                {
                    Instancia[Pos].Id = int.Parse(txtId.Text);
                    Instancia[Pos].Nombre = txtNombreDeudores.Text;
                    Instancia[Pos].Apellido = txtApellidoDeudores.Text;
                    Instancia[Pos].Direccion = txtDireccionDeudores.Text;
                    Instancia[Pos].Telefono = int.Parse(txtTelefonoDeudores.Text);
                    Instancia[Pos].Deuda = int.Parse(txtDeudaDeudores.Text);
                    Instancia[Pos].Ruta = txtRutaFoto.Text;
                    if (cbEstadoDeuda.Text == "Pagada")
                    {
                        Instancia[Pos].Estado = true;
                    }
                    else
                    {
                        Instancia[Pos].Estado = false;
                    }
                    MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                    pbImagen.Visible = false;
                }

            }
            else
            {
                if (Pos == N - 1)
                {
                    if (x < Instancia[Pos - 1].Id)
                    {
                        Eliminar(x2);
                        Insertar(x);
                    }
                    else
                    {
                        Instancia[Pos].Id = int.Parse(txtId.Text);
                        Instancia[Pos].Nombre = txtNombreDeudores.Text;
                        Instancia[Pos].Apellido = txtApellidoDeudores.Text;
                        Instancia[Pos].Direccion = txtDireccionDeudores.Text;
                        Instancia[Pos].Telefono = int.Parse(txtTelefonoDeudores.Text);
                        Instancia[Pos].Deuda = int.Parse(txtDeudaDeudores.Text);
                        Instancia[Pos].Ruta = txtRutaFoto.Text;
                        if (cbEstadoDeuda.Text == "Pagada")
                        {
                            Instancia[Pos].Estado = true;
                        }
                        else
                        {
                            Instancia[Pos].Estado = false;
                        }
                        MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                        pbImagen.Visible = false;
                    }

                }

                else
                {
                    if ((x > Instancia[Pos + 1].Id) || (x < Instancia[Pos - 1].Id))
                    {
                        Eliminar(x2);
                        Insertar(x);

                    }
                    else
                    {
                        Instancia[Pos].Id = int.Parse(txtId.Text);
                        Instancia[Pos].Nombre = txtNombreDeudores.Text;
                        Instancia[Pos].Apellido = txtApellidoDeudores.Text;
                        Instancia[Pos].Direccion = txtDireccionDeudores.Text;
                        Instancia[Pos].Telefono = int.Parse(txtTelefonoDeudores.Text);
                        Instancia[Pos].Deuda = int.Parse(txtDeudaDeudores.Text);
                        Instancia[Pos].Ruta = txtRutaFoto.Text;
                        if (cbEstadoDeuda.Text == "Pagada")
                        {
                            Instancia[Pos].Estado = true;
                        }
                        else
                        {
                            Instancia[Pos].Estado = false;
                        }
                        MessageBox.Show("La persona con Id=" + x + " se ha actualizado");
                        pbImagen.Visible = false;
                    }
                }
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Campo Vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tam = int.Parse(txtCantidad.Text);
                Instancia = new Deudores[Tam];
                MessageBox.Show("Cantidad de almunos ha ingresar =" + Tam);
                N = 0;
            }
        }
    }
}
