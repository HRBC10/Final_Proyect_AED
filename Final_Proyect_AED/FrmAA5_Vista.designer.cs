namespace Final_Proyect_AED
{
    partial class FrmVista
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbImprimirFilaCaja = new System.Windows.Forms.ListBox();
            this.lbImprimirFilaSBancarios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerCaja = new System.Windows.Forms.TextBox();
            this.txtVerSBancarios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISTA DE FILAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "FILA DE CAJA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(538, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "FILA A SERVICIOS BANCARIOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbImprimirFilaCaja
            // 
            this.lbImprimirFilaCaja.BackColor = System.Drawing.Color.Black;
            this.lbImprimirFilaCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimirFilaCaja.ForeColor = System.Drawing.Color.White;
            this.lbImprimirFilaCaja.FormattingEnabled = true;
            this.lbImprimirFilaCaja.ItemHeight = 16;
            this.lbImprimirFilaCaja.Location = new System.Drawing.Point(46, 238);
            this.lbImprimirFilaCaja.Name = "lbImprimirFilaCaja";
            this.lbImprimirFilaCaja.Size = new System.Drawing.Size(244, 180);
            this.lbImprimirFilaCaja.TabIndex = 3;
            this.lbImprimirFilaCaja.SelectedIndexChanged += new System.EventHandler(this.lbImprimirFilaCaja_SelectedIndexChanged);
            // 
            // lbImprimirFilaSBancarios
            // 
            this.lbImprimirFilaSBancarios.BackColor = System.Drawing.Color.Black;
            this.lbImprimirFilaSBancarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimirFilaSBancarios.ForeColor = System.Drawing.Color.White;
            this.lbImprimirFilaSBancarios.FormattingEnabled = true;
            this.lbImprimirFilaSBancarios.ItemHeight = 16;
            this.lbImprimirFilaSBancarios.Location = new System.Drawing.Point(541, 238);
            this.lbImprimirFilaSBancarios.Name = "lbImprimirFilaSBancarios";
            this.lbImprimirFilaSBancarios.Size = new System.Drawing.Size(244, 180);
            this.lbImprimirFilaSBancarios.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(46, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "ESTA SIENDO ATENDIDO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(538, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "ESTA SIENDO ATENDIDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVerCaja
            // 
            this.txtVerCaja.BackColor = System.Drawing.Color.Black;
            this.txtVerCaja.ForeColor = System.Drawing.Color.White;
            this.txtVerCaja.Location = new System.Drawing.Point(46, 143);
            this.txtVerCaja.Name = "txtVerCaja";
            this.txtVerCaja.Size = new System.Drawing.Size(244, 20);
            this.txtVerCaja.TabIndex = 7;
            // 
            // txtVerSBancarios
            // 
            this.txtVerSBancarios.BackColor = System.Drawing.Color.Black;
            this.txtVerSBancarios.ForeColor = System.Drawing.Color.White;
            this.txtVerSBancarios.Location = new System.Drawing.Point(538, 143);
            this.txtVerSBancarios.Name = "txtVerSBancarios";
            this.txtVerSBancarios.Size = new System.Drawing.Size(244, 20);
            this.txtVerSBancarios.TabIndex = 8;
            // 
            // FrmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.txtVerSBancarios);
            this.Controls.Add(this.txtVerCaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbImprimirFilaSBancarios);
            this.Controls.Add(this.lbImprimirFilaCaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbImprimirFilaCaja;
        private System.Windows.Forms.ListBox lbImprimirFilaSBancarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVerCaja;
        private System.Windows.Forms.TextBox txtVerSBancarios;
    }
}