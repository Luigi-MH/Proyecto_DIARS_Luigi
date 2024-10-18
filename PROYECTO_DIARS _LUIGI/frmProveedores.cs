using CapaEntidad;
using CapaLogica;
using Newtonsoft.Json;
using System;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados();
            ListarProveedores();
            limpiar();
            dgvProveedores.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvProveedores.Enabled = false;
            ElementosActivos();
            txtRUC.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            txtRUC.Focus();
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
                        try
                        {
                            logProveedor.Instancia.EliminarProveedor(Convert.ToInt32(txtId.Text));
                            MessageBox.Show("Se eliminó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarProveedores();
                            limpiar();
                            ElementosBloqueados();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error en la base de datos: {ex.Message} (Código: {ex.Number})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en el Software: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione Proveedor", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtRUC.Text != string.Empty && txtRazonSocial.Text != string.Empty && txtDireccion.Text != string.Empty)
            {
                if(txtRepresentante.Text != string.Empty && txtTelefonoRepresentante.Text == string.Empty || txtRepresentante.Text == string.Empty && txtTelefonoRepresentante.Text != string.Empty)
                {
                    MessageBox.Show($"Ingrese nombre y número de representante de {txtRazonSocial.Text}", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(txtTelefono.Text != string.Empty || txtCorreo.Text != string.Empty)
                {
                    if (txtRazonSocial.TextLength > 15 && txtDireccion.TextLength > 10)
                    {
                        try
                        {
                            entProveedor proveedor = new entProveedor();
                            proveedor.RUC = txtRUC.Text.Trim();
                            proveedor.RazonSocial = txtRazonSocial.Text.Trim();
                            proveedor.Ciudad = txtCiudad.Text.Trim();
                            proveedor.Telefono = txtTelefono.Text.Trim();
                            proveedor.Direccion = txtDireccion.Text.Trim();
                            proveedor.Correo = txtCorreo.Text.Trim();
                            proveedor.Representate = txtRepresentante.Text.Trim();
                            proveedor.Telefono_Rep = txtTelefonoRepresentante.Text.Trim();
                            proveedor.Estado = rdActivo.Checked ? true : false;
                            try
                            {
                                logProveedor.Instancia.AgregarProveedor(proveedor);
                                MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                limpiar();
                                dgvProveedores.Enabled = true;
                                ElementosBloqueados();
                                ListarProveedores();
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627)
                                {
                                    MessageBox.Show($"El proveedor con RUC:'{txtRUC.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtRUC.Focus();
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
                        MessageBox.Show("Razon social o dirección inválida.", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRazonSocial.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese número o correo de proveedor ", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos de proveedor", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRUC.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione proveedor", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtRUC.Text != string.Empty && txtRazonSocial.Text != string.Empty && txtDireccion.Text != string.Empty)
            {
                if (txtRepresentante.Text != string.Empty && txtTelefonoRepresentante.Text == string.Empty || txtRepresentante.Text == string.Empty && txtTelefonoRepresentante.Text != string.Empty)
                {
                    MessageBox.Show($"Ingrese nombre y número de representante de {txtRazonSocial.Text}", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (txtTelefono.Text != string.Empty || txtCorreo.Text != string.Empty)
                {
                    if (txtRazonSocial.TextLength > 15 && txtDireccion.TextLength > 10)
                    {
                        DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                entProveedor proveedor = new entProveedor();
                                proveedor.Id_Proveedor = Convert.ToInt32(txtId.Text.Trim());
                                proveedor.RUC = txtRUC.Text.Trim();
                                proveedor.RazonSocial = txtRazonSocial.Text.Trim();
                                proveedor.Ciudad = txtCiudad.Text.Trim();
                                proveedor.Telefono = txtTelefono.Text.Trim();
                                proveedor.Direccion = txtDireccion.Text.Trim();
                                proveedor.Correo = txtCorreo.Text.Trim();
                                proveedor.Representate = txtRepresentante.Text.Trim();
                                proveedor.Telefono_Rep = txtTelefonoRepresentante.Text.Trim();
                                proveedor.Estado = rdActivo.Checked ? true : false;
                                try
                                {
                                    logProveedor.Instancia.ModificarProveedor(proveedor);
                                    MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                    limpiar();
                                    ElementosBloqueados();
                                    ListarProveedores();
                                }
                                catch (SqlException ex)
                                {
                                    if (ex.Number == 2627)
                                    {
                                        MessageBox.Show($"El proveedor con RUC:'{txtRUC.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtRUC.Focus();
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
                            txtRUC.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Razon social o dirección inválida.", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRazonSocial.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese número o correo de proveedor ", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos de proveedor", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRUC.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvProveedores.Enabled = true;
            ElementosBloqueados();
        }
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarEmpresaRUC_API();
        }

        private async void BuscarEmpresaRUC_API()
        {
            if (txtRUC.TextLength == 11)
            {
                btnBuscarProveedor.Enabled = false;
                txtRUC.Enabled = false;
                bool huboError = false;
                try
                {
                    string result = await logAPIs.Instancia.GET_RUC_Datos(txtRUC.Text.Trim());
                    var empresa = JsonConvert.DeserializeObject<entEmpresa>(result);
                    if (empresa.razonSocial != string.Empty)
                    {
                        txtRazonSocial.Text = empresa.razonSocial;
                        txtDireccion.Text = empresa.direccion;
                        txtCiudad.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Empresa con RUC:'{txtRUC.Text}' no encontrada", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRazonSocial.Clear();
                        txtDireccion.Clear();
                        txtTelefono.Clear();
                        txtRUC.Focus();
                    }
                }
                catch
                {
                    huboError = true;
                    MessageBox.Show("RUC innválido ", "SUNAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnBuscarProveedor.Enabled = true;
                    txtRUC.Enabled = true;
                    if (huboError)
                    {
                        txtRUC.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("RUC Incompleto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRUC.Focus();
            }
        }

        public void ListarProveedores()
        {
            dgvProveedores.DataSource = logProveedor.Instancia.ListarProveedor();
            dgvProveedores.Columns["Id_Proveedor"].Width = 70;
            dgvProveedores.Columns["RUC"].Width = 70;
            dgvProveedores.Columns["RazonSocial"].Width = 150;
            dgvProveedores.Columns["Ciudad"].Width = 70;
            dgvProveedores.Columns["Telefono"].Width = 70;
            dgvProveedores.Columns["Direccion"].Width = 150;
            dgvProveedores.Columns["Correo"].Width = 70;
            dgvProveedores.Columns["Representate"].Width = 150;
            dgvProveedores.Columns["Telefono_Rep"].Width = 70;
            dgvProveedores.Columns["Estado"].Width = 70;
        }

        public void limpiar()
        {
            txtId.Clear();
            txtRUC.Clear();
            txtRazonSocial.Clear();
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtRepresentante.Clear();
            txtTelefonoRepresentante.Clear();
            rdActivo.Checked = true;
        }

        public void ElementosBloqueados()
        {
            txtRUC.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtCiudad.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtCorreo.Enabled = false;
            txtRepresentante.Enabled = false;
            txtTelefonoRepresentante.Enabled = false;
            rdActivo.Enabled = false;
            rdInactivo.Enabled = false;
            btnBuscarProveedor.Enabled = false;
        }
        public void ElementosActivos()
        {
            txtRUC.Enabled = true;
            txtRazonSocial.Enabled = true;
            txtCiudad.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtCorreo.Enabled = true;
            txtRepresentante.Enabled = true;
            txtTelefonoRepresentante.Enabled = true;
            rdActivo.Enabled = true;
            rdInactivo.Enabled = true;
            btnBuscarProveedor.Enabled = true;
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

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
            txtRUC.Text = dgvProveedores.CurrentRow.Cells["RUC"].Value.ToString();
            txtRazonSocial.Text = dgvProveedores.CurrentRow.Cells["RazonSocial"].Value.ToString();
            txtCiudad.Text = dgvProveedores.CurrentRow.Cells["Ciudad"].Value.ToString();
            txtTelefono.Text = dgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = dgvProveedores.CurrentRow.Cells["Direccion"].Value.ToString();
            txtCorreo.Text = dgvProveedores.CurrentRow.Cells["Correo"].Value.ToString();
            txtRepresentante.Text = dgvProveedores.CurrentRow.Cells["Representate"].Value.ToString();
            txtTelefonoRepresentante.Text = dgvProveedores.CurrentRow.Cells["Telefono_Rep"].Value.ToString();
            Boolean estado = Convert.ToBoolean(dgvProveedores.CurrentRow.Cells["Estado"].Value.ToString());
            if (estado == true)
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdInactivo.Checked = true;
            }
        }


    }
}
