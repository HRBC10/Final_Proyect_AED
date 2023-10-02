namespace Final_Proyect_AED
{
    partial class FrmRA14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRA14));
            this.btnimprimir = new System.Windows.Forms.Button();
            this.rbpeek = new System.Windows.Forms.RadioButton();
            this.rbdequeue = new System.Windows.Forms.RadioButton();
            this.rbcopy = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbimprimir3 = new System.Windows.Forms.ListBox();
            this.lbimprimir2 = new System.Windows.Forms.ListBox();
            this.lbimprimir1 = new System.Windows.Forms.ListBox();
            this.btnenqueue = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.Location = new System.Drawing.Point(61, 135);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(136, 23);
            this.btnimprimir.TabIndex = 23;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // rbpeek
            // 
            this.rbpeek.AutoSize = true;
            this.rbpeek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpeek.Location = new System.Drawing.Point(495, 142);
            this.rbpeek.Name = "rbpeek";
            this.rbpeek.Size = new System.Drawing.Size(58, 20);
            this.rbpeek.TabIndex = 22;
            this.rbpeek.TabStop = true;
            this.rbpeek.Text = "Peek";
            this.rbpeek.UseVisualStyleBackColor = true;
            this.rbpeek.CheckedChanged += new System.EventHandler(this.rbpeek_CheckedChanged);
            // 
            // rbdequeue
            // 
            this.rbdequeue.AutoSize = true;
            this.rbdequeue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdequeue.Location = new System.Drawing.Point(406, 141);
            this.rbdequeue.Name = "rbdequeue";
            this.rbdequeue.Size = new System.Drawing.Size(83, 20);
            this.rbdequeue.TabIndex = 21;
            this.rbdequeue.TabStop = true;
            this.rbdequeue.Text = "Dequeue";
            this.rbdequeue.UseVisualStyleBackColor = true;
            this.rbdequeue.CheckedChanged += new System.EventHandler(this.rbdequeue_CheckedChanged);
            // 
            // rbcopy
            // 
            this.rbcopy.AutoSize = true;
            this.rbcopy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcopy.Location = new System.Drawing.Point(254, 143);
            this.rbcopy.Name = "rbcopy";
            this.rbcopy.Size = new System.Drawing.Size(58, 20);
            this.rbcopy.TabIndex = 20;
            this.rbcopy.TabStop = true;
            this.rbcopy.Text = "Copy";
            this.rbcopy.UseVisualStyleBackColor = true;
            this.rbcopy.CheckedChanged += new System.EventHandler(this.rbcopy_CheckedChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(643, 139);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 22);
            this.txtbuscar.TabIndex = 19;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar";
            // 
            // lbimprimir3
            // 
            this.lbimprimir3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimprimir3.FormattingEnabled = true;
            this.lbimprimir3.ItemHeight = 16;
            this.lbimprimir3.Location = new System.Drawing.Point(406, 178);
            this.lbimprimir3.Name = "lbimprimir3";
            this.lbimprimir3.Size = new System.Drawing.Size(337, 196);
            this.lbimprimir3.TabIndex = 17;
            // 
            // lbimprimir2
            // 
            this.lbimprimir2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimprimir2.FormattingEnabled = true;
            this.lbimprimir2.ItemHeight = 16;
            this.lbimprimir2.Location = new System.Drawing.Point(235, 179);
            this.lbimprimir2.Name = "lbimprimir2";
            this.lbimprimir2.Size = new System.Drawing.Size(119, 196);
            this.lbimprimir2.TabIndex = 16;
            // 
            // lbimprimir1
            // 
            this.lbimprimir1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimprimir1.FormattingEnabled = true;
            this.lbimprimir1.ItemHeight = 16;
            this.lbimprimir1.Location = new System.Drawing.Point(61, 179);
            this.lbimprimir1.Name = "lbimprimir1";
            this.lbimprimir1.Size = new System.Drawing.Size(136, 196);
            this.lbimprimir1.TabIndex = 15;
            // 
            // btnenqueue
            // 
            this.btnenqueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.btnenqueue.FlatAppearance.BorderSize = 0;
            this.btnenqueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenqueue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenqueue.ForeColor = System.Drawing.Color.White;
            this.btnenqueue.Location = new System.Drawing.Point(254, 79);
            this.btnenqueue.Name = "btnenqueue";
            this.btnenqueue.Size = new System.Drawing.Size(75, 23);
            this.btnenqueue.TabIndex = 14;
            this.btnenqueue.Text = "Enqueue";
            this.btnenqueue.UseVisualStyleBackColor = false;
            this.btnenqueue.Click += new System.EventHandler(this.btnenqueue_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(122, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 13;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(800, 29);
            this.label15.TabIndex = 24;
            this.label15.Text = "RA 14 COLAS";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(769, 0);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(31, 29);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalir.TabIndex = 55;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // FrmRA14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.rbpeek);
            this.Controls.Add(this.rbdequeue);
            this.Controls.Add(this.rbcopy);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbimprimir3);
            this.Controls.Add(this.lbimprimir2);
            this.Controls.Add(this.lbimprimir1);
            this.Controls.Add(this.btnenqueue);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRA14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRA14";
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.RadioButton rbpeek;
        private System.Windows.Forms.RadioButton rbdequeue;
        private System.Windows.Forms.RadioButton rbcopy;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbimprimir3;
        private System.Windows.Forms.ListBox lbimprimir2;
        private System.Windows.Forms.ListBox lbimprimir1;
        private System.Windows.Forms.Button btnenqueue;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbSalir;
    }
}