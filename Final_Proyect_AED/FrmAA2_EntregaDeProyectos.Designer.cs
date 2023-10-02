namespace Final_Proyect_AED
{
    partial class FrmAA2_EntregaDeProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAA2_EntregaDeProyectos));
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.gpDatosEstudiantes = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRutaFoto = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.cbCImagen = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarProyecto = new System.Windows.Forms.Button();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pbIconoUser = new System.Windows.Forms.PictureBox();
            this.txtFechaLimite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProyectoNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarRegistros = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnProyectosAtrasados = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pbVolver = new System.Windows.Forms.PictureBox();
            this.gpDatosEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbImprimir
            // 
            this.lbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.ItemHeight = 16;
            this.lbImprimir.Location = new System.Drawing.Point(513, 86);
            this.lbImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(766, 372);
            this.lbImprimir.TabIndex = 30;
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProyecto.BackgroundImage")));
            this.btnBuscarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProyecto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(650, 569);
            this.btnBuscarProyecto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(188, 58);
            this.btnBuscarProyecto.TabIndex = 27;
            this.btnBuscarProyecto.Text = "Buscar Proyecto";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.btnBuscarProyecto_Click);
            // 
            // gpDatosEstudiantes
            // 
            this.gpDatosEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpDatosEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.gpDatosEstudiantes.Controls.Add(this.label10);
            this.gpDatosEstudiantes.Controls.Add(this.txtRutaFoto);
            this.gpDatosEstudiantes.Controls.Add(this.pbImagen);
            this.gpDatosEstudiantes.Controls.Add(this.cbCImagen);
            this.gpDatosEstudiantes.Controls.Add(this.txtCantidad);
            this.gpDatosEstudiantes.Controls.Add(this.btnCantidad);
            this.gpDatosEstudiantes.Controls.Add(this.label9);
            this.gpDatosEstudiantes.Controls.Add(this.label8);
            this.gpDatosEstudiantes.Controls.Add(this.btnAgregarRegistro);
            this.gpDatosEstudiantes.Controls.Add(this.txtCalificacion);
            this.gpDatosEstudiantes.Controls.Add(this.label1);
            this.gpDatosEstudiantes.Controls.Add(this.btnModificarProyecto);
            this.gpDatosEstudiantes.Controls.Add(this.txtFechaEntrega);
            this.gpDatosEstudiantes.Controls.Add(this.btnLimpiar);
            this.gpDatosEstudiantes.Controls.Add(this.pbIconoUser);
            this.gpDatosEstudiantes.Controls.Add(this.txtFechaLimite);
            this.gpDatosEstudiantes.Controls.Add(this.label7);
            this.gpDatosEstudiantes.Controls.Add(this.txtProyectoNombre);
            this.gpDatosEstudiantes.Controls.Add(this.label6);
            this.gpDatosEstudiantes.Controls.Add(this.txtApellidoEstudiante);
            this.gpDatosEstudiantes.Controls.Add(this.label5);
            this.gpDatosEstudiantes.Controls.Add(this.txtNombreEstudiante);
            this.gpDatosEstudiantes.Controls.Add(this.label4);
            this.gpDatosEstudiantes.Controls.Add(this.label3);
            this.gpDatosEstudiantes.Controls.Add(this.txtCarnet);
            this.gpDatosEstudiantes.Controls.Add(this.label2);
            this.gpDatosEstudiantes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDatosEstudiantes.ForeColor = System.Drawing.Color.White;
            this.gpDatosEstudiantes.Location = new System.Drawing.Point(3, 86);
            this.gpDatosEstudiantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpDatosEstudiantes.Name = "gpDatosEstudiantes";
            this.gpDatosEstudiantes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpDatosEstudiantes.Size = new System.Drawing.Size(484, 598);
            this.gpDatosEstudiantes.TabIndex = 29;
            this.gpDatosEstudiantes.TabStop = false;
            this.gpDatosEstudiantes.Text = "            Datos";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(12, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 45);
            this.label10.TabIndex = 82;
            this.label10.Text = "Numero De Estudiantes";
            // 
            // txtRutaFoto
            // 
            this.txtRutaFoto.Location = new System.Drawing.Point(321, 249);
            this.txtRutaFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRutaFoto.Name = "txtRutaFoto";
            this.txtRutaFoto.ReadOnly = true;
            this.txtRutaFoto.Size = new System.Drawing.Size(141, 22);
            this.txtRutaFoto.TabIndex = 81;
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.pbImagen.Location = new System.Drawing.Point(321, 116);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(141, 120);
            this.pbImagen.TabIndex = 80;
            this.pbImagen.TabStop = false;
            // 
            // cbCImagen
            // 
            this.cbCImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbCImagen.BackgroundImage")));
            this.cbCImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCImagen.FlatAppearance.BorderSize = 0;
            this.cbCImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCImagen.Location = new System.Drawing.Point(321, 279);
            this.cbCImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCImagen.Name = "cbCImagen";
            this.cbCImagen.Size = new System.Drawing.Size(141, 46);
            this.cbCImagen.TabIndex = 79;
            this.cbCImagen.Text = "Cargar Imagen";
            this.cbCImagen.UseVisualStyleBackColor = false;
            this.cbCImagen.Click += new System.EventHandler(this.cbCImagen_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(157, 56);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 22);
            this.txtCantidad.TabIndex = 78;
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCantidad.BackgroundImage")));
            this.btnCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCantidad.FlatAppearance.BorderSize = 0;
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidad.Location = new System.Drawing.Point(321, 37);
            this.btnCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(141, 54);
            this.btnCantidad.TabIndex = 77;
            this.btnCantidad.Text = "Establecer Cantidad";
            this.btnCantidad.UseVisualStyleBackColor = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(164, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "MM/DD/YYYY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(164, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "MM/DD/YYYY";
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarRegistro.BackgroundImage")));
            this.btnAgregarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarRegistro.FlatAppearance.BorderSize = 0;
            this.btnAgregarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(133, 505);
            this.btnAgregarRegistro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(150, 49);
            this.btnAgregarRegistro.TabIndex = 28;
            this.btnAgregarRegistro.Text = "Agregar Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = false;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(153, 451);
            this.txtCalificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(116, 22);
            this.txtCalificacion.TabIndex = 7;
            this.txtCalificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Calificación";
            // 
            // btnModificarProyecto
            // 
            this.btnModificarProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarProyecto.BackgroundImage")));
            this.btnModificarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProyecto.FlatAppearance.BorderSize = 0;
            this.btnModificarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProyecto.Location = new System.Drawing.Point(321, 358);
            this.btnModificarProyecto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarProyecto.Name = "btnModificarProyecto";
            this.btnModificarProyecto.Size = new System.Drawing.Size(141, 49);
            this.btnModificarProyecto.TabIndex = 12;
            this.btnModificarProyecto.Text = "Modificar Proyecto";
            this.btnModificarProyecto.UseVisualStyleBackColor = false;
            this.btnModificarProyecto.Click += new System.EventHandler(this.btnModificarProyecto_Click);
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(153, 397);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(116, 22);
            this.txtFechaEntrega.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(321, 447);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 49);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pbIconoUser
            // 
            this.pbIconoUser.Image = ((System.Drawing.Image)(resources.GetObject("pbIconoUser.Image")));
            this.pbIconoUser.Location = new System.Drawing.Point(6, 0);
            this.pbIconoUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbIconoUser.Name = "pbIconoUser";
            this.pbIconoUser.Size = new System.Drawing.Size(39, 33);
            this.pbIconoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoUser.TabIndex = 12;
            this.pbIconoUser.TabStop = false;
            // 
            // txtFechaLimite
            // 
            this.txtFechaLimite.Location = new System.Drawing.Point(153, 329);
            this.txtFechaLimite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFechaLimite.Name = "txtFechaLimite";
            this.txtFechaLimite.Size = new System.Drawing.Size(116, 22);
            this.txtFechaLimite.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha Limite";
            // 
            // txtProyectoNombre
            // 
            this.txtProyectoNombre.Location = new System.Drawing.Point(153, 267);
            this.txtProyectoNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProyectoNombre.Name = "txtProyectoNombre";
            this.txtProyectoNombre.Size = new System.Drawing.Size(116, 22);
            this.txtProyectoNombre.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Proyecto";
            // 
            // txtApellidoEstudiante
            // 
            this.txtApellidoEstudiante.Location = new System.Drawing.Point(153, 223);
            this.txtApellidoEstudiante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidoEstudiante.Name = "txtApellidoEstudiante";
            this.txtApellidoEstudiante.Size = new System.Drawing.Size(116, 22);
            this.txtApellidoEstudiante.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(153, 179);
            this.txtNombreEstudiante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(116, 22);
            this.txtNombreEstudiante.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Entrega";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(153, 138);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(116, 22);
            this.txtCarnet.TabIndex = 1;
            this.txtCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarnet_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carnet";
            // 
            // btnListarRegistros
            // 
            this.btnListarRegistros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarRegistros.BackgroundImage")));
            this.btnListarRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarRegistros.FlatAppearance.BorderSize = 0;
            this.btnListarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarRegistros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnListarRegistros.Location = new System.Drawing.Point(513, 477);
            this.btnListarRegistros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListarRegistros.Name = "btnListarRegistros";
            this.btnListarRegistros.Size = new System.Drawing.Size(164, 66);
            this.btnListarRegistros.TabIndex = 9;
            this.btnListarRegistros.Text = "Listar Registros";
            this.btnListarRegistros.UseVisualStyleBackColor = false;
            this.btnListarRegistros.Click += new System.EventHandler(this.btnListarRegistros_Click);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProyecto.BackgroundImage")));
            this.btnEliminarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProyecto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyecto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyecto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProyecto.Location = new System.Drawing.Point(939, 569);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(176, 58);
            this.btnEliminarProyecto.TabIndex = 10;
            this.btnEliminarProyecto.Text = "Eliminar Proyecto";
            this.btnEliminarProyecto.UseVisualStyleBackColor = false;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnProyectosAtrasados
            // 
            this.btnProyectosAtrasados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProyectosAtrasados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProyectosAtrasados.BackgroundImage")));
            this.btnProyectosAtrasados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectosAtrasados.FlatAppearance.BorderSize = 0;
            this.btnProyectosAtrasados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectosAtrasados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectosAtrasados.ForeColor = System.Drawing.Color.White;
            this.btnProyectosAtrasados.Location = new System.Drawing.Point(1099, 477);
            this.btnProyectosAtrasados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProyectosAtrasados.Name = "btnProyectosAtrasados";
            this.btnProyectosAtrasados.Size = new System.Drawing.Size(180, 66);
            this.btnProyectosAtrasados.TabIndex = 28;
            this.btnProyectosAtrasados.Text = "Proyectos Atrasados";
            this.btnProyectosAtrasados.UseVisualStyleBackColor = false;
            this.btnProyectosAtrasados.Click += new System.EventHandler(this.btnProyectosAtrasados_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(857, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ingresar ID";
            // 
            // txtBId
            // 
            this.txtBId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBId.Location = new System.Drawing.Point(823, 501);
            this.txtBId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(151, 22);
            this.txtBId.TabIndex = 31;
            this.txtBId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBId_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1305, 45);
            this.label13.TabIndex = 0;
            this.label13.Text = "AA2 Entrega De Proyectos";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbVolver
            // 
            this.pbVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbVolver.Image = ((System.Drawing.Image)(resources.GetObject("pbVolver.Image")));
            this.pbVolver.Location = new System.Drawing.Point(1255, 0);
            this.pbVolver.Name = "pbVolver";
            this.pbVolver.Size = new System.Drawing.Size(50, 45);
            this.pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVolver.TabIndex = 79;
            this.pbVolver.TabStop = false;
            this.pbVolver.Click += new System.EventHandler(this.pbVolver_Click);
            // 
            // FrmAA2_EntregaDeProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1305, 685);
            this.Controls.Add(this.pbVolver);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBId);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.btnBuscarProyecto);
            this.Controls.Add(this.gpDatosEstudiantes);
            this.Controls.Add(this.btnProyectosAtrasados);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.btnListarRegistros);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAA2_EntregaDeProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAA2_EntregaDeProyectos";
            this.Load += new System.EventHandler(this.FrmAA2_EntregaDeProyectos_Load);
            this.gpDatosEstudiantes.ResumeLayout(false);
            this.gpDatosEstudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbImprimir;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.GroupBox gpDatosEstudiantes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarRegistros;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Button btnModificarProyecto;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pbIconoUser;
        private System.Windows.Forms.TextBox txtFechaLimite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProyectoNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoEstudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProyectosAtrasados;
        private System.Windows.Forms.TextBox txtRutaFoto;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button cbCImagen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbVolver;
    }
}