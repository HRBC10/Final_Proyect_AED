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
    public partial class FrmAA4_FerreteriaReporteCliente : Form
    {
        public FrmAA4_FerreteriaReporteCliente()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        bool Bandera = false;
        void Procedimiento1()
        {
            dt.Clear();
            DgBClientes.DataSource = null;
            DgBClientes.DataSource = ClssModuloAA4Ferreteria.ListaClientes;
            if (Bandera == false)
            {
                foreach (DataGridViewColumn col in DgBClientes.Columns)
                {
                    dt.Columns.Add(col.Name);
                }
                Bandera = true;
            }
            foreach (DataGridViewRow row in DgBClientes.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
        }

        private void TxtBusquedaClientes_TextChanged(object sender, EventArgs e)
        {
            DgBClientes.DataSource = null;
            DgBClientes.DataSource = ClssModuloAA4Ferreteria.ListaClientes;
            Procedimiento1();
            dt.DefaultView.RowFilter = $"EONombres LIKE'{TxtBusquedaClientes.Text}%'";
            DgBClientes.DataSource = null;
            DgBClientes.DataSource = dt;
        }

        private void FrmAA4_FerreteriaReporteCliente_Load(object sender, EventArgs e)
        {
            DgBClientes.ReadOnly = true;
            DgBClientes.RowsDefaultCellStyle.BackColor = Color.Beige;
            DgBClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
        }
    }
}
