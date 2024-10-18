using CapaEntidad;
using CapaLogica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmVentas : Form
    {
        int Id_Usuario = 0, Id_sucursal = 0, Id_Caja = 0, Id_SesionCaja = 0;
        public frmVentas()
        {
            InitializeComponent();
        }
        public frmVentas(int id_usuario,int id_suscursal, int id_caja, int id_sesion_caja)
        {
            InitializeComponent();
            Id_sucursal = id_suscursal;
            Id_Usuario = id_usuario;
            Id_Caja= id_caja;
            Id_SesionCaja = id_sesion_caja;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados(); // grupo de los elemento(heramientas) inabilitadas
            ListarVentas();
            ListarTiposComprobantePago();
            ListarMetodosPago();
            ListarEstadosVenta();
            ListarEstadosFacturaBoleta_SUNAT();
            ListarTiposDocumentos();
            limpiar();
            dgvVentas.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvVentas.Enabled = false;
            ElementosActivos();
            txtDocCliente.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            txtDocCliente.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e) // anular (modifica el estado de la venta)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboxCliente.DataSource != null)
            {
                if(dgvDetalleVenta.Rows.Count < 1)
                {
                    MessageBox.Show("Ingrese detalles de la venta", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProducto.Focus();
                    return;
                }
                try
                {
                    entVenta venta = new entVenta();
                    venta.Id_TipoComprobante = (int)cboxTipoCPago.SelectedValue;
                    venta.Id_Cliente = (int)cboxCliente.SelectedValue;
                    venta.Id_MetodoPago = (int)cboxMetodoPago.SelectedValue;
                    venta.Id_Usuario = Id_Usuario;
                    venta.Id_Caja = Id_Caja;
                    venta.Id_SesionCaja = Id_SesionCaja;
                    venta.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
                    if(txtIGV.Text != string.Empty)
                    {
                        venta.IGV = Convert.ToDecimal(txtIGV.Text);
                    }
                    venta.Total = Convert.ToDecimal(txtTotal.Text);
                    venta.Fecha = DateTime.Now;
                    venta.Notas = rtbNotasVenta.Text;
                    venta.Id_Estado = (int)cboxEstadoVenta.SelectedValue;
                    if(cboxTipoCPago.Text == "BOLETA" || cboxTipoCPago.Text == "FACTURA")
                    {
                        venta.Id_EstadoSUNAT = (int)cboxEstadoBoletaFactura.SelectedValue;
                    }
                    else
                    {
                        venta.Id_EstadoSUNAT = null;
                    }
                    try
                    {
                        int id_vennta =  logVentas.Instancia.AgregarVenta(venta, Id_sucursal);
                        deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                        dgvVentas.Enabled = true;
                        ElementosBloqueados();
                        AgregarDetalle(id_vennta);
                        ListarVentas();
                        limpiar(); // al final por que si no limpia mi lista de detalles
                        MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                        {
                            MessageBox.Show($"El cliente con '{cboxTipoDoc.Text}': '{txtDocCliente.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDocCliente.Focus();
                        }
                        else
                        {
                            MessageBox.Show($"Error en la base de datos: {ex.Message} (Código: {ex.Number})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el Software: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos del cliente", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocCliente.Focus();
            }
        }

        public void AgregarDetalle(int id_venta)
        {
            try
            {
                try
                {
                    foreach (var detalle in listadetalleVentas)
                    {
                        entDetalleVenta detventa = new entDetalleVenta();
                        detventa.Id_Venta = id_venta;
                        detventa.Id_Producto = detalle.Id_Producto;
                        detventa.Cantidad = detalle.Cantidad;
                        detventa.Id_UnidadMedida = detalle.Id_UnidadMedida;
                        if (detalle.Descuento != 0)
                        {
                            detventa.Id_Promocion = detalle.Id_Promocion;
                        }
                        detventa.SubTotalDet = detalle.SubTotalDet;
                        logVentas.Instancia.AgregarDetallesVenta(detventa);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show($"El cliente con '{cboxTipoDoc.Text}': '{txtDocCliente.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocCliente.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Error en la base de datos: {ex.Message} (Código: {ex.Number})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Software: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvVentas.Enabled = true;
            btnRegistrarCliente.Enabled = false;
            ElementosBloqueados();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text != string.Empty)
            {
                BuscarCliente(string.Empty, txtCliente.Text.Trim());
            }
            else
            {
                BuscarCliente(txtDocCliente.Text.Trim(), txtCliente.Text.Trim());
            }
        }

        private void BuscarCliente(string documento, string cliente)
        {
            if (!string.IsNullOrWhiteSpace(documento)|| !string.IsNullOrWhiteSpace(cliente))
            {
                try
                {
                    object resultadoBusqueda = null;
                    if (ValidarDocumento(documento) && documento.Length > 1 || Regex.IsMatch(cliente, @"^[a-zA-Z\sáéíóúÁÉÍÓÚñÑ]+$") && cliente.Length > 1)
                    {
                        resultadoBusqueda = logVentas.Instancia.BuscarCliente(documento, cliente);
                    }
                    else
                    {
                        MessageBox.Show("DNI o cliente inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocCliente.Focus();
                        return;
                    }

                    if (resultadoBusqueda == null || ((IList)resultadoBusqueda).Count == 0)
                    {
                        MessageBox.Show("No se encontró cliente.", "AVISO DEL SISTEMA SYS-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRegistrarCliente.Enabled = true;
                        txtDocCliente.Focus();
                        return;
                    }
                    else
                    {
                        cboxCliente.DataSource = resultadoBusqueda;
                        cboxCliente.DisplayMember = "Cliente";
                        cboxCliente.ValueMember = "Id_Cliente";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el Software: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete documento o nombre para buscar.", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocCliente.Focus();
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if(txtProducto.Text != string.Empty)
            {
                BuscarProducto(txtProducto.Text);
                txtCantidad.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese Código(Id), Nombre o Código de Barras para buscar.", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
            }
        }

        private void BuscarProducto(string input)
        {
            try
            {
                object resultadoBusqueda = null;
                if (Regex.IsMatch(input, @"^[a-zA-Z\sáéíóúÁÉÍÓÚñÑ]+$") && input.Length > 1)
                {
                    resultadoBusqueda = logVentas.Instancia.BuscarProducto_Nombre(input);
                }
                else if (Regex.IsMatch(input, @"^\d{12}$") || Regex.IsMatch(input, @"^\d{13}$"))
                {
                    resultadoBusqueda = logVentas.Instancia.BuscarProducto_CodigoBarras(input);
                }
                else if(Regex.IsMatch(input, @"^\d+$" )&& input.Length > 0 && input.Length < 7)
                {
                    resultadoBusqueda = logVentas.Instancia.BuscarProducto_Id(Convert.ToInt32(input));
                }
                else
                {
                    MessageBox.Show("Código(Id), Nombre o Código de Barras inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProducto.Focus();
                    return;
                }

                if (resultadoBusqueda == null || ((IList)resultadoBusqueda).Count == 0)
                {
                    MessageBox.Show("No se encontró producto.", "AVISO DEL SISTEMA SYS-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProducto.Focus();
                    return;
                }
                else
                {
                    cboxProducto.DataSource = resultadoBusqueda;
                    cboxProducto.DisplayMember = "Nombre";
                    cboxProducto.ValueMember = "Id_Producto";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Software: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        List<entDetalleVenta> listadetalleVentas = new List<entDetalleVenta>();
        private void AgregarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count < 40)
            {
                if (cboxProducto.Text != string.Empty && txtCantidad.Text != string.Empty && txtSubTotalDetalle.Text != string.Empty)
                {
                    entDetalleVenta detalle = new entDetalleVenta();
                    detalle.Id_Producto = (int)cboxProducto.SelectedValue;
                    detalle.Producto = cboxProducto.Text;
                    detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    detalle.Id_UnidadMedida = (int)cboxUnidadMedida.SelectedValue;
                    detalle.UnidadMedida = cboxUnidadMedida.Text;
                    detalle.Precio = Convert.ToDecimal(txtPrecio.Text);
                    if (cboxDescuentoPromocion.Text != string.Empty)
                    {
                        detalle.Id_Promocion = (int)cboxDescuentoPromocion.SelectedValue;
                    }
                    else
                    {
                        detalle.Id_Promocion = null;
                    }
                    detalle.Descuento = cboxDescuentoPromocion.Text != string.Empty ? Convert.ToDouble(cboxDescuentoPromocion.Text) : 0;
                    detalle.SubTotalDet = Convert.ToDecimal(txtSubTotalDetalle.Text);
                    listadetalleVentas.Add(detalle);
                    ListarDetalleVenta(listadetalleVentas);
                    CalcularSubTotal_Total_DetalleVena();
                }
            }
            else
            {
                MessageBox.Show("No se pueden agregar más de 40 productos", "AVISO DEL SISTEMA SYS-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        decimal subtotal = 0;
        public void CalcularSubTotal_Total_DetalleVena()
        {
            subtotal = 0;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                if (row.Cells["SubTotalDet"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["SubTotalDet"].Value);
                }
            }
            if(cboxTipoCPago.Text == "BOLETA" || cboxTipoCPago.Text == "FACTURA")
            {
                txtSubTotal.Text = subtotal.ToString();
                txtIGV.Text = ((subtotal * 18) / 100).ToString();
                txtTotal.Text = (subtotal + ((subtotal * 18) / 100)).ToString();
            }
            else
            {
                txtSubTotal.Text = subtotal.ToString();
                txtIGV.Clear();
                txtTotal.Text = subtotal.ToString();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularSubtotal_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text == string.Empty || txtPrecio.Text == string.Empty)
            {
                txtCantidad.Focus();
                return;
            }
            decimal descuento = 0, cantidad = 0, precio = 0, subtotal = 0;
            cantidad = Convert.ToDecimal(txtCantidad.Text);
            precio = Convert.ToDecimal(txtPrecio.Text);
            subtotal = (cantidad * precio);
            if (cboxDescuentoPromocion.Text != string.Empty)
            {
                descuento = Convert.ToDecimal(cboxDescuentoPromocion.Text);
                txtSubTotalDetalle.Text = (subtotal - ((subtotal * descuento)/ 100)).ToString();
            }
            else
            {
                txtSubTotalDetalle.Text = subtotal.ToString();
            }
            
        }

        public void ListarVentas()
        {
            dgvVentas.DataSource = logVentas.Instancia.ListarVentas();
            dgvVentas.Columns["Id_Venta"].Width = 70;
            dgvVentas.Columns["Id_TipoComprobante"].Width = 70;
            dgvVentas.Columns["TipoComprobante"].Width = 70;
            dgvVentas.Columns["Serie"].Width = 140;
            dgvVentas.Columns["Correlativo"].Width = 70;
            dgvVentas.Columns["Id_Cliente"].Width = 140;
            dgvVentas.Columns["Id_TipoDoc"].Width = 70;
            dgvVentas.Columns["TipoDoc"].Width = 140;
            dgvVentas.Columns["Documento"].Width = 70;
            dgvVentas.Columns["Cliente"].Width = 140;
            dgvVentas.Columns["Id_MetodoPago"].Width = 70;
            dgvVentas.Columns["MedotoPago"].Width = 140;
            dgvVentas.Columns["Id_Usuario"].Width = 70;
            dgvVentas.Columns["Usuario"].Width = 140;
            dgvVentas.Columns["Id_Caja"].Width = 70;
            dgvVentas.Columns["Caja"].Width = 140;
            dgvVentas.Columns["Id_SesionCaja"].Width = 70;
            dgvVentas.Columns["SubTotal"].Width = 140;
            dgvVentas.Columns["IGV"].Width = 70;
            dgvVentas.Columns["Total"].Width = 140;
            dgvVentas.Columns["Fecha"].Width = 70;
            dgvVentas.Columns["Notas"].Width = 140;
            dgvVentas.Columns["Id_Estado"].Width = 140;
            dgvVentas.Columns["Estado"].Width = 140;
            dgvVentas.Columns["Id_EstadoSUNAT"].Width = 140;
        }

        public void ListarDetalleVenta(List<entDetalleVenta> DetalleVenta)
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = DetalleVenta;
            dgvDetalleVenta.Columns["Id_DetVenta"].Visible = false;
            dgvDetalleVenta.Columns["Id_Venta"].Visible = false;
            dgvDetalleVenta.Columns["Id_Producto"].Visible = false;
            dgvDetalleVenta.Columns["Producto"].Width = 210;
            dgvDetalleVenta.Columns["Cantidad"].Width = 100;
            dgvDetalleVenta.Columns["Id_UnidadMedida"].Visible = false;
            dgvDetalleVenta.Columns["UnidadMedida"].Width = 100;
            dgvDetalleVenta.Columns["Precio"].Width = 100;
            dgvDetalleVenta.Columns["Id_Promocion"].Visible = false;
            dgvDetalleVenta.Columns["Descuento"].Width = 100;
            dgvDetalleVenta.Columns["SubTotalDet"].Width = 100;
        }

        public void ListarTiposComprobantePago()
        {
            cboxTipoCPago.DataSource = logNumCompPago.Instancia.ListarSeriesComprobantePago_Numeracion(Id_sucursal);
            cboxTipoCPago.DisplayMember = "ComprobantePago";
            cboxTipoCPago.ValueMember = "Id_ComprobantePago";
        }

        public void ListarMetodosPago()
        {
            cboxMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetododosPago();
            cboxMetodoPago.DisplayMember = "Metodo_Pago";
            cboxMetodoPago.ValueMember = "Id_MetodoPago";
        }

        public void ListarEstadosVenta()
        {
            cboxEstadoVenta.DataSource = logEstadoVenta.Instancia.ListarEstadosVenta();
            cboxEstadoVenta.DisplayMember = "Estado_Venta";
            cboxEstadoVenta.ValueMember = "Id_EstadoVenta";
        }

        public void ListarEstadosFacturaBoleta_SUNAT()
        {
            cboxEstadoBoletaFactura.DataSource = logVentas.Instancia.ListarEstadosSUNAT();
            cboxEstadoBoletaFactura.DisplayMember = "EstadoSUNAT";
            cboxEstadoBoletaFactura.ValueMember = "Id_EstadoSUNAT";
        }

        public void ListarTiposDocumentos()
        {
            cboxTipoDoc.DataSource = logTipoDoc.Instancia.ListarTiposDocumento_Todo();
            cboxTipoDoc.DisplayMember = "Documento";
            cboxTipoDoc.ValueMember = "Id_TipoDoc";
        }

        public void ListarUnidadesMedidaXProducto()
        {
            cboxUnidadMedida.DataSource = logRoles.Instancia.ListarRoles();
            cboxUnidadMedida.DisplayMember = "Rol"; // nombre del cargo
            cboxUnidadMedida.ValueMember = "Id_Rol";
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
            cboxCliente.DataSource = null;
        }

        public void limpiarDetalle()
        {
            txtProducto.Clear();
            cboxProducto.SelectedValue = 1;
            txtCantidad.Clear();
            cboxUnidadMedida.SelectedValue = 1;
            txtPrecio.Clear();
            cboxDescuentoPromocion.SelectedValue = 1;
            txtSubTotalDetalle.Clear();
            dgvDetalleVenta.DataSource = null;
            cboxProducto.DataSource = null;
            listadetalleVentas.Clear();
        }

        public void ElementosBloqueados()
        {
            cboxTipoCPago.Enabled = false;
            cboxMetodoPago.Enabled = false;
            //cboxEstadoVenta.Enabled = false;
            cboxTipoDoc.Enabled = false;
            txtDocCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            txtCliente.Enabled = false;
            cboxCliente.Enabled = false;
            //btnRegistrarCliente.Enabled = false;
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
            btnCalcularSubtotal.Enabled = false;
            dgvDetalleVenta.Enabled = false;
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
            //cboxEstadoVenta.Enabled = true;
            cboxTipoDoc.Enabled = true;
            txtDocCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            txtCliente.Enabled = true;
            cboxCliente.Enabled = true;
            //btnRegistrarCliente.Enabled = true;
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
            btnCalcularSubtotal.Enabled = true;
            dgvDetalleVenta.Enabled = true;
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
            txtId.Text = dgvVentas.CurrentRow.Cells["Id_Venta"].Value.ToString();
            cboxTipoCPago.SelectedValue = dgvVentas.CurrentRow.Cells["Id_TipoComprobante"].Value;
            txtCorrelativo.Text = dgvVentas.CurrentRow.Cells["Correlativo"].Value.ToString();
            cboxTipoDoc.SelectedValue = dgvVentas.CurrentRow.Cells["Id_TipoDoc"].Value;
            BuscarCliente((dgvVentas.CurrentRow.Cells["Documento"].Value).ToString(), string.Empty);
            cboxMetodoPago.SelectedValue = dgvVentas.CurrentRow.Cells["Id_TipoDoc"].Value;
            cboxTipoDoc.SelectedValue = dgvVentas.CurrentRow.Cells["Id_MetodoPago"].Value;
            txtSubTotal.Text = dgvVentas.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtIGV.Text = dgvVentas.CurrentRow.Cells["IGV"].Value.ToString();
            txtTotal.Text = dgvVentas.CurrentRow.Cells["Total"].Value.ToString();
            rtbNotasVenta.Text = dgvVentas.CurrentRow.Cells["Notas"].Value.ToString();
            cboxEstadoVenta.SelectedValue = dgvVentas.CurrentRow.Cells["Id_Estado"].Value;
            if(dgvVentas.CurrentRow.Cells["Id_EstadoSUNAT"].Value != null)
            {
                cboxEstadoBoletaFactura.SelectedValue = dgvVentas.CurrentRow.Cells["Id_EstadoSUNAT"].Value;
                cboxEstadoBoletaFactura.Visible = true;
            }
            else
            {
                cboxEstadoBoletaFactura.Visible = false;
            }
            ListarDetalleVenta(logVentas.Instancia.ListarDetallesVenta((int)dgvVentas.CurrentRow.Cells["Id_Venta"].Value));
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                if (row.Cells["Id_Promocion"].Value != null)
                {
                    row.Cells["Descuento"].Value =  logVentas.Instancia.BuscarDescuento_DetalleVenta_Vendidos(Convert.ToInt32(row.Cells["Id_Promocion"].Value));
                }
            }
        }

        private void dgvDetalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboxTipoCPago_SelectedValueChanged(object sender, EventArgs e)
        {
            entNumCompPago numCompPago_serie = (entNumCompPago)cboxTipoCPago.SelectedItem;
            if (numCompPago_serie != null)
            {
                txtSerie.Text = numCompPago_serie.Serie.ToString();
            }
            else
            {
                txtSerie.Text = string.Empty;
            }
        }

        private void cboxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            entProducto UM_Prod = (entProducto)cboxProducto.SelectedItem;
            if (UM_Prod != null)
            {
                cboxUnidadMedida.DataSource = logVentas.Instancia.BuscarUnidadesMP_Producto(UM_Prod.Id_Producto);
                cboxUnidadMedida.DisplayMember = "Unidad_Medida";
                cboxUnidadMedida.ValueMember = "Id_UnidadMedida";
                object resultado = null;
                resultado = logVentas.Instancia.BuscarPromocionProducto(UM_Prod.Id_Producto);

                if(resultado != null || ((IList)resultado).Count != 0)
                {
                    cboxDescuentoPromocion.DataSource = resultado;
                    cboxDescuentoPromocion.DisplayMember = "Descuento";
                    cboxDescuentoPromocion.ValueMember = "Id_Promocion";
                }
            }
            txtCantidad.Clear();
            txtCantidad.Focus();
        }

        private void cboxUnidadMedida_SelectedValueChanged(object sender, EventArgs e)
        {
            entUnidMxProducto UM_Prod = (entUnidMxProducto)cboxUnidadMedida.SelectedItem;
            if (UM_Prod != null)
            {
                txtPrecio.Text = UM_Prod.Precio_Equivalente.ToString();
            }
            else
            {
                txtPrecio.Text = string.Empty;
            }
        }



        private bool ValidarDocumento(string documento)
        {
            // Validar si es DNI: 8 dígitos numéricos
            if (Regex.IsMatch(documento, @"^\d{8}$"))
            {
                return true;
            }

            // Validar si es RUC: 11 dígitos numéricos
            if (Regex.IsMatch(documento, @"^\d{11}$"))
            {
                return true;
            }

            // Validar si es Carnet de Extranjería: 9 dígitos numéricos
            if (Regex.IsMatch(documento, @"^\d{9}$"))
            {
                return true;
            }

            // Validar si es Pasaporte: 2 letras y 6 dígitos
            if (Regex.IsMatch(documento, @"^[A-Za-z]{2}\d{6}$")) // regex
            {
                return true;
            }

            // Si no cumple con ninguno, se considera inválido
            return false;
        }


    }
}
