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
    public partial class FrmAA4_FerreteriaFacturas : Form
    {
        public FrmAA4_FerreteriaFacturas()
        {
            InitializeComponent();
        }

        DataTable dtMaster = new DataTable();

        private void CargarTotalFactura()
        {
            decimal SumTotal = Convert.ToDecimal(dtMaster.Compute("SUM(EOTotal)", string.Empty));
            lbTotal.Text = SumTotal.ToString("0.00");
        }

        private void AgregarProducto()
        {
            DataRow row = dtMaster.NewRow();
            row["EOIDProducto"] = this.cbIDProducto.SelectedValue;
            row["EODescripcion"] = this.txtHDescripcion.Text;
            row["EOCantidad"] = this.txtCantidad.Text;
            row["EODescuento"] = this.txtDescuento.Text;

            row["EOIDFactura"] = this.TxtNFactura.Text;
            row["EOID"] = this.cbIDCliente.SelectedValue;


            if (Convert.ToInt32(row["EOCantidad"]) > 12)
                row["EOPrecio"] = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOPMayorista;
            else
                row["EOPrecio"] = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOPUnitario;

            //Validacion De Precio
            decimal Porcentaje = Convert.ToDecimal(row["EODescuento"]) * 0.01M;
            decimal PrecioBase = Convert.ToDecimal(row["EOPrecio"]) * Convert.ToDecimal(row["EOCantidad"]);
            row["EOTotal"] = PrecioBase - (Porcentaje * PrecioBase);

            dtMaster.Rows.Add(row);
            dgFacturar.DataSource = dtMaster;
        }

        public void refrescardatos()
        {
            cbIDCliente.DisplayMember = "EOID";
            cbIDCliente.ValueMember = "EOID";
            cbIDProducto.DisplayMember = "EOIDProducto";
            cbIDProducto.ValueMember = "EOIDProducto";
            cbIDCliente.DataSource = ClssModuloAA4Ferreteria.ListaClientes.ToList();
            cbIDProducto.DataSource = ClssModuloAA4Ferreteria.ListaProductos.ToList();
        }

        private bool ValidaCamapos()
        {
            bool flag = true;
            string title = "Generar Factura";
            string message = string.Empty;

            if (TxtNFactura.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese el N# De Factura";
                MessageBox.Show(message, title);
            }

            if (txtCantidad.Text == string.Empty)
            {
                flag = false;
                message = "Ingrese La Cantidad Del Producto";
                MessageBox.Show(message, title);
            }

            return flag;
        }

        void Limpiar()
        {
            txtCantidad.Text = string.Empty;
            txtDescuento.Text = string.Empty;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (dtMaster.Rows.Count > 0)
            {
                ClssFacturasAA4_Ferreteria InstanciaMaestro = new ClssFacturasAA4_Ferreteria();
                InstanciaMaestro.EOIDFactura = int.Parse(TxtNFactura.Text);
                InstanciaMaestro.EOID = int.Parse(cbIDCliente.SelectedValue.ToString());
                InstanciaMaestro.EONombres = TxtHNombres.Text;
                InstanciaMaestro.EOApellidos = TxtHApellidos.Text;
                InstanciaMaestro.EOFecha = Convert.ToDateTime(TxtFecha.Text);
                InstanciaMaestro.EOTotalFactura = Convert.ToDecimal(lbTotal.Text);

                ClssModuloAA4Ferreteria.ListaFacturaMaestro.Add(InstanciaMaestro);

                if (InstanciaMaestro.EOIDFactura > 0)
                {
                    var contador = 0;
                    foreach (DataRow linea in dtMaster.Rows)
                    {
                        contador++;
                        ClssDetalleAA4_Ferreteria InstanciaDetalle = new ClssDetalleAA4_Ferreteria();
                        InstanciaDetalle.EOIDItem = contador;
                        InstanciaDetalle.EOIDFactura = InstanciaMaestro.EOIDFactura;
                        InstanciaDetalle.EOID = InstanciaMaestro.EOID;
                        InstanciaDetalle.EOIDProducto = Convert.ToInt32(linea["EOIDProducto"]);
                        InstanciaDetalle.EODescuento = Convert.ToDecimal(linea["EODescuento"]);
                        InstanciaDetalle.EODescripcion = linea["EODescripcion"].ToString();
                        InstanciaDetalle.EOPrecio = Convert.ToDecimal(linea["EOPrecio"]);
                        InstanciaDetalle.EOTotal = Convert.ToDecimal(linea["EOTotal"]);

                        ClssModuloAA4Ferreteria.ListaFacturaDetalle.Add(InstanciaDetalle);
                    }
                }

                Limpiar();
                TxtNFactura.Text = string.Empty;
                lbTotal.Text = string.Empty;
                dgFacturar.DataSource = null;
                dtMaster = new DataTable();
                InicializarColumnas();
                string message = "Factura Se Ha Guardado";
                string title = "Generar Factura";
                MessageBox.Show(message, title);
            }
        }

        private void InicializarColumnas()
        {
            dtMaster.Columns.Add(new DataColumn("EOIDItem", typeof(int)));
            dtMaster.Columns[0].AutoIncrement = true;
            dtMaster.Columns[0].AutoIncrementSeed = 1;

            dtMaster.Columns.Add(new DataColumn("EOIDFactura", typeof(int)));
            dtMaster.Columns.Add(new DataColumn("EOID", typeof(int)));

            dtMaster.Columns.Add(new DataColumn("EOIDProducto", typeof(int)));
            dtMaster.Columns.Add(new DataColumn("EODescripcion", typeof(string)));
            dtMaster.Columns.Add(new DataColumn("EOCantidad", typeof(decimal)));
            dtMaster.Columns.Add(new DataColumn("EODescuento", typeof(decimal)));
            dtMaster.Columns.Add(new DataColumn("EOPrecio", typeof(decimal)));
            dtMaster.Columns.Add(new DataColumn("EOTotal", typeof(decimal)));
        }

        private void FrmAA4_FerreteriaFacturas_Load(object sender, EventArgs e)
        {
            dgFacturar.ReadOnly = true;
            dgFacturar.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgFacturar.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            InicializarColumnas();

            cbIDCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIDProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtFecha.Text = Convert.ToString(DateTime.Now);
        }
        private void ValidarDetalleProductos()
        {
            //Obtener ID Repetido
            var ObtenerIdFactura = ClssModuloAA4Ferreteria.ListaFacturaMaestro.Count(s => s.EOIDFactura.ToString() == TxtNFactura.Text);

            var ObtenerExistenciaActual = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOExistencia;
            decimal EOCantidad = decimal.Parse(txtCantidad.Text);

            var ObtenerStockMinimo = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOSTMimimo;

            //NuevaExistencia = Existencia Actual - Cantidad a Facturar
            var NuevaExistencia = ObtenerExistenciaActual - double.Parse(txtCantidad.Text);

            //Validacion De Id Repetido
            if (ObtenerIdFactura > 0)
            {
                string message = "El Id De Factura que intenta registrar ya existe";
                string title = "Generar Factura";
                MessageBox.Show(message, title);
            }
            else
            {
                //Validacion De Existencia
                if (NuevaExistencia < ObtenerStockMinimo)
                {
                    string message = "No se puede facturar esa cantidad de productos. No hay Existencias.";
                    string title = "Generar de Factura";
                    MessageBox.Show(message, title);
                }
                else
                {
                    bool existeProducto = false;
                    bool clienteDiferente = false;
                    bool FacturaDiferente = false;

                    foreach (DataRow rowTemporal in dtMaster.Rows)
                    {
                        if (Convert.ToInt32(rowTemporal["EOIDFactura"]) != Convert.ToInt32(TxtNFactura.Text))
                        {
                            FacturaDiferente = true;
                        }

                        if (Convert.ToInt32(rowTemporal["EOID"]) != Convert.ToInt32(cbIDCliente.SelectedValue))
                        {
                            clienteDiferente = true;
                        }

                        if (Convert.ToInt32(rowTemporal["EOIDProducto"]) == Convert.ToInt32(cbIDProducto.SelectedValue))
                        {
                            existeProducto = true;
                        }
                    }

                    if (FacturaDiferente == true)
                    {
                        string message = "El Id de Factura es diferente al del listado.";
                        string title = "Generar de Factura";
                        MessageBox.Show(message, title);
                    }

                    if (existeProducto == true)
                    {
                        string message = "El codigo del producto ya existe en el listado.";
                        string title = "Generar de Factura";
                        MessageBox.Show(message, title);
                    }

                    if (clienteDiferente == true)
                    {
                        string message = "El cliente es diferente al del listado.";
                        string title = "Generar de Factura";
                        MessageBox.Show(message, title);
                    }

                    if (existeProducto == false && clienteDiferente == false && FacturaDiferente==false)
                    {
                        AgregarProducto();
                        CargarTotalFactura();

                        //Guardamos la nueva existencia existencia del producto.
                        ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOExistencia = Convert.ToInt32(NuevaExistencia);
                    }
                }

                Limpiar();
            }
        }

        private void cbIDProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDProducto.SelectedValue != null)
            {
                var ObtenerDescripcionProducto = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EODescripcion;
                txtHDescripcion.Text = ObtenerDescripcionProducto;
            }
        }

        private void cbIDCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDCliente.SelectedValue != null)
            {
                var ObtenerNombre = ClssModuloAA4Ferreteria.ListaClientes.Where(x => x.EOID.ToString() == cbIDCliente.SelectedValue.ToString()).FirstOrDefault().EONombres;
                TxtHNombres.Text = ObtenerNombre;

                var ObtenerApellido = ClssModuloAA4Ferreteria.ListaClientes.Where(x => x.EOID.ToString() == cbIDCliente.SelectedValue.ToString()).FirstOrDefault().EOApellidos;
                TxtHApellidos.Text = ObtenerApellido;
            }
        }

        private void TxtNFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregarItems_Click(object sender, EventArgs e)
        {
            if (ValidaCamapos() == true)
            {
                ValidarDetalleProductos();
            }
        }
    }

    //private void guardarFactura()
    //{
    //    ClssFacturasAA4_Ferreteria Instancia = new ClssFacturasAA4_Ferreteria();
    //    Instancia.EOIDFactura = int.Parse(TxtNFactura.Text);
    //    Instancia.EOID = int.Parse(cbIDCliente.SelectedValue.ToString());
    //    Instancia.EONombres = TxtHNombres.Text;
    //    Instancia.EOApellidos = TxtHApellidos.Text;
    //    Instancia.EOIDProducto = int.Parse(cbIDProducto.SelectedValue.ToString());
    //    Instancia.EODescuento = double.Parse(txtDescuento.Text);
    //    Instancia.EODescripcion = txtHDescripcion.Text;
    //    Instancia.EOFecha = Convert.ToDateTime(TxtFecha.Text);

    //    //Obtener ID Repetido
    //    var result = ClssModuloAA4Ferreteria.ListaFacturas.Count(s => s.EOIDFactura.ToString() == Instancia.EOIDFactura.ToString());

    //    var ObtenerExistenciaActual = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOExistencia;
    //    Instancia.EOCantidad = double.Parse(txtCantidad.Text);

    //    var ObtenerStockMinimo = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOSTMimimo;

    //    //NuevaExistencia = Existencia Actual - Cantidad a Facturar
    //    var NuevaExistencia = ObtenerExistenciaActual - double.Parse(txtCantidad.Text);

    //    //Obtener Precio Mayorista o Precio Unitario
    //    if (Instancia.EOCantidad > 12)
    //    {
    //        var Precio = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOPMayorista;
    //        Instancia.EOPrecio = double.Parse(Precio.ToString());
    //    }
    //    else
    //    {
    //        var Precio = ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == cbIDProducto.SelectedValue.ToString()).FirstOrDefault().EOPUnitario;
    //        Instancia.EOPrecio = double.Parse(Precio.ToString());
    //    }

    //    //Calculo Matematico 
    //    var Porcentaje = Instancia.EODescuento * 0.01;
    //    var PrecioBase = Instancia.EOPrecio * Instancia.EOCantidad;
    //    var Total = PrecioBase - (Porcentaje * PrecioBase);

    //    Instancia.EOTotal = double.Parse(Total.ToString());

    //    //Validacion De Id Repetido
    //    if (result > 0)
    //    {
    //        string message = "El Id De Factura que intenta registrar ya existe";
    //        string title = "Generar Factura";
    //        MessageBox.Show(message, title);
    //    }
    //    else
    //    {
    //        //Validacion De Existencia
    //        if (NuevaExistencia < ObtenerStockMinimo)
    //        {
    //            string message = "No se puede facturar esa cantidad de productos. No hay Existencias.";
    //            string title = "Generar de Factura";
    //            MessageBox.Show(message, title);
    //        }
    //        else
    //        {
    //            //Guardamos la nueva existencia existencia del producto.
    //            ClssModuloAA4Ferreteria.ListaProductos.Where(x => x.EOIDProducto.ToString() == Instancia.EOIDProducto.ToString()).FirstOrDefault().EOExistencia = Convert.ToInt32(NuevaExistencia);

    //            //Guardamos Factura
    //            ClssModuloAA4Ferreteria.ListaFacturas.Add(Instancia);
    //            dgFacturar.DataSource = null;
    //            dgFacturar.DataSource = ClssModuloAA4Ferreteria.ListaFacturas;
    //            Limpiar();
    //        }
    //    }
    //}
}

