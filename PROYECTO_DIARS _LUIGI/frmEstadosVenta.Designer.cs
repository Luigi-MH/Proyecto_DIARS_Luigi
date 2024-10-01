namespace PROYECTO_DIARS__LUIGI
{
    partial class frmEstadosVenta
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
            this.gboxEstadosVenta = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxEstadosVenta2 = new System.Windows.Forms.GroupBox();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEstadoVenta = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstadoVenta = new System.Windows.Forms.Label();
            this.dgvEstadosVenta = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gboxEstadosVenta.SuspendLayout();
            this.gboxEstadosVenta2.SuspendLayout();
            this.gboxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxEstadosVenta
            // 
            this.gboxEstadosVenta.Controls.Add(this.btnSalir);
            this.gboxEstadosVenta.Controls.Add(this.gboxEstadosVenta2);
            this.gboxEstadosVenta.Location = new System.Drawing.Point(12, 12);
            this.gboxEstadosVenta.Name = "gboxEstadosVenta";
            this.gboxEstadosVenta.Size = new System.Drawing.Size(1676, 726);
            this.gboxEstadosVenta.TabIndex = 15;
            this.gboxEstadosVenta.TabStop = false;
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
            // gboxEstadosVenta2
            // 
            this.gboxEstadosVenta2.Controls.Add(this.gboxDatos);
            this.gboxEstadosVenta2.Controls.Add(this.dgvEstadosVenta);
            this.gboxEstadosVenta2.Controls.Add(this.btnEliminar);
            this.gboxEstadosVenta2.Controls.Add(this.btnEditar);
            this.gboxEstadosVenta2.Controls.Add(this.btnNuevo);
            this.gboxEstadosVenta2.Location = new System.Drawing.Point(22, 19);
            this.gboxEstadosVenta2.Name = "gboxEstadosVenta2";
            this.gboxEstadosVenta2.Size = new System.Drawing.Size(788, 512);
            this.gboxEstadosVenta2.TabIndex = 43;
            this.gboxEstadosVenta2.TabStop = false;
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.txtId);
            this.gboxDatos.Controls.Add(this.lblId);
            this.gboxDatos.Controls.Add(this.btnModificar);
            this.gboxDatos.Controls.Add(this.btnAgregar);
            this.gboxDatos.Controls.Add(this.txtEstadoVenta);
            this.gboxDatos.Controls.Add(this.btnCancelar);
            this.gboxDatos.Controls.Add(this.lblEstadoVenta);
            this.gboxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatos.Location = new System.Drawing.Point(345, 46);
            this.gboxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Name = "gboxDatos";
            this.gboxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gboxDatos.Size = new System.Drawing.Size(377, 195);
            this.gboxDatos.TabIndex = 40;
            this.gboxDatos.TabStop = false;
            this.gboxDatos.Text = "Datos";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(59, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 22);
            this.txtId.TabIndex = 26;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(33, 57);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "N°";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(143, 110);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 48);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(39, 110);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 48);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtEstadoVenta
            // 
            this.txtEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoVenta.Location = new System.Drawing.Point(188, 54);
            this.txtEstadoVenta.Name = "txtEstadoVenta";
            this.txtEstadoVenta.Size = new System.Drawing.Size(159, 22);
            this.txtEstadoVenta.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(247, 110);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 48);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblEstadoVenta
            // 
            this.lblEstadoVenta.AutoSize = true;
            this.lblEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVenta.Location = new System.Drawing.Point(133, 57);
            this.lblEstadoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoVenta.Name = "lblEstadoVenta";
            this.lblEstadoVenta.Size = new System.Drawing.Size(50, 16);
            this.lblEstadoVenta.TabIndex = 1;
            this.lblEstadoVenta.Text = "Estado";
            // 
            // dgvEstadosVenta
            // 
            this.dgvEstadosVenta.AllowUserToAddRows = false;
            this.dgvEstadosVenta.AllowUserToDeleteRows = false;
            this.dgvEstadosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadosVenta.Location = new System.Drawing.Point(22, 30);
            this.dgvEstadosVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstadosVenta.Name = "dgvEstadosVenta";
            this.dgvEstadosVenta.ReadOnly = true;
            this.dgvEstadosVenta.RowHeadersWidth = 51;
            this.dgvEstadosVenta.RowTemplate.Height = 24;
            this.dgvEstadosVenta.Size = new System.Drawing.Size(296, 428);
            this.dgvEstadosVenta.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(592, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 35);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(487, 269);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(383, 269);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 35);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmEstadosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 750);
            this.Controls.Add(this.gboxEstadosVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadosVenta";
            this.Text = "frmEstadosVenta";
            this.Load += new System.EventHandler(this.frmEstadosVenta_Load);
            this.gboxEstadosVenta.ResumeLayout(false);
            this.gboxEstadosVenta2.ResumeLayout(false);
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxEstadosVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gboxEstadosVenta2;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEstadoVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstadoVenta;
        private System.Windows.Forms.DataGridView dgvEstadosVenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
    }
}