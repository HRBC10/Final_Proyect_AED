namespace Final_Proyect_AED
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbPresentacion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBot = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.pbVerCodigo = new System.Windows.Forms.PictureBox();
            this.pbPrograma = new System.Windows.Forms.PictureBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPresentacion)).BeginInit();
            this.pnBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(70)))));
            this.pnTop.Controls.Add(this.pbPresentacion);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(800, 30);
            this.pnTop.TabIndex = 0;
            // 
            // pbPresentacion
            // 
            this.pbPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("pbPresentacion.Image")));
            this.pbPresentacion.Location = new System.Drawing.Point(3, 3);
            this.pbPresentacion.Name = "pbPresentacion";
            this.pbPresentacion.Size = new System.Drawing.Size(28, 24);
            this.pbPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPresentacion.TabIndex = 6;
            this.pbPresentacion.TabStop = false;
            this.pbPresentacion.Click += new System.EventHandler(this.pbPresentacion_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Programa De Recursividad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBot
            // 
            this.pnBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(50)))));
            this.pnBot.Controls.Add(this.label4);
            this.pnBot.Controls.Add(this.label3);
            this.pnBot.Controls.Add(this.label2);
            this.pnBot.Controls.Add(this.pbInformacion);
            this.pnBot.Controls.Add(this.pbVerCodigo);
            this.pnBot.Controls.Add(this.pbPrograma);
            this.pnBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBot.Location = new System.Drawing.Point(0, 530);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(800, 70);
            this.pnBot.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(634, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Informacion Recursividad";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Funcionalidad De Botones";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ejecutar Programa";
            // 
            // pbInformacion
            // 
            this.pbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInformacion.Image = ((System.Drawing.Image)(resources.GetObject("pbInformacion.Image")));
            this.pbInformacion.Location = new System.Drawing.Point(673, 0);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(52, 50);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInformacion.TabIndex = 5;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.Click += new System.EventHandler(this.pbInformacion_Click);
            // 
            // pbVerCodigo
            // 
            this.pbVerCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVerCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVerCodigo.Image = ((System.Drawing.Image)(resources.GetObject("pbVerCodigo.Image")));
            this.pbVerCodigo.Location = new System.Drawing.Point(353, 0);
            this.pbVerCodigo.Name = "pbVerCodigo";
            this.pbVerCodigo.Size = new System.Drawing.Size(52, 50);
            this.pbVerCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerCodigo.TabIndex = 2;
            this.pbVerCodigo.TabStop = false;
            this.pbVerCodigo.Click += new System.EventHandler(this.pbVerCodigo_Click);
            // 
            // pbPrograma
            // 
            this.pbPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrograma.Image = ((System.Drawing.Image)(resources.GetObject("pbPrograma.Image")));
            this.pbPrograma.Location = new System.Drawing.Point(28, 0);
            this.pbPrograma.Name = "pbPrograma";
            this.pbPrograma.Size = new System.Drawing.Size(64, 50);
            this.pbPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrograma.TabIndex = 0;
            this.pbPrograma.TabStop = false;
            this.pbPrograma.Click += new System.EventHandler(this.pbPrograma_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 30);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(800, 500);
            this.pnContenedor.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnBot);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPresentacion)).EndInit();
            this.pnBot.ResumeLayout(false);
            this.pnBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBot;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.PictureBox pbPrograma;
        private System.Windows.Forms.PictureBox pbVerCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.PictureBox pbPresentacion;
    }
}