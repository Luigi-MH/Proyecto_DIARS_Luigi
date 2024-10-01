namespace PROYECTO_DIARS__LUIGI
{
    partial class frmMetodosPago
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
            this.gboxMetodosPago = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxMetodosPago2 = new System.Windows.Forms.GroupBox();
            this.gboxDatos = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMetodosPago = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMetodosPago = new System.Windows.Forms.Label();
            this.dgvMetodosPago = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gboxMetodosPago.SuspendLayout();
            this.gboxMetodosPago2.SuspendLayout();
            this.gboxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodosPago)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxMetodosPago
            // 
            this.gboxMetodosPago.Controls.Add(this.btnSalir);
            this.gboxMetodosPago.Controls.Add(this.gboxMetodosPago2);
            this.gboxMetodosPago.Location = new System.Drawing.Point(12, 12);
            this.gboxMetodosPago.Name = "gboxMetodosPago";
            this.gboxMetodosPago.Size = new System.Drawing.Size(1676, 726);
            this.gboxMetodosPago.TabIndex = 14;
            this.gboxMetodosPago.TabStop = false;
            this.gboxMetodosPago.Text = " ";
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
            // gboxMetodosPago2
            // 
            this.gboxMetodosPago2.Controls.Add(this.gboxDatos);
            this.gboxMetodosPago2.Controls.Add(this.dgvMetodosPago);
            this.gboxMetodosPago2.Controls.Add(this.btnEliminar);
            this.gboxMetodosPago2.Controls.Add(this.btnEditar);
            this.gboxMetodosPago2.Controls.Add(this.btnNuevo);
            this.gboxMetodosPago2.Location = new System.Drawing.Point(22, 19);
            this.gboxMetodosPago2.Name = "gboxMetodosPago2";
            this.gboxMetodosPago2.Size = new System.Drawing.Size(788, 512);
            this.gboxMetodosPago2.TabIndex = 43;
            this.gboxMetodosPago2.TabStop = false;
            // 
            // gboxDatos
            // 
            this.gboxDatos.Controls.Add(this.txtId);
            this.gboxDatos.Controls.Add(this.lblId);
            this.gboxDatos.Controls.Add(this.btnModificar);
            this.gboxDatos.Controls.Add(this.btnAgregar);
            this.gboxDatos.Controls.Add(this.txtMetodosPago);
            this.gboxDatos.Controls.Add(this.btnCancelar);
            this.gboxDatos.Controls.Add(this.lblMetodosPago);
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
            this.txtId.Size = new System.Drawing.Size(37, 22);
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
            // txtMetodosPago
            // 
            this.txtMetodosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodosPago.Location = new System.Drawing.Point(208, 54);
            this.txtMetodosPago.Name = "txtMetodosPago";
            this.txtMetodosPago.Size = new System.Drawing.Size(139, 22);
            this.txtMetodosPago.TabIndex = 11;
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
            // lblMetodosPago
            // 
            this.lblMetodosPago.AutoSize = true;
            this.lblMetodosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodosPago.Location = new System.Drawing.Point(114, 57);
            this.lblMetodosPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetodosPago.Name = "lblMetodosPago";
            this.lblMetodosPago.Size = new System.Drawing.Size(89, 16);
            this.lblMetodosPago.TabIndex = 1;
            this.lblMetodosPago.Text = "Medoto Pago";
            // 
            // dgvMetodosPago
            // 
            this.dgvMetodosPago.AllowUserToAddRows = false;
            this.dgvMetodosPago.AllowUserToDeleteRows = false;
            this.dgvMetodosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodosPago.Location = new System.Drawing.Point(22, 30);
            this.dgvMetodosPago.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMetodosPago.Name = "dgvMetodosPago";
            this.dgvMetodosPago.ReadOnly = true;
            this.dgvMetodosPago.RowHeadersWidth = 51;
            this.dgvMetodosPago.RowTemplate.Height = 24;
            this.dgvMetodosPago.Size = new System.Drawing.Size(296, 428);
            this.dgvMetodosPago.TabIndex = 38;
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
            // frmMetodosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 750);
            this.Controls.Add(this.gboxMetodosPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMetodosPago";
            this.Text = "frmMetodosPago";
            this.Load += new System.EventHandler(this.frmMetodosPago_Load);
            this.gboxMetodosPago.ResumeLayout(false);
            this.gboxMetodosPago2.ResumeLayout(false);
            this.gboxDatos.ResumeLayout(false);
            this.gboxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodosPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMetodosPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gboxMetodosPago2;
        private System.Windows.Forms.GroupBox gboxDatos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMetodosPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMetodosPago;
        private System.Windows.Forms.DataGridView dgvMetodosPago;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
    }
}