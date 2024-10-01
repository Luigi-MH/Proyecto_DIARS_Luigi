using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmPanelPrincipal : Form
    {
        public frmPanelPrincipal()
        {
            InitializeComponent();
        }
        private void frmPanelPrincipal_Load(object sender, EventArgs e)
        {
            //dgvUsuarios.EnableHeadersVisualStyles = false;
            //dgvUsuarios.DataSource = logUsuario.Instancia.ListarUsuarios();
            //dgvUsuarios.Columns["IdUsuario"].Width = 120;
            //dgvUsuarios.Columns["NombreUsuario"].Width = 75;
            //dgvUsuarios.Columns["Contraseña"].Width = 120;
            //dgvUsuarios.Columns["IdRol"].Width = 120;
            //dgvUsuarios.Columns["Rol"].Width = 100;
            //dgvUsuarios.Columns["IdEmpleado"].Width = 80;
            //dgvUsuarios.Columns["ApellidoEmpleado"].Width = 115;
            //dgvUsuarios.Columns["NombreEmpleado"].Width = 85;
            //dgvUsuarios.Columns["Estado"].Width = 85;
            //DataGridViewTextBoxColumn nombreCompletoCol = new DataGridViewTextBoxColumn();
            //nombreCompletoCol.Name = "NombreCompleto";
            //nombreCompletoCol.HeaderText = "Nombre Completo";
            //dgvUsuarios.Columns.Add(nombreCompletoCol);

            //// Recorrer todas las filas y concatenar las columnas
            //foreach (DataGridViewRow row in dgvUsuarios.Rows)
            //{
            //    string apellido = row.Cells["ApellidoEmpleado"].Value.ToString();
            //    string nombre = row.Cells["NombreEmpleado"].Value.ToString();
            //    row.Cells["NombreCompleto"].Value = apellido + " " + nombre;
            //}

            //// Ajustar el ancho de la nueva columna
            //dgvUsuarios.Columns["NombreCompleto"].Width = 200;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {

        }

        private void btnMetodosPago_Click(object sender, EventArgs e)
        {
            frmMetodosPago frmMetodosPago = new frmMetodosPago();
            abrirFrm(frmMetodosPago);
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            abrirFrm(frmCategorias);
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {

        }

        private void btnUnidadesMedidaProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnIndicacionesContraindicaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnRecetasMedicas_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnCajas_Click(object sender, EventArgs e)
        {

        }

        private void btnLiquidacionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnVentasSUNAT_Click(object sender, EventArgs e)
        {

        }

        private void btnRepVentasSUNAT_Click(object sender, EventArgs e)
        {

        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            frmSucursales frmSucursales = new frmSucursales();
            abrirFrm(frmSucursales);
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            frmAlmacenes frmAlmacenes = new frmAlmacenes();
            abrirFrm(frmAlmacenes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            frmCargos frmCargos = new frmCargos();
            abrirFrm(frmCargos);
        }

        private void btnCambiosRoles_Click(object sender, EventArgs e)
        {

        }

        private void btnLogsActividadUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnReportesSistema_Click(object sender, EventArgs e)
        {

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoles frmRoles = new frmRoles();
            abrirFrm(frmRoles);
        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            frmTipoDoc frmTipoDoc = new frmTipoDoc();
            abrirFrm(frmTipoDoc);
        }

        private void btnTipoComprobantePago_Click(object sender, EventArgs e)
        {
            frmTipoCPago frmTipoCPago = new frmTipoCPago();
            abrirFrm(frmTipoCPago);
        }

        private void btnEstadosProducto_Click(object sender, EventArgs e)
        {
            frmEstadosProducto frmEstProducto = new frmEstadosProducto();
            abrirFrm(frmEstProducto);
        }

        private void btnEstadosVenta_Click(object sender, EventArgs e)
        {
            frmEstadosVenta frmEstVenta = new frmEstadosVenta();
            abrirFrm(frmEstVenta);
        }

        private void btnUnidadesMedida_Click(object sender, EventArgs e)
        {
            frmUnidadesMedida frmUnidadesMed = new frmUnidadesMedida();
            abrirFrm(frmUnidadesMed);
        }

        private void btnTipoIndicacion_Click(object sender, EventArgs e)
        {
            frmTipoIndicacion frmTipIndicacion = new frmTipoIndicacion();
            abrirFrm(frmTipIndicacion);
        }

        private void btnSeriesSucursalFB_Click(object sender, EventArgs e)
        {
            frmNumCompPagoSerie frmNumCompPagoSerie = new frmNumCompPagoSerie();
            abrirFrm(frmNumCompPagoSerie);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }
        Form frmActual;
        public void abrirFrm(Form frm)
        {
            if (frmActual != null)
            {
                frmActual.Close();
            }
            frmActual = frm;
            frm.TopLevel = false;
            panelFormAbierto.Controls.Add(frm);
            panelFormAbierto.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
