namespace Final_Proyect_AED
{
    partial class FrmAA5_Caja
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSigEnLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbImprimirFilaCajaSiguiente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fila A Caja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSigEnLista
            // 
            this.BtnSigEnLista.BackColor = System.Drawing.Color.Green;
            this.BtnSigEnLista.FlatAppearance.BorderSize = 0;
            this.BtnSigEnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSigEnLista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSigEnLista.ForeColor = System.Drawing.Color.White;
            this.BtnSigEnLista.Location = new System.Drawing.Point(328, 336);
            this.BtnSigEnLista.Name = "BtnSigEnLista";
            this.BtnSigEnLista.Size = new System.Drawing.Size(205, 47);
            this.BtnSigEnLista.TabIndex = 3;
            this.BtnSigEnLista.Text = "Siguiente En Lista";
            this.BtnSigEnLista.UseVisualStyleBackColor = false;
            this.BtnSigEnLista.Click += new System.EventHandler(this.BtnSigEnLista_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(257, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESTA SIENDO ATENDIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbImprimirFilaCajaSiguiente
            // 
            this.lbImprimirFilaCajaSiguiente.BackColor = System.Drawing.Color.Black;
            this.lbImprimirFilaCajaSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbImprimirFilaCajaSiguiente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimirFilaCajaSiguiente.ForeColor = System.Drawing.Color.White;
            this.lbImprimirFilaCajaSiguiente.ItemHeight = 16;
            this.lbImprimirFilaCajaSiguiente.Location = new System.Drawing.Point(260, 118);
            this.lbImprimirFilaCajaSiguiente.Name = "lbImprimirFilaCajaSiguiente";
            this.lbImprimirFilaCajaSiguiente.Size = new System.Drawing.Size(334, 144);
            this.lbImprimirFilaCajaSiguiente.TabIndex = 6;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.lbImprimirFilaCajaSiguiente);
            this.Controls.Add(this.BtnSigEnLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSigEnLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbImprimirFilaCajaSiguiente;
    }
}