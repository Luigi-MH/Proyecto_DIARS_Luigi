namespace PROYECTO_DIARS__LUIGI
{
    partial class frmVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gboxVentas = new System.Windows.Forms.GroupBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.gboxDetalleVenta = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.txtSubTotalDetalle = new System.Windows.Forms.TextBox();
            this.lblSubTotalDetalle = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gboxNotas = new System.Windows.Forms.GroupBox();
            this.rtbNotasVenta = new System.Windows.Forms.RichTextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDocCliente = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboxTipoDoc = new System.Windows.Forms.ComboBox();
            this.cboxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cboxTipoCPago = new System.Windows.Forms.ComboBox();
            this.lblTipoCPago = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.cboxEstadoVenta = new System.Windows.Forms.ComboBox();
            this.lblEstadoVenta = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxImporte = new System.Windows.Forms.GroupBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.cboxDescuentoPromocion = new System.Windows.Forms.ComboBox();
            this.btnCalcularSubtotal = new System.Windows.Forms.Button();
            this.gboxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.gboxVentas.SuspendLayout();
            this.gboxDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.gboxNotas.SuspendLayout();
            this.gboxImporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxProductos
            // 
            this.gboxProductos.Controls.Add(this.dgvVentas);
            this.gboxProductos.Controls.Add(this.btnEliminar);
            this.gboxProductos.Controls.Add(this.btnNuevo);
            this.gboxProductos.Controls.Add(this.btnEditar);
            this.gboxProductos.Controls.Add(this.gboxVentas);
            this.gboxProductos.Controls.Add(this.btnSalir);
            this.gboxProductos.Location = new System.Drawing.Point(12, 12);
            this.gboxProductos.Name = "gboxProductos";
            this.gboxProductos.Size = new System.Drawing.Size(1676, 726);
            this.gboxProductos.TabIndex = 15;
            this.gboxProductos.TabStop = false;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(16, 28);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(667, 677);
            this.dgvVentas.TabIndex = 59;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1559, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1559, 113);
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
            this.btnEditar.Location = new System.Drawing.Point(1559, 157);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gboxVentas
            // 
            this.gboxVentas.Controls.Add(this.cboxCliente);
            this.gboxVentas.Controls.Add(this.lblCorrelativo);
            this.gboxVentas.Controls.Add(this.txtCorrelativo);
            this.gboxVentas.Controls.Add(this.lblSerie);
            this.gboxVentas.Controls.Add(this.txtSerie);
            this.gboxVentas.Controls.Add(this.lblDoc);
            this.gboxVentas.Controls.Add(this.gboxDetalleVenta);
            this.gboxVentas.Controls.Add(this.gboxNotas);
            this.gboxVentas.Controls.Add(this.btnBuscarCliente);
            this.gboxVentas.Controls.Add(this.txtDocCliente);
            this.gboxVentas.Controls.Add(this.lblTipoDocumento);
            this.gboxVentas.Controls.Add(this.cboxTipoDoc);
            this.gboxVentas.Controls.Add(this.cboxMetodoPago);
            this.gboxVentas.Controls.Add(this.lblMetodoPago);
            this.gboxVentas.Controls.Add(this.cboxTipoCPago);
            this.gboxVentas.Controls.Add(this.lblTipoCPago);
            this.gboxVentas.Controls.Add(this.txtId);
            this.gboxVentas.Controls.Add(this.lblId);
            this.gboxVentas.Controls.Add(this.btnRegistrarCliente);
            this.gboxVentas.Controls.Add(this.cboxEstadoVenta);
            this.gboxVentas.Controls.Add(this.lblEstadoVenta);
            this.gboxVentas.Controls.Add(this.btnModificar);
            this.gboxVentas.Controls.Add(this.btnAgregar);
            this.gboxVentas.Controls.Add(this.btnCancelar);
            this.gboxVentas.Controls.Add(this.gboxImporte);
            this.gboxVentas.Controls.Add(this.txtCliente);
            this.gboxVentas.Controls.Add(this.lblNombreProducto);
            this.gboxVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxVentas.Location = new System.Drawing.Point(701, 18);
            this.gboxVentas.Margin = new System.Windows.Forms.Padding(2);
            this.gboxVentas.Name = "gboxVentas";
            this.gboxVentas.Padding = new System.Windows.Forms.Padding(2);
            this.gboxVentas.Size = new System.Drawing.Size(845, 687);
            this.gboxVentas.TabIndex = 54;
            this.gboxVentas.TabStop = false;
            this.gboxVentas.Text = "Ventas";
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(167, 59);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerie.MaxLength = 64;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(71, 22);
            this.txtSerie.TabIndex = 92;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(164, 96);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(62, 13);
            this.lblDoc.TabIndex = 91;
            this.lblDoc.Text = "Documento";
            // 
            // gboxDetalleVenta
            // 
            this.gboxDetalleVenta.Controls.Add(this.btnCalcularSubtotal);
            this.gboxDetalleVenta.Controls.Add(this.cboxDescuentoPromocion);
            this.gboxDetalleVenta.Controls.Add(this.txtProducto);
            this.gboxDetalleVenta.Controls.Add(this.lblNomProducto);
            this.gboxDetalleVenta.Controls.Add(this.btnEliminarDetalle);
            this.gboxDetalleVenta.Controls.Add(this.btnAgregarDetalle);
            this.gboxDetalleVenta.Controls.Add(this.lblPromocion);
            this.gboxDetalleVenta.Controls.Add(this.txtSubTotalDetalle);
            this.gboxDetalleVenta.Controls.Add(this.lblSubTotalDetalle);
            this.gboxDetalleVenta.Controls.Add(this.txtPrecio);
            this.gboxDetalleVenta.Controls.Add(this.lblPrecio);
            this.gboxDetalleVenta.Controls.Add(this.cboxUnidadMedida);
            this.gboxDetalleVenta.Controls.Add(this.lblUnidadMedida);
            this.gboxDetalleVenta.Controls.Add(this.txtCantidad);
            this.gboxDetalleVenta.Controls.Add(this.lblCantidad);
            this.gboxDetalleVenta.Controls.Add(this.cboxProducto);
            this.gboxDetalleVenta.Controls.Add(this.btnBuscarProducto);
            this.gboxDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.gboxDetalleVenta.Controls.Add(this.lblProducto);
            this.gboxDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDetalleVenta.Location = new System.Drawing.Point(29, 169);
            this.gboxDetalleVenta.Name = "gboxDetalleVenta";
            this.gboxDetalleVenta.Size = new System.Drawing.Size(781, 338);
            this.gboxDetalleVenta.TabIndex = 90;
            this.gboxDetalleVenta.TabStop = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(16, 28);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.MaxLength = 64;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(237, 22);
            this.txtProducto.TabIndex = 93;
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProducto.Location = new System.Drawing.Point(342, 15);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(50, 13);
            this.lblNomProducto.TabIndex = 104;
            this.lblNomProducto.Text = "Producto";
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.Location = new System.Drawing.Point(676, 77);
            this.btnEliminarDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(100, 36);
            this.btnEliminarDetalle.TabIndex = 103;
            this.btnEliminarDetalle.Text = "Quitar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(676, 15);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(100, 59);
            this.btnAgregarDetalle.TabIndex = 102;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.AgregarDetalle_Click);
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(457, 62);
            this.lblPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(79, 13);
            this.lblPromocion.TabIndex = 100;
            this.lblPromocion.Text = "Desc. Promo %";
            // 
            // txtSubTotalDetalle
            // 
            this.txtSubTotalDetalle.Enabled = false;
            this.txtSubTotalDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalDetalle.Location = new System.Drawing.Point(564, 77);
            this.txtSubTotalDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotalDetalle.MaxLength = 7;
            this.txtSubTotalDetalle.Name = "txtSubTotalDetalle";
            this.txtSubTotalDetalle.Size = new System.Drawing.Size(83, 22);
            this.txtSubTotalDetalle.TabIndex = 99;
            this.txtSubTotalDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubTotalDetalle
            // 
            this.lblSubTotalDetalle.AutoSize = true;
            this.lblSubTotalDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalDetalle.Location = new System.Drawing.Point(562, 62);
            this.lblSubTotalDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotalDetalle.Name = "lblSubTotalDetalle";
            this.lblSubTotalDetalle.Size = new System.Drawing.Size(50, 13);
            this.lblSubTotalDetalle.TabIndex = 98;
            this.lblSubTotalDetalle.Text = "SubTotal";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(345, 77);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.MaxLength = 7;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(83, 22);
            this.txtPrecio.TabIndex = 97;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(343, 62);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 96;
            this.lblPrecio.Text = "Precio";
            // 
            // cboxUnidadMedida
            // 
            this.cboxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUnidadMedida.FormattingEnabled = true;
            this.cboxUnidadMedida.Location = new System.Drawing.Point(183, 77);
            this.cboxUnidadMedida.Name = "cboxUnidadMedida";
            this.cboxUnidadMedida.Size = new System.Drawing.Size(120, 24);
            this.cboxUnidadMedida.TabIndex = 94;
            this.cboxUnidadMedida.SelectedValueChanged += new System.EventHandler(this.cboxUnidadMedida_SelectedValueChanged);
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(180, 61);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(79, 13);
            this.lblUnidadMedida.TabIndex = 95;
            this.lblUnidadMedida.Text = "Unidad Medida";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(16, 77);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.MaxLength = 7;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(83, 22);
            this.txtCantidad.TabIndex = 93;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(13, 62);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 92;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboxProducto
            // 
            this.cboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(345, 28);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(302, 24);
            this.cboxProducto.TabIndex = 91;
            this.cboxProducto.SelectedValueChanged += new System.EventHandler(this.cboxProducto_SelectedValueChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(258, 29);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarProducto.TabIndex = 90;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(7, 117);
            this.dgvDetalleVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(769, 215);
            this.dgvDetalleVenta.TabIndex = 55;
            this.dgvDetalleVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellDoubleClick);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(13, 15);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 73;
            this.lblProducto.Text = "Producto";
            // 
            // gboxNotas
            // 
            this.gboxNotas.Controls.Add(this.rtbNotasVenta);
            this.gboxNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNotas.Location = new System.Drawing.Point(29, 514);
            this.gboxNotas.Name = "gboxNotas";
            this.gboxNotas.Size = new System.Drawing.Size(233, 98);
            this.gboxNotas.TabIndex = 88;
            this.gboxNotas.TabStop = false;
            this.gboxNotas.Text = "Notas";
            // 
            // rtbNotasVenta
            // 
            this.rtbNotasVenta.Location = new System.Drawing.Point(7, 22);
            this.rtbNotasVenta.Name = "rtbNotasVenta";
            this.rtbNotasVenta.Size = new System.Drawing.Size(220, 70);
            this.rtbNotasVenta.TabIndex = 0;
            this.rtbNotasVenta.Text = "";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(740, 113);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(70, 23);
            this.btnBuscarCliente.TabIndex = 89;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDocCliente
            // 
            this.txtDocCliente.Location = new System.Drawing.Point(167, 111);
            this.txtDocCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocCliente.Name = "txtDocCliente";
            this.txtDocCliente.Size = new System.Drawing.Size(145, 22);
            this.txtDocCliente.TabIndex = 88;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(26, 95);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 87;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // cboxTipoDoc
            // 
            this.cboxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoDoc.FormattingEnabled = true;
            this.cboxTipoDoc.Location = new System.Drawing.Point(29, 111);
            this.cboxTipoDoc.Name = "cboxTipoDoc";
            this.cboxTipoDoc.Size = new System.Drawing.Size(133, 24);
            this.cboxTipoDoc.TabIndex = 86;
            // 
            // cboxMetodoPago
            // 
            this.cboxMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMetodoPago.FormattingEnabled = true;
            this.cboxMetodoPago.Location = new System.Drawing.Point(381, 59);
            this.cboxMetodoPago.Name = "cboxMetodoPago";
            this.cboxMetodoPago.Size = new System.Drawing.Size(141, 24);
            this.cboxMetodoPago.TabIndex = 84;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(378, 44);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(71, 13);
            this.lblMetodoPago.TabIndex = 85;
            this.lblMetodoPago.Text = "Metodo Pago";
            // 
            // cboxTipoCPago
            // 
            this.cboxTipoCPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoCPago.FormattingEnabled = true;
            this.cboxTipoCPago.Location = new System.Drawing.Point(29, 59);
            this.cboxTipoCPago.Name = "cboxTipoCPago";
            this.cboxTipoCPago.Size = new System.Drawing.Size(133, 24);
            this.cboxTipoCPago.TabIndex = 80;
            this.cboxTipoCPago.SelectedValueChanged += new System.EventHandler(this.cboxTipoCPago_SelectedValueChanged);
            // 
            // lblTipoCPago
            // 
            this.lblTipoCPago.AutoSize = true;
            this.lblTipoCPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCPago.Location = new System.Drawing.Point(26, 44);
            this.lblTipoCPago.Name = "lblTipoCPago";
            this.lblTipoCPago.Size = new System.Drawing.Size(122, 13);
            this.lblTipoCPago.TabIndex = 81;
            this.lblTipoCPago.Text = "Tipo Comprobante Pago";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(715, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 22);
            this.txtId.TabIndex = 55;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(691, 62);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 54;
            this.lblId.Text = "N°";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Enabled = false;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(212, 139);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(70, 24);
            this.btnRegistrarCliente.TabIndex = 75;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // cboxEstadoVenta
            // 
            this.cboxEstadoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstadoVenta.Enabled = false;
            this.cboxEstadoVenta.FormattingEnabled = true;
            this.cboxEstadoVenta.Location = new System.Drawing.Point(528, 61);
            this.cboxEstadoVenta.Name = "cboxEstadoVenta";
            this.cboxEstadoVenta.Size = new System.Drawing.Size(136, 24);
            this.cboxEstadoVenta.TabIndex = 62;
            // 
            // lblEstadoVenta
            // 
            this.lblEstadoVenta.AutoSize = true;
            this.lblEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVenta.Location = new System.Drawing.Point(525, 45);
            this.lblEstadoVenta.Name = "lblEstadoVenta";
            this.lblEstadoVenta.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoVenta.TabIndex = 63;
            this.lblEstadoVenta.Text = "Estado";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(542, 631);
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
            this.btnAgregar.Location = new System.Drawing.Point(334, 631);
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
            this.btnCancelar.Location = new System.Drawing.Point(438, 631);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 48);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gboxImporte
            // 
            this.gboxImporte.Controls.Add(this.txtIGV);
            this.gboxImporte.Controls.Add(this.lblIGV);
            this.gboxImporte.Controls.Add(this.txtSubTotal);
            this.gboxImporte.Controls.Add(this.lblSubTotal);
            this.gboxImporte.Controls.Add(this.txtTotal);
            this.gboxImporte.Controls.Add(this.lblTotal);
            this.gboxImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImporte.Location = new System.Drawing.Point(276, 514);
            this.gboxImporte.Name = "gboxImporte";
            this.gboxImporte.Size = new System.Drawing.Size(534, 98);
            this.gboxImporte.TabIndex = 50;
            this.gboxImporte.TabStop = false;
            this.gboxImporte.Text = "Importes";
            // 
            // txtIGV
            // 
            this.txtIGV.Enabled = false;
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(253, 38);
            this.txtIGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtIGV.MaxLength = 7;
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(83, 26);
            this.txtIGV.TabIndex = 87;
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(215, 43);
            this.lblIGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(34, 13);
            this.lblIGV.TabIndex = 86;
            this.lblIGV.Text = "I.G.V.";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(98, 38);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.MaxLength = 7;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(83, 26);
            this.txtSubTotal.TabIndex = 85;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(25, 46);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(71, 13);
            this.lblSubTotal.TabIndex = 84;
            this.lblSubTotal.Text = "Sub Total S/.";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(401, 38);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 7;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 26);
            this.txtTotal.TabIndex = 83;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(366, 43);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 82;
            this.lblTotal.Text = "Total";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(316, 113);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(419, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(313, 98);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(39, 13);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Cliente";
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
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(164, 44);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(31, 13);
            this.lblSerie.TabIndex = 93;
            this.lblSerie.Text = "Serie";
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AutoSize = true;
            this.lblCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.Location = new System.Drawing.Point(239, 44);
            this.lblCorrelativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(57, 13);
            this.lblCorrelativo.TabIndex = 95;
            this.lblCorrelativo.Text = "Correlativo";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Enabled = false;
            this.txtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativo.Location = new System.Drawing.Point(242, 59);
            this.txtCorrelativo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorrelativo.MaxLength = 64;
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(105, 22);
            this.txtCorrelativo.TabIndex = 94;
            // 
            // cboxCliente
            // 
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(316, 140);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(494, 24);
            this.cboxCliente.TabIndex = 96;
            // 
            // cboxDescuentoPromocion
            // 
            this.cboxDescuentoPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDescuentoPromocion.Enabled = false;
            this.cboxDescuentoPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDescuentoPromocion.FormattingEnabled = true;
            this.cboxDescuentoPromocion.Location = new System.Drawing.Point(460, 77);
            this.cboxDescuentoPromocion.Name = "cboxDescuentoPromocion";
            this.cboxDescuentoPromocion.Size = new System.Drawing.Size(76, 24);
            this.cboxDescuentoPromocion.TabIndex = 105;
            // 
            // btnCalcularSubtotal
            // 
            this.btnCalcularSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSubtotal.Location = new System.Drawing.Point(104, 76);
            this.btnCalcularSubtotal.Name = "btnCalcularSubtotal";
            this.btnCalcularSubtotal.Size = new System.Drawing.Size(60, 23);
            this.btnCalcularSubtotal.TabIndex = 106;
            this.btnCalcularSubtotal.Text = "Calcular";
            this.btnCalcularSubtotal.UseVisualStyleBackColor = true;
            this.btnCalcularSubtotal.Click += new System.EventHandler(this.btnCalcularSubtotal_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 750);
            this.Controls.Add(this.gboxProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gboxProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.gboxVentas.ResumeLayout(false);
            this.gboxVentas.PerformLayout();
            this.gboxDetalleVenta.ResumeLayout(false);
            this.gboxDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.gboxNotas.ResumeLayout(false);
            this.gboxImporte.ResumeLayout(false);
            this.gboxImporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxProductos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.GroupBox gboxVentas;
        private System.Windows.Forms.ComboBox cboxMetodoPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboxTipoCPago;
        private System.Windows.Forms.Label lblTipoCPago;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboxEstadoVenta;
        private System.Windows.Forms.Label lblEstadoVenta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gboxImporte;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboxTipoDoc;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDocCliente;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox gboxNotas;
        private System.Windows.Forms.RichTextBox rtbNotasVenta;
        private System.Windows.Forms.GroupBox gboxDetalleVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.ComboBox cboxProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboxUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtSubTotalDetalle;
        private System.Windows.Forms.Label lblSubTotalDetalle;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.ComboBox cboxDescuentoPromocion;
        private System.Windows.Forms.Button btnCalcularSubtotal;
    }
}