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
    public partial class frmUnidMxProducto : Form
    {
        public frmUnidMxProducto()
        {
            InitializeComponent();
        }
        int id_UM_Producto = 0;
        private void frmUnidMxProducto_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados();
            ListarUMxP_Todo();
            ListarUnidadesMedida();
            limpiar();
            dgvUnidadesMedidaProducto.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvUnidadesMedidaProducto.Enabled = false;
            ElementosActivos();
            txtProducto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            txtProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Esta seguro de Eliminar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        entUnidMxProducto ump = new entUnidMxProducto();
                        ump.Id_UMxP_id = Convert.ToInt32(txtId.Text);
                        ump.Id_UM_Producto = id_UM_Producto;
                        try
                        {
                            if(logUnidMxProducto.Instancia.EliminarUnidMedXProducto(ump))
                            {
                                MessageBox.Show("Se eliminó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ListarUMxP_Todo();
                                limpiar();
                                ElementosBloqueados();
                                return;
                            }
                            else
                            {
                                MessageBox.Show($"Nose eliminó por que la medida:'{txtUnidadMedidaBase.Text}' es la unidad base del producto:'{cboxProducto.Text}'", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                limpiar();
                                return;
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error en la base de datos: {ex.Message} (Código: {ex.Number})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error.." + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione Unidad de Medida de un Producto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboxProducto.Text != string.Empty && cboxUnidadMedida.Text != string.Empty && txtCantidadEquivalente.Text != string.Empty && txtPrecioEquivalente.Text != string.Empty)
            {
                if (txtUnidadMedidaBase.Text == cboxUnidadMedida.Text)
                {
                    MessageBox.Show($"La unidad de medida:'{cboxUnidadMedida.Text}' ya existe en el producto:'{cboxProducto.Text}'", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPrecioEquivalente.Text == ".") // || Convert.ToDecimal(txtPrecioEquivalente.Text) < 1
                {
                    MessageBox.Show("Precio equivalente inválido", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    entUnidMxProducto ent_ump = new entUnidMxProducto();
                    ent_ump.Id_Producto = (int)cboxProducto.SelectedValue;
                    ent_ump.Id_UnidadMedida = (int)cboxUnidadMedida.SelectedValue;
                    ent_ump.Cantidad_Equivalente = Convert.ToInt32(txtCantidadEquivalente.Text);
                    ent_ump.Precio_Equivalente = Convert.ToDecimal(txtPrecioEquivalente.Text);
                    try
                    {
                        logUnidMxProducto.Instancia.AgregarUnidMedXProducto(ent_ump);
                        MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                        limpiar();
                        dgvUnidadesMedidaProducto.Enabled = true;
                        ElementosBloqueados();
                        ListarUMxP_Todo();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                        {
                            MessageBox.Show($"La unidad de medida:'{cboxUnidadMedida.Text}' ya existe en el producto:'{cboxProducto.Text}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboxUnidadMedida.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show($"Error en la base de datos: {ex.Message} (Código: {ex.Number})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
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
                MessageBox.Show("Ingrese datos de nueva unidad de medida para un producto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProducto.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (cboxProducto.Text != string.Empty && cboxUnidadMedida.Text != string.Empty && txtCantidadEquivalente.Text != string.Empty && txtPrecioEquivalente.Text != string.Empty)
                {
                    if (txtPrecioEquivalente.Text == ".") // || Convert.ToDecimal(txtPrecioEquivalente.Text) < 1
                    {
                        MessageBox.Show("Precio equivalente inválido", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrecioEquivalente.Focus();
                        return;
                    }
                    DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            entUnidMxProducto ent_ump = new entUnidMxProducto();
                            ent_ump.Id_UMxP_id = Convert.ToInt32(txtId.Text);
                            ent_ump.Id_UM_Producto = id_UM_Producto;
                            ent_ump.Id_Producto = (int)cboxProducto.SelectedValue;
                            ent_ump.Id_UnidadMedida = (int)cboxUnidadMedida.SelectedValue;
                            ent_ump.Cantidad_Equivalente = Convert.ToInt32(txtCantidadEquivalente.Text);
                            ent_ump.Precio_Equivalente = Convert.ToDecimal(txtPrecioEquivalente.Text);
                            try
                            {
                                if(logUnidMxProducto.Instancia.ModificarUnidMedXProducto(ent_ump))
                                {
                                    MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                    limpiar();
                                    ElementosBloqueados();
                                    ListarUMxP_Todo();
                                }
                                else
                                {
                                    MessageBox.Show($"No se puede modificar unidad de medida base de {cboxProducto.Text}", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                    limpiar();
                                    ElementosBloqueados();
                                    return;
                                }
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627 || ex.Number == 2601)
                                {
                                    MessageBox.Show($"La unidad de medida:'{cboxUnidadMedida.Text}' ya existe en el producto:'{cboxProducto.Text}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cboxUnidadMedida.Focus();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show($"Error en la base de datos: {ex.Message} (Código: {ex.Number})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
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
                        txtProducto.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Edite Empleado", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidadEquivalente.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione Unidad de Medida de un Producto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvUnidadesMedidaProducto.Enabled = true;
            ElementosBloqueados();
        }
        private void btnCalcularPrecioEquivalente_Click(object sender, EventArgs e)
        {
            if(txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Busca un producto.", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtCantidadEquivalente.Text == string.Empty)
            {
                MessageBox.Show("Ingresa la cantidad equivalente.", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                decimal precioBase = Convert.ToDecimal(txtPrecio.Text), cantidadEquivalente = Convert.ToDecimal(txtCantidadEquivalente.Text);
                txtPrecioEquivalente.Text = Convert.ToString(precioBase * cantidadEquivalente);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto(txtProducto.Text.Trim().ToUpper());
        }

        private void BuscarProducto(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    object resultadoBusqueda = null;
                    if (Regex.IsMatch(input, @"^[a-zA-Z\sáéíóúÁÉÍÓÚñÑ]+$") && input.Length > 1)
                    {
                        resultadoBusqueda = logUnidMxProducto.Instancia.BuscarProducto_Precio_UMxP(null, input);
                    }
                    else if (Regex.IsMatch(input, @"^\d+$"))
                    {
                        resultadoBusqueda = logUnidMxProducto.Instancia.BuscarProducto_Precio_UMxP(input, null);
                    }
                    else
                    {
                        MessageBox.Show("Id o nombre producto inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProducto.Focus();
                        return;
                    }

                    if (resultadoBusqueda == null || ((IList)resultadoBusqueda).Count == 0)
                    {
                        MessageBox.Show("No se encontró producto.", "AVISO DEL SISTEMA SYS-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProducto.Focus();
                        return;
                    }
                    else
                    {
                        cboxProducto.DataSource = resultadoBusqueda;
                        cboxProducto.DisplayMember = "Nombre";
                        cboxProducto.ValueMember = "Id_Producto";
                        //si registro un producto automaticamente debe crearse un unidad de medida por producto)

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el Software: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete documento o apellidos para buscar.", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
            }
        }

        public void ListarUMxP_Todo()
        {
            dgvUnidadesMedidaProducto.DataSource = logUnidMxProducto.Instancia.ListarUnidMedXProducto();
            dgvUnidadesMedidaProducto.Columns["Id_UMxP_id"].Width = 70;
            dgvUnidadesMedidaProducto.Columns["Id_Producto"].Visible = false;
            dgvUnidadesMedidaProducto.Columns["Producto"].Width = 240;
            dgvUnidadesMedidaProducto.Columns["Id_UM_Producto"].Visible = false;
            dgvUnidadesMedidaProducto.Columns["UM_Producto"].Width = 110;
            dgvUnidadesMedidaProducto.Columns["Precio_Prod"].Width = 110;
            dgvUnidadesMedidaProducto.Columns["Id_UnidadMedida"].Visible = false;
            dgvUnidadesMedidaProducto.Columns["Unidad_Medida"].Width = 110;
            dgvUnidadesMedidaProducto.Columns["Cantidad_Equivalente"].Width = 110;
            dgvUnidadesMedidaProducto.Columns["Precio_Equivalente"].Width = 110;
        }

        public void ListarUnidadesMedida()
        {
            cboxUnidadMedida.DataSource = logUnidadMedida.Instancia.ListarUnidadesMedida();
            cboxUnidadMedida.DisplayMember = "Unidad_Medida";
            cboxUnidadMedida.ValueMember = "Id_UnidadMedida";
        }

        public void limpiar()
        {
            txtId.Clear();
            txtPrecio.Clear();
            txtProducto.Clear();
            cboxProducto.SelectedValue = 1;
            cboxUnidadMedida.SelectedValue = 7;
            txtCantidadEquivalente.Clear();
            txtPrecioEquivalente.Clear();
        }

        public void ElementosBloqueados()
        {
            txtProducto.Enabled = false;
            cboxProducto.Enabled = false;
            cboxUnidadMedida.Enabled = false;
            txtCantidadEquivalente.Enabled = false;
            txtPrecioEquivalente.Enabled = false;
            btnCalcularPrecioEquivalente.Enabled = false;
            btnBuscar.Enabled = false;
        }
        public void ElementosActivos()
        {
            txtProducto.Enabled = true;
            cboxProducto.Enabled = true;
            cboxUnidadMedida.Enabled = true;
            txtCantidadEquivalente.Enabled = true;
            txtPrecioEquivalente.Enabled = true;
            btnCalcularPrecioEquivalente.Enabled = true;
           btnBuscar.Enabled = true;
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

        private void dgvUnidadesMedidaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUnidadesMedidaProducto.CurrentRow.Cells["Id_UMxP_id"].Value.ToString();
            BuscarProducto(dgvUnidadesMedidaProducto.CurrentRow.Cells["Id_Producto"].Value.ToString());
            //cboxProducto.SelectedValue = dgvUnidadesMedidaProducto.CurrentRow.Cells["Id_Producto"].Value;
            id_UM_Producto = (int)dgvUnidadesMedidaProducto.CurrentRow.Cells["Id_UM_Producto"].Value;
            cboxUnidadMedida.SelectedValue = dgvUnidadesMedidaProducto.CurrentRow.Cells["Id_UnidadMedida"].Value;
            txtCantidadEquivalente.Text = dgvUnidadesMedidaProducto.CurrentRow.Cells["Cantidad_Equivalente"].Value.ToString();
            txtPrecioEquivalente.Text = dgvUnidadesMedidaProducto.CurrentRow.Cells["Precio_Equivalente"].Value.ToString();
        }

        private void cboxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            entProducto Precio_UM_Prod = (entProducto)cboxProducto.SelectedItem;
            if(Precio_UM_Prod != null)
            {
                txtPrecio.Text = Precio_UM_Prod.Precio.ToString();
                txtUnidadMedidaBase.Text = Precio_UM_Prod.UnidadMedida.ToString();
            }
            else
            {
                txtPrecio.Text = string.Empty;
                txtUnidadMedidaBase.Text = string.Empty;
            }
        }
    }
}
