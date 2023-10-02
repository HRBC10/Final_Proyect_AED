namespace Final_Proyect_AED
{
    partial class FrmPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrograma));
            this.label3 = new System.Windows.Forms.Label();
            this.pnPregunta = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstablecer = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.btnEstablecer = new System.Windows.Forms.Button();
            this.btnMostrarInvertido = new System.Windows.Forms.Button();
            this.pbPregunta = new System.Windows.Forms.PictureBox();
            this.pnPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Impresión De Arreglos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnPregunta
            // 
            this.pnPregunta.BackColor = System.Drawing.SystemColors.Info;
            this.pnPregunta.Controls.Add(this.label5);
            this.pnPregunta.Controls.Add(this.label4);
            this.pnPregunta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPregunta.Location = new System.Drawing.Point(790, 36);
            this.pnPregunta.Name = "pnPregunta";
            this.pnPregunta.Size = new System.Drawing.Size(10, 464);
            this.pnPregunta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 400);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Instrucciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad De Elementos";
            // 
            // txtEstablecer
            // 
            this.txtEstablecer.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstablecer.Location = new System.Drawing.Point(87, 101);
            this.txtEstablecer.Name = "txtEstablecer";
            this.txtEstablecer.Size = new System.Drawing.Size(82, 26);
            this.txtEstablecer.TabIndex = 1;
            this.txtEstablecer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstablecer_KeyPress);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeros.Location = new System.Drawing.Point(87, 230);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(82, 26);
            this.txtNumeros.TabIndex = 3;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese los Numeros ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.BorderSize = 4;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(42, 262);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 51);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Yellow;
            this.btnMostrar.FlatAppearance.BorderSize = 4;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(277, 262);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(162, 51);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbImprimir
            // 
            this.lbImprimir.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.ItemHeight = 19;
            this.lbImprimir.Location = new System.Drawing.Point(277, 70);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(340, 156);
            this.lbImprimir.TabIndex = 7;
            // 
            // btnEstablecer
            // 
            this.btnEstablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstablecer.FlatAppearance.BorderSize = 4;
            this.btnEstablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstablecer.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecer.Location = new System.Drawing.Point(42, 133);
            this.btnEstablecer.Name = "btnEstablecer";
            this.btnEstablecer.Size = new System.Drawing.Size(162, 51);
            this.btnEstablecer.TabIndex = 2;
            this.btnEstablecer.Text = "Establecer";
            this.btnEstablecer.UseVisualStyleBackColor = false;
            this.btnEstablecer.Click += new System.EventHandler(this.btnEstablecer_Click);
            // 
            // btnMostrarInvertido
            // 
            this.btnMostrarInvertido.BackColor = System.Drawing.Color.Yellow;
            this.btnMostrarInvertido.FlatAppearance.BorderSize = 4;
            this.btnMostrarInvertido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarInvertido.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInvertido.Location = new System.Drawing.Point(455, 262);
            this.btnMostrarInvertido.Name = "btnMostrarInvertido";
            this.btnMostrarInvertido.Size = new System.Drawing.Size(162, 51);
            this.btnMostrarInvertido.TabIndex = 6;
            this.btnMostrarInvertido.Text = "Mostrar Invertido";
            this.btnMostrarInvertido.UseVisualStyleBackColor = false;
            this.btnMostrarInvertido.Click += new System.EventHandler(this.btnMostrarInvertido_Click);
            // 
            // pbPregunta
            // 
            this.pbPregunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPregunta.Image = ((System.Drawing.Image)(resources.GetObject("pbPregunta.Image")));
            this.pbPregunta.Location = new System.Drawing.Point(42, 423);
            this.pbPregunta.Name = "pbPregunta";
            this.pbPregunta.Size = new System.Drawing.Size(67, 65);
            this.pbPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPregunta.TabIndex = 9;
            this.pbPregunta.TabStop = false;
            this.pbPregunta.Click += new System.EventHandler(this.pbPregunta_Click);
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnPregunta);
            this.Controls.Add(this.pbPregunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrarInvertido);
            this.Controls.Add(this.btnEstablecer);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtEstablecer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrograma";
            this.Text = "FrmPrograma";
            this.Load += new System.EventHandler(this.FrmPrograma_Load);
            this.pnPregunta.ResumeLayout(false);
            this.pnPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnPregunta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstablecer;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lbImprimir;
        private System.Windows.Forms.Button btnEstablecer;
        private System.Windows.Forms.Button btnMostrarInvertido;
        private System.Windows.Forms.PictureBox pbPregunta;
    }
}