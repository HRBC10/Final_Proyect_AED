namespace Final_Proyect_AED
{
    partial class FrmSBancarios
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
            this.lbImprimirFilaSBancariosSiguiente = new System.Windows.Forms.ListBox();
            this.btnSigEnLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila A Servicios Bancarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbImprimirFilaSBancariosSiguiente
            // 
            this.lbImprimirFilaSBancariosSiguiente.BackColor = System.Drawing.Color.Black;
            this.lbImprimirFilaSBancariosSiguiente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimirFilaSBancariosSiguiente.ForeColor = System.Drawing.Color.White;
            this.lbImprimirFilaSBancariosSiguiente.FormattingEnabled = true;
            this.lbImprimirFilaSBancariosSiguiente.ItemHeight = 16;
            this.lbImprimirFilaSBancariosSiguiente.Location = new System.Drawing.Point(260, 118);
            this.lbImprimirFilaSBancariosSiguiente.Name = "lbImprimirFilaSBancariosSiguiente";
            this.lbImprimirFilaSBancariosSiguiente.Size = new System.Drawing.Size(334, 148);
            this.lbImprimirFilaSBancariosSiguiente.TabIndex = 4;
            // 
            // btnSigEnLista
            // 
            this.btnSigEnLista.BackColor = System.Drawing.Color.Green;
            this.btnSigEnLista.FlatAppearance.BorderSize = 0;
            this.btnSigEnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigEnLista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigEnLista.ForeColor = System.Drawing.Color.White;
            this.btnSigEnLista.Location = new System.Drawing.Point(328, 336);
            this.btnSigEnLista.Name = "btnSigEnLista";
            this.btnSigEnLista.Size = new System.Drawing.Size(205, 47);
            this.btnSigEnLista.TabIndex = 5;
            this.btnSigEnLista.Text = "Siguiente En Lista";
            this.btnSigEnLista.UseVisualStyleBackColor = false;
            this.btnSigEnLista.Click += new System.EventHandler(this.btnSigEnLista_Click);
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
            this.label2.TabIndex = 1;
            this.label2.Text = "ESTA SIENDO ATENDIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnSigEnLista);
            this.Controls.Add(this.lbImprimirFilaSBancariosSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSBancarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSBancarios";
            this.Load += new System.EventHandler(this.FrmSBancarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbImprimirFilaSBancariosSiguiente;
        private System.Windows.Forms.Button btnSigEnLista;
        private System.Windows.Forms.Label label2;
    }
}