namespace Final_Proyect_AED
{
    partial class FrmAA4_Ferreteria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAA4_Ferreteria));
            this.menuFerreteria = new System.Windows.Forms.MenuStrip();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesYFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarIDFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaFacturaPorIDClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFerreteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFerreteria
            // 
            this.menuFerreteria.BackColor = System.Drawing.Color.White;
            this.menuFerreteria.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFerreteria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesToolStripMenuItem,
            this.ProductosToolStripMenuItem,
            this.FacturarToolStripMenuItem,
            this.ReportesYFiltrosToolStripMenuItem,
            this.volverToolStripMenuItem});
            this.menuFerreteria.Location = new System.Drawing.Point(0, 0);
            this.menuFerreteria.Name = "menuFerreteria";
            this.menuFerreteria.Size = new System.Drawing.Size(800, 150);
            this.menuFerreteria.TabIndex = 1;
            this.menuFerreteria.Text = "MenuFerreteria";
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClientesToolStripMenuItem.Image")));
            this.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.ClientesToolStripMenuItem.Text = "Clientes";
            this.ClientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductosToolStripMenuItem.Image")));
            this.ProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // FacturarToolStripMenuItem
            // 
            this.FacturarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FacturarToolStripMenuItem.Image")));
            this.FacturarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem";
            this.FacturarToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.FacturarToolStripMenuItem.Text = "Facturar";
            this.FacturarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FacturarToolStripMenuItem.Click += new System.EventHandler(this.FacturarToolStripMenuItem_Click);
            // 
            // ReportesYFiltrosToolStripMenuItem
            // 
            this.ReportesYFiltrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarIDFacturasToolStripMenuItem,
            this.busquedaFacturaPorIDClienteToolStripMenuItem,
            this.busquedaProductosToolStripMenuItem,
            this.busquedaClientesToolStripMenuItem});
            this.ReportesYFiltrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReportesYFiltrosToolStripMenuItem.Image")));
            this.ReportesYFiltrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportesYFiltrosToolStripMenuItem.Name = "ReportesYFiltrosToolStripMenuItem";
            this.ReportesYFiltrosToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.ReportesYFiltrosToolStripMenuItem.Text = "Reportes y Filtros";
            this.ReportesYFiltrosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // buscarIDFacturasToolStripMenuItem
            // 
            this.buscarIDFacturasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarIDFacturasToolStripMenuItem.Image")));
            this.buscarIDFacturasToolStripMenuItem.Name = "buscarIDFacturasToolStripMenuItem";
            this.buscarIDFacturasToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.buscarIDFacturasToolStripMenuItem.Text = "Busqueda Factura Por ID";
            this.buscarIDFacturasToolStripMenuItem.Click += new System.EventHandler(this.buscarIDFacturasToolStripMenuItem_Click);
            // 
            // busquedaFacturaPorIDClienteToolStripMenuItem
            // 
            this.busquedaFacturaPorIDClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busquedaFacturaPorIDClienteToolStripMenuItem.Image")));
            this.busquedaFacturaPorIDClienteToolStripMenuItem.Name = "busquedaFacturaPorIDClienteToolStripMenuItem";
            this.busquedaFacturaPorIDClienteToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.busquedaFacturaPorIDClienteToolStripMenuItem.Text = "Busqueda Factura Por ID Cliente";
            this.busquedaFacturaPorIDClienteToolStripMenuItem.Click += new System.EventHandler(this.busquedaFacturaPorIDClienteToolStripMenuItem_Click);
            // 
            // busquedaProductosToolStripMenuItem
            // 
            this.busquedaProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busquedaProductosToolStripMenuItem.Image")));
            this.busquedaProductosToolStripMenuItem.Name = "busquedaProductosToolStripMenuItem";
            this.busquedaProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.busquedaProductosToolStripMenuItem.Text = "Busqueda Productos";
            this.busquedaProductosToolStripMenuItem.Click += new System.EventHandler(this.busquedaProductosToolStripMenuItem_Click);
            // 
            // busquedaClientesToolStripMenuItem
            // 
            this.busquedaClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busquedaClientesToolStripMenuItem.Image")));
            this.busquedaClientesToolStripMenuItem.Name = "busquedaClientesToolStripMenuItem";
            this.busquedaClientesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.busquedaClientesToolStripMenuItem.Text = "Busqueda Clientes";
            this.busquedaClientesToolStripMenuItem.Click += new System.EventHandler(this.busquedaClientesToolStripMenuItem_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverToolStripMenuItem.Image")));
            this.volverToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // FrmAA4_Ferreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuFerreteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmAA4_Ferreteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAA4_Ferreteria";
            this.Load += new System.EventHandler(this.FrmAA4_Ferreteria_Load);
            this.menuFerreteria.ResumeLayout(false);
            this.menuFerreteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFerreteria;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FacturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesYFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarIDFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaFacturaPorIDClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaClientesToolStripMenuItem;
    }
}