namespace PROYECTO_DIARS__LUIGI
{
    partial class frmProductos
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
            this.gboxProductos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.txtDocumentoApellidos = new System.Windows.Forms.TextBox();
            this.lblNombreLabFabricante = new System.Windows.Forms.Label();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cboxLaboratorioFabricante = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxGenericoReceta = new System.Windows.Forms.GroupBox();
            this.chbNecesitaReceta = new System.Windows.Forms.CheckBox();
            this.chbEsGenerico = new System.Windows.Forms.CheckBox();
            this.txtNumCodBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblLaboratorioFabricante = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gboxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gboxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gboxGenericoReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxProductos
            // 
            this.gboxProductos.Controls.Add(this.btnEliminar);
            this.gboxProductos.Controls.Add(this.btnNuevo);
            this.gboxProductos.Controls.Add(this.btnEditar);
            this.gboxProductos.Controls.Add(this.dgvProductos);
            this.gboxProductos.Controls.Add(this.gboxDatos);
            this.gboxProductos.Controls.Add(this.btnSalir);
            this.gboxProductos.Location = new System.Drawing.Point(12, 12);
            this.gboxProductos.Name = "gboxProductos";
            this.gboxProductos.Size = new System.Drawing.Size(1676, 726);
            this.gboxProductos.TabIndex = 14;
            this.gboxProductos.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1565, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1565, 173);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 57;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1565, 217);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(15, 29);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(795, 679);
            this.dgvProductos.TabIndex = 55;
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.cboxEstado);
            this.gboxDatos.Controls.Add(this.lblEstado);
            this.gboxDatos.Controls.Add(this.txtPrecio);
            this.gboxDatos.Controls.Add(this.lblPrecio);
            this.gboxDatos.Controls.Add(this.cboxUnidadMedida);
            this.gboxDatos.Controls.Add(this.lblUnidadMedida);
            this.gboxDatos.Controls.Add(this.txtDocumentoApellidos);
            this.gboxDatos.Controls.Add(this.lblNombreLabFabricante);
            this.gboxDatos.Controls.Add(this.btnSeleccionarFoto);
            this.gboxDatos.Controls.Add(this.pbFoto);
            this.gboxDatos.Controls.Add(this.txtId);
            this.gboxDatos.Controls.Add(this.lblId);
            this.gboxDatos.Controls.Add(this.btnBuscar);
            this.gboxDatos.Controls.Add(this.txtDescripcion);
            this.gboxDatos.Controls.Add(this.lblDescripcion);
            this.gboxDatos.Controls.Add(this.cboxLaboratorioFabricante);
            this.gboxDatos.Controls.Add(this.cboxCategoria);
            this.gboxDatos.Controls.Add(this.lblCategoria);
            this.gboxDatos.Controls.Add(this.btnModificar);
            this.gboxDatos.Controls.Add(this.btnAgregar);
            this.gboxDatos.Controls.Add(this.btnCancelar);
            this.gboxDatos.Controls.Add(this.gboxGenericoReceta);
            this.gboxDatos.Controls.Add(this.txtNumCodBarras);
            this.gboxDatos.Controls.Add(this.lblCodigoBarras);
            this.gboxDatos.Controls.Add(this.txtNombreProducto);
            this.gboxDatos.Controls.Add(this.lblLaboratorioFabricante);
            this.gboxDatos.Controls.Add(this.lblNombreProducto);
            this.gboxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatos.Location = new System.Drawing.Point(828, 29);
            this.gboxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Size = new System.Drawing.Size(726, 553);
            this.gboxDatos.TabIndex = 54;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos";
            // 
            // txtDocumentoApellidos
            // 
            this.txtDocumentoApellidos.Location = new System.Drawing.Point(39, 221);
            this.txtDocumentoApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoApellidos.MaxLength = 64;
            this.txtDocumentoApellidos.Name = "txtDocumentoApellidos";
            this.txtDocumentoApellidos.Size = new System.Drawing.Size(349, 22);
            this.txtDocumentoApellidos.TabIndex = 79;
            // 
            // lblNombreLabFabricante
            // 
            this.lblNombreLabFabricante.AutoSize = true;
            this.lblNombreLabFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLabFabricante.Location = new System.Drawing.Point(36, 206);
            this.lblNombreLabFabricante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreLabFabricante.Name = "lblNombreLabFabricante";
            this.lblNombreLabFabricante.Size = new System.Drawing.Size(78, 13);
            this.lblNombreLabFabricante.TabIndex = 78;
            this.lblNombreLabFabricante.Text = "Lab. Fafricante";
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(543, 303);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(97, 25);
            this.btnSeleccionarFoto.TabIndex = 77;
            this.btnSeleccionarFoto.Text = "Seleccionar";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(488, 47);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(200, 250);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 76;
            this.pbFoto.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(345, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(107, 22);
            this.txtId.TabIndex = 55;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(321, 59);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 54;
            this.lblId.Text = "N°";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(393, 220);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 24);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(41, 109);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaxLength = 64;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(412, 22);
            this.txtDescripcion.TabIndex = 74;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(37, 94);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 73;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cboxLaboratorioFabricante
            // 
            this.cboxLaboratorioFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLaboratorioFabricante.FormattingEnabled = true;
            this.cboxLaboratorioFabricante.Location = new System.Drawing.Point(40, 273);
            this.cboxLaboratorioFabricante.Name = "cboxLaboratorioFabricante";
            this.cboxLaboratorioFabricante.Size = new System.Drawing.Size(412, 24);
            this.cboxLaboratorioFabricante.TabIndex = 64;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(41, 162);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(182, 24);
            this.cboxCategoria.TabIndex = 62;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(38, 146);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(185, 449);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 48);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(81, 449);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 48);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(288, 449);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 48);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gboxGenericoReceta
            // 
            this.gboxGenericoReceta.Controls.Add(this.chbNecesitaReceta);
            this.gboxGenericoReceta.Controls.Add(this.chbEsGenerico);
            this.gboxGenericoReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxGenericoReceta.Location = new System.Drawing.Point(41, 303);
            this.gboxGenericoReceta.Name = "gboxGenericoReceta";
            this.gboxGenericoReceta.Size = new System.Drawing.Size(411, 53);
            this.gboxGenericoReceta.TabIndex = 50;
            this.gboxGenericoReceta.TabStop = false;
            // 
            // chbNecesitaReceta
            // 
            this.chbNecesitaReceta.AutoSize = true;
            this.chbNecesitaReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNecesitaReceta.Location = new System.Drawing.Point(207, 21);
            this.chbNecesitaReceta.Name = "chbNecesitaReceta";
            this.chbNecesitaReceta.Size = new System.Drawing.Size(131, 19);
            this.chbNecesitaReceta.TabIndex = 1;
            this.chbNecesitaReceta.Text = "Necesita Receta";
            this.chbNecesitaReceta.UseVisualStyleBackColor = true;
            // 
            // chbEsGenerico
            // 
            this.chbEsGenerico.AutoSize = true;
            this.chbEsGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEsGenerico.Location = new System.Drawing.Point(37, 21);
            this.chbEsGenerico.Name = "chbEsGenerico";
            this.chbEsGenerico.Size = new System.Drawing.Size(104, 19);
            this.chbEsGenerico.TabIndex = 0;
            this.chbEsGenerico.Text = "Es Generico";
            this.chbEsGenerico.UseVisualStyleBackColor = true;
            // 
            // txtNumCodBarras
            // 
            this.txtNumCodBarras.Location = new System.Drawing.Point(257, 162);
            this.txtNumCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCodBarras.MaxLength = 40;
            this.txtNumCodBarras.Name = "txtNumCodBarras";
            this.txtNumCodBarras.Size = new System.Drawing.Size(195, 22);
            this.txtNumCodBarras.TabIndex = 10;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.Location = new System.Drawing.Point(255, 147);
            this.lblCodigoBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoBarras.TabIndex = 9;
            this.lblCodigoBarras.Text = "N° Codigo Barras";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(40, 56);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.MaxLength = 30;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(219, 22);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // lblLaboratorioFabricante
            // 
            this.lblLaboratorioFabricante.AutoSize = true;
            this.lblLaboratorioFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorioFabricante.Location = new System.Drawing.Point(36, 257);
            this.lblLaboratorioFabricante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaboratorioFabricante.Name = "lblLaboratorioFabricante";
            this.lblLaboratorioFabricante.Size = new System.Drawing.Size(113, 13);
            this.lblLaboratorioFabricante.TabIndex = 2;
            this.lblLaboratorioFabricante.Text = "Laboratorio Fabricante";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(37, 41);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1640, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboxUnidadMedida
            // 
            this.cboxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnidadMedida.FormattingEnabled = true;
            this.cboxUnidadMedida.Location = new System.Drawing.Point(41, 385);
            this.cboxUnidadMedida.Name = "cboxUnidadMedida";
            this.cboxUnidadMedida.Size = new System.Drawing.Size(182, 24);
            this.cboxUnidadMedida.TabIndex = 80;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(38, 369);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(79, 13);
            this.lblUnidadMedida.TabIndex = 81;
            this.lblUnidadMedida.Text = "Unidad Medida";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(234, 387);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.MaxLength = 7;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(86, 22);
            this.txtPrecio.TabIndex = 83;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(231, 372);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 82;
            this.lblPrecio.Text = "Precio";
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(334, 385);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(119, 24);
            this.cboxEstado.TabIndex = 84;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(331, 369);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 85;
            this.lblEstado.Text = "Estado";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 750);
            this.Controls.Add(this.gboxProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gboxProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gboxGenericoReceta.ResumeLayout(false);
            this.gboxGenericoReceta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cboxLaboratorioFabricante;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gboxGenericoReceta;
        private System.Windows.Forms.TextBox txtNumCodBarras;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblLaboratorioFabricante;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtDocumentoApellidos;
        private System.Windows.Forms.Label lblNombreLabFabricante;
        private System.Windows.Forms.CheckBox chbEsGenerico;
        private System.Windows.Forms.CheckBox chbNecesitaReceta;
        private System.Windows.Forms.ComboBox cboxUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}