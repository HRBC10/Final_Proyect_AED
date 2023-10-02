namespace Final_Proyect_AED
{
    partial class FrmRA12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRA12));
            this.msRA12 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRA12.SuspendLayout();
            this.SuspendLayout();
            // 
            // msRA12
            // 
            this.msRA12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.solicitudPrestamoToolStripMenuItem,
            this.volverMenuPrincipalToolStripMenuItem});
            this.msRA12.Location = new System.Drawing.Point(0, 0);
            this.msRA12.Name = "msRA12";
            this.msRA12.Size = new System.Drawing.Size(800, 150);
            this.msRA12.TabIndex = 2;
            this.msRA12.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoToolStripMenuItem.Image")));
            this.empleadoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // solicitudPrestamoToolStripMenuItem
            // 
            this.solicitudPrestamoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitudPrestamoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("solicitudPrestamoToolStripMenuItem.Image")));
            this.solicitudPrestamoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.solicitudPrestamoToolStripMenuItem.Name = "solicitudPrestamoToolStripMenuItem";
            this.solicitudPrestamoToolStripMenuItem.Size = new System.Drawing.Size(140, 146);
            this.solicitudPrestamoToolStripMenuItem.Text = "Solicitud prestamo";
            this.solicitudPrestamoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.solicitudPrestamoToolStripMenuItem.Click += new System.EventHandler(this.solicitudPrestamoToolStripMenuItem_Click);
            // 
            // volverMenuPrincipalToolStripMenuItem
            // 
            this.volverMenuPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverMenuPrincipalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverMenuPrincipalToolStripMenuItem.Image")));
            this.volverMenuPrincipalToolStripMenuItem.Name = "volverMenuPrincipalToolStripMenuItem";
            this.volverMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(138, 146);
            this.volverMenuPrincipalToolStripMenuItem.Text = "Volver Menu Principal";
            this.volverMenuPrincipalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.volverMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverMenuPrincipalToolStripMenuItem_Click);
            // 
            // FrmRA12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msRA12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmRA12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRA12";
            this.Load += new System.EventHandler(this.FrmRA12_Load);
            this.msRA12.ResumeLayout(false);
            this.msRA12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msRA12;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverMenuPrincipalToolStripMenuItem;
    }
}