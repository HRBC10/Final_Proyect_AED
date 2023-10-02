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
    public partial class FrmAA4_FerreteriaReporteProductos : Form
    {
        public FrmAA4_FerreteriaReporteProductos()
        {
            InitializeComponent();
        }

        bool Bandera2 = false;
        DataTable dt2 = new DataTable();

        void Procedimiento2()
        {
            dt2.Clear();
            DgBProductos.DataSource = null;
            DgBProductos.DataSource = ClssModuloAA4Ferreteria.ListaProductos;
            if (Bandera2 == false)
            {
                foreach (DataGridViewColumn col in DgBProductos.Columns)
                {
                    dt2.Columns.Add(col.Name);
                }
                Bandera2 = true;
            }
            foreach (DataGridViewRow row in DgBProductos.Rows)
            {
                DataRow dRow = dt2.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt2.Rows.Add(dRow);
            }
        }
        private void TxtBusquedaProductos_TextChanged(object sender, EventArgs e)
        {
            DgBProductos.DataSource = null;
            DgBProductos.DataSource = ClssModuloAA4Ferreteria.ListaClientes;
            Procedimiento2();
            dt2.DefaultView.RowFilter = $"EODescripcion LIKE'{TxtBusquedaProductos.Text}%'";
            DgBProductos.DataSource = null;
            DgBProductos.DataSource = dt2;
        }

        private void FrmAA4_FerreteriaReporteProductos_Load(object sender, EventArgs e)
        {
            DgBProductos.ReadOnly = true;
            DgBProductos.RowsDefaultCellStyle.BackColor = Color.Beige;
            DgBProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;
        }
    }
}
