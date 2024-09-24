namespace PROYECTO_DIARS__LUIGI
{
    partial class frmPanelPrincipal
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlPanel = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelFormAbierto = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnRepVentas = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tabControlPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tabControlPanel, 0, 0);
            this.tlpPrincipal.Controls.Add(this.panelFormAbierto, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1720, 880);
            this.tlpPrincipal.TabIndex = 8;
            // 
            // tabControlPanel
            // 
            this.tabControlPanel.Controls.Add(this.tabPage2);
            this.tabControlPanel.Controls.Add(this.tabPage1);
            this.tabControlPanel.Controls.Add(this.tabPage3);
            this.tabControlPanel.Controls.Add(this.tabPage4);
            this.tabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel.Location = new System.Drawing.Point(3, 3);
            this.tabControlPanel.Name = "tabControlPanel";
            this.tabControlPanel.SelectedIndex = 0;
            this.tabControlPanel.Size = new System.Drawing.Size(1714, 114);
            this.tabControlPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPerfil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1706, 88);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(6, 6);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 75);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1706, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1706, 88);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doc SUNAT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelFormAbierto
            // 
            this.panelFormAbierto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormAbierto.Location = new System.Drawing.Point(3, 123);
            this.panelFormAbierto.Name = "panelFormAbierto";
            this.panelFormAbierto.Size = new System.Drawing.Size(1714, 754);
            this.panelFormAbierto.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1694, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.Location = new System.Drawing.Point(1668, 1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.TabIndex = 10;
            this.btnMaximizar.Text = "+";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizar.Location = new System.Drawing.Point(1642, 1);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.TabIndex = 11;
            this.Minimizar.Text = "-";
            this.Minimizar.UseVisualStyleBackColor = true;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRepVentas);
            this.tabPage4.Controls.Add(this.btnVentas);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1706, 88);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ventas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(6, 6);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 75);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnRepVentas
            // 
            this.btnRepVentas.Location = new System.Drawing.Point(87, 6);
            this.btnRepVentas.Name = "btnRepVentas";
            this.btnRepVentas.Size = new System.Drawing.Size(75, 75);
            this.btnRepVentas.TabIndex = 2;
            this.btnRepVentas.Text = "Rep Ventas";
            this.btnRepVentas.UseVisualStyleBackColor = true;
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 880);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPanelPrincipal";
            this.tlpPrincipal.ResumeLayout(false);
            this.tabControlPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TabControl tabControlPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panelFormAbierto;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRepVentas;
        private System.Windows.Forms.Button btnVentas;
    }
}