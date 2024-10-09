namespace PROYECTO_DIARS__LUIGI
{
    partial class frmEmpleados
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxEmpleados = new System.Windows.Forms.GroupBox();
            this.chboxVerFotoLista = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gboxDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFehaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cboxTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.dtpFechaContratacionE = new System.Windows.Forms.DateTimePicker();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxEstado = new System.Windows.Forms.GroupBox();
            this.rdInactivo = new System.Windows.Forms.RadioButton();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.txtDocEmpleado = new System.Windows.Forms.TextBox();
            this.lblNumDocumento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.gboxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gboxDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gboxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(2083, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gboxEmpleados
            // 
            this.gboxEmpleados.Controls.Add(this.chboxVerFotoLista);
            this.gboxEmpleados.Controls.Add(this.btnEliminar);
            this.gboxEmpleados.Controls.Add(this.btnNuevo);
            this.gboxEmpleados.Controls.Add(this.btnEditar);
            this.gboxEmpleados.Controls.Add(this.dgvEmpleados);
            this.gboxEmpleados.Controls.Add(this.gboxDatosEmpleado);
            this.gboxEmpleados.Location = new System.Drawing.Point(12, 12);
            this.gboxEmpleados.Name = "gboxEmpleados";
            this.gboxEmpleados.Size = new System.Drawing.Size(1676, 726);
            this.gboxEmpleados.TabIndex = 15;
            this.gboxEmpleados.TabStop = false;
            // 
            // chboxVerFotoLista
            // 
            this.chboxVerFotoLista.AutoSize = true;
            this.chboxVerFotoLista.Location = new System.Drawing.Point(988, 685);
            this.chboxVerFotoLista.Name = "chboxVerFotoLista";
            this.chboxVerFotoLista.Size = new System.Drawing.Size(91, 17);
            this.chboxVerFotoLista.TabIndex = 49;
            this.chboxVerFotoLista.Text = "Ver Foto Lista";
            this.chboxVerFotoLista.UseVisualStyleBackColor = true;
            this.chboxVerFotoLista.CheckedChanged += new System.EventHandler(this.chboxVerFotoLista_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1566, 378);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1566, 289);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 40);
            this.btnNuevo.TabIndex = 47;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1566, 333);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(18, 18);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(950, 685);
            this.dgvEmpleados.TabIndex = 14;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // gboxDatosEmpleado
            // 
            this.gboxDatosEmpleado.Controls.Add(this.btnBuscar);
            this.gboxDatosEmpleado.Controls.Add(this.lblFechaNacimiento);
            this.gboxDatosEmpleado.Controls.Add(this.dtpFehaNacimiento);
            this.gboxDatosEmpleado.Controls.Add(this.btnSeleccionarFoto);
            this.gboxDatosEmpleado.Controls.Add(this.pbFoto);
            this.gboxDatosEmpleado.Controls.Add(this.lblTipoDoc);
            this.gboxDatosEmpleado.Controls.Add(this.cboxTipoDoc);
            this.gboxDatosEmpleado.Controls.Add(this.txtId);
            this.gboxDatosEmpleado.Controls.Add(this.lblId);
            this.gboxDatosEmpleado.Controls.Add(this.lblCargo);
            this.gboxDatosEmpleado.Controls.Add(this.cboxCargo);
            this.gboxDatosEmpleado.Controls.Add(this.txtApellidos);
            this.gboxDatosEmpleado.Controls.Add(this.lblApellidos);
            this.gboxDatosEmpleado.Controls.Add(this.dtpFechaContratacionE);
            this.gboxDatosEmpleado.Controls.Add(this.txtSalario);
            this.gboxDatosEmpleado.Controls.Add(this.lblSalario);
            this.gboxDatosEmpleado.Controls.Add(this.lblFechaContratacion);
            this.gboxDatosEmpleado.Controls.Add(this.btnModificar);
            this.gboxDatosEmpleado.Controls.Add(this.btnAgregar);
            this.gboxDatosEmpleado.Controls.Add(this.btnCancelar);
            this.gboxDatosEmpleado.Controls.Add(this.gboxEstado);
            this.gboxDatosEmpleado.Controls.Add(this.txtDocEmpleado);
            this.gboxDatosEmpleado.Controls.Add(this.lblNumDocumento);
            this.gboxDatosEmpleado.Controls.Add(this.txtNumero);
            this.gboxDatosEmpleado.Controls.Add(this.lblNumero);
            this.gboxDatosEmpleado.Controls.Add(this.txtCorreo);
            this.gboxDatosEmpleado.Controls.Add(this.txtNombres);
            this.gboxDatosEmpleado.Controls.Add(this.lblCorreo);
            this.gboxDatosEmpleado.Controls.Add(this.lblNombres);
            this.gboxDatosEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatosEmpleado.Location = new System.Drawing.Point(988, 18);
            this.gboxDatosEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.gboxDatosEmpleado.Name = "gboxDatosEmpleado";
            this.gboxDatosEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.gboxDatosEmpleado.Size = new System.Drawing.Size(563, 650);
            this.gboxDatosEmpleado.TabIndex = 13;
            this.gboxDatosEmpleado.TabStop = false;
            this.gboxDatosEmpleado.Text = "Datos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(471, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(253, 298);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(72, 13);
            this.lblFechaNacimiento.TabIndex = 71;
            this.lblFechaNacimiento.Text = "F. Nacimiento";
            // 
            // dtpFehaNacimiento
            // 
            this.dtpFehaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFehaNacimiento.Location = new System.Drawing.Point(330, 292);
            this.dtpFehaNacimiento.Name = "dtpFehaNacimiento";
            this.dtpFehaNacimiento.Size = new System.Drawing.Size(106, 22);
            this.dtpFehaNacimiento.TabIndex = 70;
            this.dtpFehaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFehaNacimiento_KeyPress);
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(95, 292);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(97, 25);
            this.btnSeleccionarFoto.TabIndex = 69;
            this.btnSeleccionarFoto.Text = "Seleccionar";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = true;
            this.btnSeleccionarFoto.Click += new System.EventHandler(this.btnSeleccionarFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(40, 36);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(200, 250);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 68;
            this.pbFoto.TabStop = false;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(263, 59);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDoc.TabIndex = 67;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // cboxTipoDoc
            // 
            this.cboxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoDoc.FormattingEnabled = true;
            this.cboxTipoDoc.Location = new System.Drawing.Point(354, 54);
            this.cboxTipoDoc.Name = "cboxTipoDoc";
            this.cboxTipoDoc.Size = new System.Drawing.Size(121, 24);
            this.cboxTipoDoc.TabIndex = 66;
            this.cboxTipoDoc.SelectedValueChanged += new System.EventHandler(this.cboxTipoDoc_SelectedValueChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(486, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 22);
            this.txtId.TabIndex = 65;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(460, 23);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 64;
            this.lblId.Text = "N°";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(337, 345);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 63;
            this.lblCargo.Text = "Cargo";
            // 
            // cboxCargo
            // 
            this.cboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(378, 341);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(153, 24);
            this.cboxCargo.TabIndex = 62;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(330, 193);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(201, 22);
            this.txtApellidos.TabIndex = 61;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(277, 198);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 60;
            this.lblApellidos.Text = "Apellidos";
            // 
            // dtpFechaContratacionE
            // 
            this.dtpFechaContratacionE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContratacionE.Location = new System.Drawing.Point(204, 391);
            this.dtpFechaContratacionE.MinDate = new System.DateTime(1880, 12, 25, 0, 0, 0, 0);
            this.dtpFechaContratacionE.Name = "dtpFechaContratacionE";
            this.dtpFechaContratacionE.Size = new System.Drawing.Size(112, 22);
            this.dtpFechaContratacionE.TabIndex = 59;
            this.dtpFechaContratacionE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaContratacionE_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(378, 391);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(153, 22);
            this.txtSalario.TabIndex = 58;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(334, 395);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 57;
            this.lblSalario.Text = "Salario";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaContratacion.Location = new System.Drawing.Point(120, 395);
            this.lblFechaContratacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(79, 13);
            this.lblFechaContratacion.TabIndex = 54;
            this.lblFechaContratacion.Text = "F. Contratacion";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(250, 547);
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
            this.btnAgregar.Location = new System.Drawing.Point(354, 547);
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
            this.btnCancelar.Location = new System.Drawing.Point(146, 547);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 48);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gboxEstado
            // 
            this.gboxEstado.Controls.Add(this.rdInactivo);
            this.gboxEstado.Controls.Add(this.rdActivo);
            this.gboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEstado.Location = new System.Drawing.Point(40, 434);
            this.gboxEstado.Name = "gboxEstado";
            this.gboxEstado.Size = new System.Drawing.Size(491, 75);
            this.gboxEstado.TabIndex = 50;
            this.gboxEstado.TabStop = false;
            this.gboxEstado.Text = "Estado";
            // 
            // rdInactivo
            // 
            this.rdInactivo.AutoSize = true;
            this.rdInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInactivo.Location = new System.Drawing.Point(300, 31);
            this.rdInactivo.Name = "rdInactivo";
            this.rdInactivo.Size = new System.Drawing.Size(79, 20);
            this.rdInactivo.TabIndex = 1;
            this.rdInactivo.TabStop = true;
            this.rdInactivo.Text = "Inactivo";
            this.rdInactivo.UseVisualStyleBackColor = true;
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.Checked = true;
            this.rdActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActivo.Location = new System.Drawing.Point(127, 31);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(68, 20);
            this.rdActivo.TabIndex = 0;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = true;
            // 
            // txtDocEmpleado
            // 
            this.txtDocEmpleado.Location = new System.Drawing.Point(330, 101);
            this.txtDocEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocEmpleado.Name = "txtDocEmpleado";
            this.txtDocEmpleado.Size = new System.Drawing.Size(145, 22);
            this.txtDocEmpleado.TabIndex = 12;
            this.txtDocEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocEmpleado_KeyPress);
            // 
            // lblNumDocumento
            // 
            this.lblNumDocumento.AutoSize = true;
            this.lblNumDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDocumento.Location = new System.Drawing.Point(268, 106);
            this.lblNumDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumDocumento.Name = "lblNumDocumento";
            this.lblNumDocumento.Size = new System.Drawing.Size(58, 13);
            this.lblNumDocumento.TabIndex = 11;
            this.lblNumDocumento.Text = "Num. Doc.";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(330, 240);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.MaxLength = 9;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 22);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(282, 245);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(75, 343);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 126;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 22);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(330, 149);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(201, 22);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(33, 347);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "E-mail";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(277, 154);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 750);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gboxEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.gboxEmpleados.ResumeLayout(false);
            this.gboxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gboxDatosEmpleado.ResumeLayout(false);
            this.gboxDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gboxEstado.ResumeLayout(false);
            this.gboxEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gboxEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gboxDatosEmpleado;
        private System.Windows.Forms.TextBox txtDocEmpleado;
        private System.Windows.Forms.Label lblNumDocumento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gboxEstado;
        private System.Windows.Forms.RadioButton rdInactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacionE;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cboxCargo;
        private System.Windows.Forms.ComboBox cboxTipoDoc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFehaNacimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chboxVerFotoLista;
    }
}