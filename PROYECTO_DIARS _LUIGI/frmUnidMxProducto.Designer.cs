namespace PROYECTO_DIARS__LUIGI
{
    partial class frmUnidMxProducto
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
            this.gboxUMP = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxUMP2 = new System.Windows.Forms.GroupBox();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.btnCalcularPrecioEquivalente = new System.Windows.Forms.Button();
            this.lblUnidadMedidaBase = new System.Windows.Forms.Label();
            this.txtUnidadMedidaBase = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioEquivalente = new System.Windows.Forms.TextBox();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cboxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidadEquivalente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidadEquivalente = new System.Windows.Forms.Label();
            this.dgvUnidadesMedidaProducto = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gboxUMP.SuspendLayout();
            this.gboxUMP2.SuspendLayout();
            this.gboxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesMedidaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxUMP
            // 
            this.gboxUMP.Controls.Add(this.btnSalir);
            this.gboxUMP.Controls.Add(this.gboxUMP2);
            this.gboxUMP.Location = new System.Drawing.Point(12, 12);
            this.gboxUMP.Name = "gboxUMP";
            this.gboxUMP.Size = new System.Drawing.Size(1676, 726);
            this.gboxUMP.TabIndex = 15;
            this.gboxUMP.TabStop = false;
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
            // gboxUMP2
            // 
            this.gboxUMP2.Controls.Add(this.gboxDatos);
            this.gboxUMP2.Controls.Add(this.dgvUnidadesMedidaProducto);
            this.gboxUMP2.Controls.Add(this.btnEliminar);
            this.gboxUMP2.Controls.Add(this.btnEditar);
            this.gboxUMP2.Controls.Add(this.btnNuevo);
            this.gboxUMP2.Location = new System.Drawing.Point(22, 19);
            this.gboxUMP2.Name = "gboxUMP2";
            this.gboxUMP2.Size = new System.Drawing.Size(1463, 614);
            this.gboxUMP2.TabIndex = 43;
            this.gboxUMP2.TabStop = false;
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.btnCalcularPrecioEquivalente);
            this.gboxDatos.Controls.Add(this.lblUnidadMedidaBase);
            this.gboxDatos.Controls.Add(this.txtUnidadMedidaBase);
            this.gboxDatos.Controls.Add(this.lblPrecio);
            this.gboxDatos.Controls.Add(this.txtPrecio);
            this.gboxDatos.Controls.Add(this.btnBuscar);
            this.gboxDatos.Controls.Add(this.txtProducto);
            this.gboxDatos.Controls.Add(this.txtPrecioEquivalente);
            this.gboxDatos.Controls.Add(this.lblCorrelativo);
            this.gboxDatos.Controls.Add(this.lblUnidadMedida);
            this.gboxDatos.Controls.Add(this.cboxUnidadMedida);
            this.gboxDatos.Controls.Add(this.lblProducto);
            this.gboxDatos.Controls.Add(this.cboxProducto);
            this.gboxDatos.Controls.Add(this.txtId);
            this.gboxDatos.Controls.Add(this.lblId);
            this.gboxDatos.Controls.Add(this.btnModificar);
            this.gboxDatos.Controls.Add(this.btnAgregar);
            this.gboxDatos.Controls.Add(this.txtCantidadEquivalente);
            this.gboxDatos.Controls.Add(this.btnCancelar);
            this.gboxDatos.Controls.Add(this.lblCantidadEquivalente);
            this.gboxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatos.Location = new System.Drawing.Point(928, 30);
            this.gboxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Size = new System.Drawing.Size(484, 428);
            this.gboxDatos.TabIndex = 40;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos";
            // 
            // btnCalcularPrecioEquivalente
            // 
            this.btnCalcularPrecioEquivalente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecioEquivalente.Location = new System.Drawing.Point(316, 236);
            this.btnCalcularPrecioEquivalente.Name = "btnCalcularPrecioEquivalente";
            this.btnCalcularPrecioEquivalente.Size = new System.Drawing.Size(60, 23);
            this.btnCalcularPrecioEquivalente.TabIndex = 78;
            this.btnCalcularPrecioEquivalente.Text = "Calcular";
            this.btnCalcularPrecioEquivalente.UseVisualStyleBackColor = true;
            this.btnCalcularPrecioEquivalente.Click += new System.EventHandler(this.btnCalcularPrecioEquivalente_Click);
            // 
            // lblUnidadMedidaBase
            // 
            this.lblUnidadMedidaBase.AutoSize = true;
            this.lblUnidadMedidaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedidaBase.Location = new System.Drawing.Point(4, 133);
            this.lblUnidadMedidaBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnidadMedidaBase.Name = "lblUnidadMedidaBase";
            this.lblUnidadMedidaBase.Size = new System.Drawing.Size(123, 15);
            this.lblUnidadMedidaBase.TabIndex = 77;
            this.lblUnidadMedidaBase.Text = "Unidad Medida Base";
            // 
            // txtUnidadMedidaBase
            // 
            this.txtUnidadMedidaBase.Enabled = false;
            this.txtUnidadMedidaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadMedidaBase.Location = new System.Drawing.Point(132, 130);
            this.txtUnidadMedidaBase.Name = "txtUnidadMedidaBase";
            this.txtUnidadMedidaBase.Size = new System.Drawing.Size(178, 22);
            this.txtUnidadMedidaBase.TabIndex = 76;
            this.txtUnidadMedidaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(85, 161);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 75;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(132, 158);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(102, 22);
            this.txtPrecio.TabIndex = 74;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(316, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(131, 64);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(179, 22);
            this.txtProducto.TabIndex = 34;
            // 
            // txtPrecioEquivalente
            // 
            this.txtPrecioEquivalente.Enabled = false;
            this.txtPrecioEquivalente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioEquivalente.Location = new System.Drawing.Point(132, 277);
            this.txtPrecioEquivalente.Name = "txtPrecioEquivalente";
            this.txtPrecioEquivalente.Size = new System.Drawing.Size(179, 22);
            this.txtPrecioEquivalente.TabIndex = 32;
            this.txtPrecioEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AutoSize = true;
            this.lblCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.Location = new System.Drawing.Point(18, 280);
            this.lblCorrelativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(109, 15);
            this.lblCorrelativo.TabIndex = 31;
            this.lblCorrelativo.Text = "Precio Equivalente";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(35, 198);
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(92, 15);
            this.lblUnidadMedida.TabIndex = 30;
            this.lblUnidadMedida.Text = "Unidad Medida";
            // 
            // cboxUnidadMedida
            // 
            this.cboxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUnidadMedida.FormattingEnabled = true;
            this.cboxUnidadMedida.Location = new System.Drawing.Point(131, 195);
            this.cboxUnidadMedida.Name = "cboxUnidadMedida";
            this.cboxUnidadMedida.Size = new System.Drawing.Size(179, 24);
            this.cboxUnidadMedida.TabIndex = 29;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(70, 67);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 28;
            this.lblProducto.Text = "Producto";
            // 
            // cboxProducto
            // 
            this.cboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Location = new System.Drawing.Point(131, 92);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(245, 24);
            this.cboxProducto.TabIndex = 27;
            this.cboxProducto.SelectedValueChanged += new System.EventHandler(this.cboxProducto_SelectedValueChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(401, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 22);
            this.txtId.TabIndex = 26;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(375, 38);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "N°";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(187, 321);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 48);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(83, 321);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 48);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidadEquivalente
            // 
            this.txtCantidadEquivalente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEquivalente.Location = new System.Drawing.Point(132, 236);
            this.txtCantidadEquivalente.Name = "txtCantidadEquivalente";
            this.txtCantidadEquivalente.Size = new System.Drawing.Size(179, 22);
            this.txtCantidadEquivalente.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(291, 321);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 48);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidadEquivalente
            // 
            this.lblCantidadEquivalente.AutoSize = true;
            this.lblCantidadEquivalente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEquivalente.Location = new System.Drawing.Point(25, 239);
            this.lblCantidadEquivalente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadEquivalente.Name = "lblCantidadEquivalente";
            this.lblCantidadEquivalente.Size = new System.Drawing.Size(102, 15);
            this.lblCantidadEquivalente.TabIndex = 1;
            this.lblCantidadEquivalente.Text = "Cant. Equivalente";
            // 
            // dgvUnidadesMedidaProducto
            // 
            this.dgvUnidadesMedidaProducto.AllowUserToAddRows = false;
            this.dgvUnidadesMedidaProducto.AllowUserToDeleteRows = false;
            this.dgvUnidadesMedidaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadesMedidaProducto.Location = new System.Drawing.Point(22, 30);
            this.dgvUnidadesMedidaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUnidadesMedidaProducto.Name = "dgvUnidadesMedidaProducto";
            this.dgvUnidadesMedidaProducto.ReadOnly = true;
            this.dgvUnidadesMedidaProducto.RowHeadersWidth = 51;
            this.dgvUnidadesMedidaProducto.RowTemplate.Height = 24;
            this.dgvUnidadesMedidaProducto.Size = new System.Drawing.Size(874, 559);
            this.dgvUnidadesMedidaProducto.TabIndex = 38;
            this.dgvUnidadesMedidaProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadesMedidaProducto_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1225, 493);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 35);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1120, 493);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1016, 493);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 35);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmUnidMxProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 750);
            this.Controls.Add(this.gboxUMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnidMxProducto";
            this.Text = "frmUnidMxProducto";
            this.Load += new System.EventHandler(this.frmUnidMxProducto_Load);
            this.gboxUMP.ResumeLayout(false);
            this.gboxUMP2.ResumeLayout(false);
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesMedidaProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxUMP;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gboxUMP2;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.TextBox txtPrecioEquivalente;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cboxUnidadMedida;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboxProducto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidadEquivalente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidadEquivalente;
        private System.Windows.Forms.DataGridView dgvUnidadesMedidaProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUnidadMedidaBase;
        private System.Windows.Forms.TextBox txtUnidadMedidaBase;
        private System.Windows.Forms.Button btnCalcularPrecioEquivalente;
    }
}