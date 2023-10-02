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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        FrmMenu regresar ;

        private void pbPresentacion_Click(object sender, EventArgs e)
        {
            regresar = new FrmMenu();
            regresar.Show();
            this.Hide();
        }
        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPrograma_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmPrograma());
        }

  
        private void pbVerCodigo_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCodigo());
        }

        private void pbInformacion_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmInformacion());
        }

        private void AbrirFormularios(Object FormHijos)
        {
            if(this.pnContenedor.Controls.Count>0) //Condicional Si hay algun control en el Panel 
            this.pnContenedor.Controls.RemoveAt(0); //Si Hay Lo Eliminamos
            Form FH = FormHijos as Form; // Crear Form FH, tiene que ser = Objeto (FormHijos) y ;p convertimos en Form con 'as'
            FH.TopLevel = false; // Decimos que es Un Form Secundario
            FH.Dock = DockStyle.Fill; // Propiedad que se acopla al Size del Panel
            this.pnContenedor.Controls.Add(FH); //Agregamos al Panel
            this.pnContenedor.Tag = FH; // Establecemos Instancia como contenedor de datos de nuestro panel
            FH.Show();     //Mostramos
        }
    }
}
