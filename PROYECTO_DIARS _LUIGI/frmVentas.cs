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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void AgregarDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {

        }

        public void ListarUsuarios()
        {
            //dgvUsuarios.DataSource = logUsuario.Instancia.ListarUsuarios();
            //dgvUsuarios.Columns["Id_Usuario"].Width = 70;
            //dgvUsuarios.Columns["NombreUsuario"].Width = 140;
            //dgvUsuarios.Columns["Contraseña"].Visible = false;
            //dgvUsuarios.Columns["Id_Rol"].Visible = false;
            //dgvUsuarios.Columns["Rol"].Width = 80;
            //dgvUsuarios.Columns["Id_Empleado"].Visible = false;
            //dgvUsuarios.Columns["DocumentoEmpleado"].Visible = false;
            //dgvUsuarios.Columns["NombreEmpleado"].Width = 250;
            //dgvUsuarios.Columns["FechaCreacion"].Width = 120;
            //dgvUsuarios.Columns["Estado"].Width = 80;
        }

        public void ListarRoles()
        {
            //cboxRol.DataSource = logRoles.Instancia.ListarRoles();
            //cboxRol.DisplayMember = "Rol"; // nombre del cargo
            //cboxRol.ValueMember = "Id_Rol";
        }

        public void limpiar()
        {
            txtId.Clear();
            cboxTipoCPago.SelectedValue = 1;
            cboxMetodoPago.SelectedValue = 1;
            cboxEstadoVenta.SelectedValue = 1;
            cboxTipoDoc.SelectedValue = 1;
            txtDocCliente.Clear();
            txtCliente.Clear();
            limpiarDetalle();
            rtbNotasVenta.Clear();
            txtSubTotal.Clear();
            txtIGV.Clear();
            txtTotal.Clear();
        }

        public void limpiarDetalle()
        {
            txtProducto.Clear();
            cboxProducto.SelectedValue = 1;
            txtCantidad.Clear();
            cboxUnidadMedida.SelectedValue = 1;
            txtPrecio.Clear();
            txtPromocion.Clear();
            txtSubTotalDetalle.Clear();
        }

        public void ElementosBloqueados()
        {
            cboxTipoCPago.Enabled = false;
            cboxMetodoPago.Enabled = false;
            cboxEstadoVenta.Enabled = false;
            cboxTipoDoc.Enabled = false;
            txtDocCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            txtCliente.Enabled = false;
            btnRegistrarCliente.Enabled = false;
            // detalle
            txtProducto.Enabled = false;
            btnBuscarProducto.Enabled = false;
            cboxProducto.Enabled = false;
            txtCantidad.Enabled = false;
            cboxUnidadMedida.Enabled = false;
            //txtPrecio.Enabled = false;
            //txtPromocion.Enabled = false;
            //txtSubTotalDetalle.Enabled = false;
            btnAgregarDetalle.Enabled = false;
            btnEliminarDetalle.Enabled = false;
            // 
            rtbNotasVenta.Enabled = false;
            //txtSubTotal.Enabled = false;
            //txtIGV.Enabled = false;
            //txtTotal.Enabled = false;
        }
        public void ElementosActivos()
        {
            cboxTipoCPago.Enabled = true;
            cboxMetodoPago.Enabled = true;
            cboxEstadoVenta.Enabled = true;
            cboxTipoDoc.Enabled = true;
            txtDocCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            txtCliente.Enabled = true;
            btnRegistrarCliente.Enabled = true;
            // detalle
            txtProducto.Enabled = true;
            btnBuscarProducto.Enabled = true;
            cboxProducto.Enabled = true;
            txtCantidad.Enabled = true;
            cboxUnidadMedida.Enabled = true;
            //txtPrecio.Enabled = true;
            //txtPromocion.Enabled = true;
            //txtSubTotalDetalle.Enabled = true;
            btnAgregarDetalle.Enabled = true;
            btnEliminarDetalle.Enabled = true;
            // 
            rtbNotasVenta.Enabled = true;
            //txtSubTotal.Enabled = true;
            //txtIGV.Enabled = true;
            //txtTotal.Enabled = true;
        }

        public void habilitarBtn(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
        }

        public void deshabilitarBtn(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
