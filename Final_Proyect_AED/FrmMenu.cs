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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //INSTANCIA PARA FORMULARIO PRESENTACION
        FrmPresentacion regresar;

        // INSTANCIAS DE FORMULARIOS DE RECURSOS DE ACTIVIDADES
        FrmRA2 InstanciaRA2 = new FrmRA2();
        FrmRA3 InstanciaRA3 = new FrmRA3();
        FrmRA4 InstanciaRA4 = new FrmRA4();
        FrmRA5 InstanciaRA5 = new FrmRA5();
        FrmRA6 InstanciaRA6 = new FrmRA6();
        FrmRA7 InstanciaRA7 = new FrmRA7();
        FrmRA8 InstanciaRA8 = new FrmRA8();
        FrmRA9 InstanciaRA9 = new FrmRA9();
        FrmRA10 InstanciaRA10 = new FrmRA10();
        FrmRA11 InstanciaRA11 = new FrmRA11();
        FrmRA12 InstanciaRA12 = new FrmRA12();
        FrmRA13 InstanciaRA13 = new FrmRA13();
        FrmRA14 InstanciaRA14 = new FrmRA14();
        FrmRA15 InstanciaRA15 = new FrmRA15();
        FrmRA17 InstanciaRA17 = new FrmRA17();
        FrmRA18 InstanciaRA18 = new FrmRA18();

        void Esconder_RA()
        {
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
        }

        //INSTANCIAS DE FORMULARIOS DE ACTIVIDADES DE APRENDIZAJE

        //AA1 ALUMNOS
        FrmAA1_Alumnos InstanciaAA1_Alumnos = new FrmAA1_Alumnos();
        FrmAA1_Empleados InstanciaAA1_Empleados = new FrmAA1_Empleados();
        //AA2
        FrmAA2_CasaComercial InstanciaAA2_CasaComercial = new FrmAA2_CasaComercial();
        FrmAA2_EntregaDeProyectos InstanciaAA2_EntregaDeProyectos = new FrmAA2_EntregaDeProyectos();
        //AA4 LISTAS
        FrmAA4_Ferreteria InstanciaAA4_Ferreteria = new FrmAA4_Ferreteria();
        //AA5 PILAS Y COLAS52
        FrmAA5_Directorio InstanciaAA5_Directorio = new FrmAA5_Directorio();
        //AA5 Pilas
        FrmAA5_PrincipalBanco InstanciaAA5_Banco = new FrmAA5_PrincipalBanco();
        //AA3 Recursividad
        FrmPrincipal InstanciaAA3_Principal = new FrmPrincipal();
        //AA6 Arboles Binarios
        Form1 InstanciaAA6_Programa = new Form1();
        //AA7 Ordenacion
        FrmAA7Ordenacion InstanciaAA7_Programa = new FrmAA7Ordenacion();
        //AA7 Busquedas
        FrmAA7_Busquedas InstanciaAA7_Busquedas = new FrmAA7_Busquedas();
        void EsconderAA()
        {
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA7_Programa.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        // VOLVER A PRESENTACION
        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regresar = new FrmPresentacion();
            regresar.Show();
            this.Hide();
        }

        //MINIMIZAR PROGRAMA
        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //SALIR DEL PROGRAMA
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //RECURSO DE ACTIVIDAD NUMERO 2
        private void rA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA2.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 3
        private void rA3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA3.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 4
        private void rA4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA4.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 5
        private void rA5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA5.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 6
        private void rA6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA6.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 7
        private void rA7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA7.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 8
        private void rA8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA8.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 9
        private void rA9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA9.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 10
        private void rA10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA10.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 11
        private void rA11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA11.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 12
        private void rA12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA12.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            this.Hide();
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 13
        private void rA13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA13.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 14
        private void rA14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA14.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 15
        private void rA15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA15.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA17.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }


        //RECURSO DE ACTIVIDAD NUMERO 17
        private void rA17ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA17.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA18.Hide();
            EsconderAA();
        }

        //RECURSO DE ACTIVIDAD NUMERO 18
        private void rA18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaRA18.Show();//MOSTRAR FORMULARIO
            //ESCONDER LOS DEMAS
            InstanciaRA2.Hide();
            InstanciaRA3.Hide();
            InstanciaRA4.Hide();
            InstanciaRA5.Hide();
            InstanciaRA6.Hide();
            InstanciaRA7.Hide();
            InstanciaRA8.Hide();
            InstanciaRA9.Hide();
            InstanciaRA10.Hide();
            InstanciaRA11.Hide();
            InstanciaRA12.Hide();
            InstanciaRA13.Hide();
            InstanciaRA14.Hide();
            InstanciaRA15.Hide();
            InstanciaRA17.Hide();
            EsconderAA();
        }

        //AA1 ALUMNOS
        private void registroAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA1_Alumnos.Show();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA7_Programa.Hide();
            Esconder_RA();
        }

        //AA1 EMPLEADOS
        private void registroEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA1_Empleados.Show();
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA7_Programa.Hide();

            Esconder_RA();
        }

        //AA2 CASA COMERCIAL
        private void casaComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA2_CasaComercial.Show();
            //
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA7_Programa.Hide();
            Esconder_RA();
        }

        //AA2 ENTREGA DE PROYECTOS
        private void entregaDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA2_EntregaDeProyectos.Show();
            //
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA7_Programa.Hide();
            Esconder_RA();
        }

        //AA3 Recursividad
        private void aA3AlgoritmosRecursivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA3_Principal.Show();
            //ESCONDER DEMAS
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA5_Banco.Hide();
            Esconder_RA();
        }


        //AA4 FERRETERIA
        private void ferreteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA4_Ferreteria.Show();
            //
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA7_Programa.Hide();
            Esconder_RA();
            this.Hide();
        }

        //AA5 DIRECTORIO
        private void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA5_Directorio.Show();
            //ESCONDER DEMAS
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            InstanciaAA5_Banco.Hide();
            Esconder_RA();
        }

        //AA5 Banco
        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA5_Banco.Show();
            //ESCONDER DEMAS
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            Esconder_RA();
        }

        //AA6 Arboles BInarios
        private void aA6ArbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA6_Programa.Show();
            //ESCONDER DEMAS
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA7_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            Esconder_RA();
        }

        //AA7 Ordenacion
        private void ordenacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA7_Programa.Show();
            //ESCONDER DEMAS
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Busquedas.Hide();
            Esconder_RA();
        }

        //AA7 Busqueda
        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciaAA7_Busquedas.Hide();
            //ESCONDER DEMAS
            InstanciaAA1_Alumnos.Hide();
            InstanciaAA1_Empleados.Hide();
            InstanciaAA2_CasaComercial.Hide();
            InstanciaAA2_EntregaDeProyectos.Hide();
            InstanciaAA3_Principal.Hide();
            InstanciaAA4_Ferreteria.Hide();
            InstanciaAA5_Directorio.Hide();
            InstanciaAA5_Banco.Hide();
            InstanciaAA6_Programa.Hide();
            InstanciaAA7_Programa.Hide();
            Esconder_RA();
        }
    }
}
