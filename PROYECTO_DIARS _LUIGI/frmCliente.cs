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

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados(); // grupo de los elemento(heramientas) inabilitadas
            ListarClientes();
            ListarTiposDocumentos();
            limpiar();
            dgvClientes.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvClientes.Enabled = false;
            ElementosActivos();
            txtDocCliente.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            txtDocCliente.Focus();
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
                        entEmpleados entEmpleados = new entEmpleados();
                        entEmpleados.Id_Empleado = Convert.ToInt32(txtId.Text);
                        try
                        {
                            //logEmpleados.Instancia.EliminarEmpleado(entEmpleados);
                            MessageBox.Show("Aún no se implementa el eliminar", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se eliminó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            ElementosBloqueados();
                            ListarClientes();
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
                MessageBox.Show("Selecione Cliente", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDocCliente.Text != string.Empty && txtCliente.Text != string.Empty)
            {
                if (ValidarDocumento(txtDocCliente.Text))
                {
                    if(cboxTipoDoc.Text == "RUC" && txtDireccion.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese direccion de cliennte", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if(cboxTipoDoc.Text == "RUC" && txtDireccion.TextLength < 15)
                    {
                        MessageBox.Show("Ingrese direccion completa de cliennte", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    try
                    {
                        entCliente cliente = new entCliente();
                        cliente.Id_TipoDocumento = (int)cboxTipoDoc.SelectedValue;
                        cliente.Documento = txtDocCliente.Text.Trim();
                        cliente.Cliente = txtCliente.Text.Trim().ToUpper();
                        cliente.Direccion = txtDireccion.Text.Trim().ToUpper();
                        cliente.Telefono = txtTelefono.Text.Trim();
                        cliente.Estado = rdActivo.Checked ? true : false;
                        try
                        {
                            logCliente.Instancia.AgregarCliente(cliente);
                            MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                            limpiar();
                            dgvClientes.Enabled = true;
                            ElementosBloqueados();
                            ListarClientes();
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
            }
            else
            {
                MessageBox.Show("Ingrese datos cliente", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocCliente.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (txtDocCliente.Text != string.Empty && txtCliente.Text != string.Empty)
                {
                    if (ValidarDocumento(txtDocCliente.Text))
                    {
                        if (cboxTipoDoc.Text == "RUC" && txtDireccion.Text == string.Empty)
                        {
                            MessageBox.Show("Ingrese direccion de cliennte", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (cboxTipoDoc.Text == "RUC" && txtDireccion.TextLength < 15)
                        {
                            MessageBox.Show("Ingrese direccion completa del cliennte", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                entCliente cliente = new entCliente();
                                cliente.Id_Cliente = Convert.ToInt32(txtId.Text);
                                cliente.Id_TipoDocumento = (int)cboxTipoDoc.SelectedValue;
                                cliente.Documento = txtDocCliente.Text.Trim();
                                cliente.Cliente = txtCliente.Text.Trim().ToUpper();
                                cliente.Direccion = txtDireccion.Text.Trim().ToUpper();
                                cliente.Telefono = txtTelefono.Text.Trim();
                                cliente.Estado = rdActivo.Checked ? true : false;
                                try
                                {
                                    logCliente.Instancia.ModificarCliente(cliente);
                                    MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                    limpiar();
                                    ElementosBloqueados();
                                    ListarClientes();
                                }
                                catch (SqlException ex)
                                {
                                    if (ex.Number == 2627 || ex.Number == 2601)
                                    {
                                        MessageBox.Show($"El empleado con '{cboxTipoDoc.Text}': '{txtDocCliente.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            txtDocCliente.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Edite cliente", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDocCliente.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione cliente", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvClientes.Enabled = true;
            ElementosBloqueados();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(cboxTipoDoc.Text == "RUC")
            {
                BuscarEmpresaRUC_API();
            }
            else if(cboxTipoDoc.Text == "DNI")
            {
                BuscarPersonaDNI_API();
            }
        }

        private async void BuscarPersonaDNI_API()
        {
            if (txtDocCliente.TextLength == 8)
            {
                btnBuscarCliente.Enabled = false;
                txtDocCliente.Enabled = false;
                bool huboError = false;
                try
                {
                    string result = await logAPIs.Instancia.GET_DNI_Dato(txtDocCliente.Text.Trim());
                    var persona = JsonConvert.DeserializeObject<entPersona>(result);
                    if (persona.nombres != string.Empty)
                    {
                        txtCliente.Text = persona.apellidoPaterno + " " + persona.apellidoMaterno + " " + persona.nombres;
                        txtDireccion.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Persona con DNI:'{txtDocCliente.Text}' no encontrada", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCliente.Clear();
                        txtDireccion.Clear();
                        txtTelefono.Clear();
                    }
                }
                catch
                {
                    huboError = true;
                    MessageBox.Show("DNI innválido ", "RENIEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnBuscarCliente.Enabled = true;
                    txtDocCliente.Enabled = true;
                    if (huboError)
                    {
                        txtDocCliente.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("DNI Incompleto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocCliente.Focus();
            }
        }

        private async void BuscarEmpresaRUC_API()
        {
            if (txtDocCliente.TextLength == 11)
            {
                btnBuscarCliente.Enabled = false;
                txtDocCliente.Enabled = false;
                bool huboError = false;
                try
                {
                    string result = await logAPIs.Instancia.GET_RUC_Datos(txtDocCliente.Text.Trim());
                    var empresa = JsonConvert.DeserializeObject<entEmpresa>(result);
                    if (empresa.razonSocial != string.Empty)
                    {
                        txtCliente.Text = empresa.razonSocial;
                        txtDireccion.Text = empresa.direccion;
                        txtTelefono.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Empresa con RUC:'{txtDocCliente.Text}' no encontrada", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCliente.Clear();
                        txtDireccion.Clear();
                        txtTelefono.Clear();
                    }
                }
                catch
                {
                    huboError = true;
                    MessageBox.Show("RUC innválido ", "SUNAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnBuscarCliente.Enabled = true;
                    txtDocCliente.Enabled = true;
                    if (huboError)
                    {
                        txtDocCliente.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("RUC Incompleto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocCliente.Focus();
            }
        }

        public void ListarClientes()
        {
            dgvClientes.DataSource = logCliente.Instancia.ListarClientes();
            dgvClientes.Columns["Id_Cliente"].Width = 70;
            dgvClientes.Columns["Id_TipoDocumento"].Visible = false;
            dgvClientes.Columns["Tipo_Documento"].Width = 90;
            dgvClientes.Columns["Documento"].Width = 90;
            dgvClientes.Columns["Cliente"].Width = 280;
            dgvClientes.Columns["Direccion"].Width = 280;
            dgvClientes.Columns["Telefono"].Visible = false;
            dgvClientes.Columns["Estado"].Width = 90;
        }

        public void ListarTiposDocumentos()
        {
            cboxTipoDoc.DataSource = logTipoDoc.Instancia.ListarTiposDocumento_Todo();
            cboxTipoDoc.DisplayMember = "Documento";
            cboxTipoDoc.ValueMember = "Id_TipoDoc";
        }

        public void limpiar()
        {
            txtId.Clear();
            cboxTipoDoc.SelectedValue = 1;
            txtDocCliente.Clear();
            txtCliente.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            rdActivo.Checked = true;
        }

        public void ElementosBloqueados()
        {
            cboxTipoDoc.Enabled = false;
            txtDocCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            txtCliente.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            rdActivo.Enabled = false;
            rdInactivo.Enabled = false;
        }
        public void ElementosActivos()
        {
            cboxTipoDoc.Enabled = true;
            txtDocCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            txtCliente.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            rdActivo.Enabled = true;
            rdInactivo.Enabled = true;
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

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClientes.CurrentRow.Cells["Id_Cliente"].Value.ToString();
            cboxTipoDoc.SelectedValue = dgvClientes.CurrentRow.Cells["Id_TipoDocumento"].Value;
            txtDocCliente.Text = dgvClientes.CurrentRow.Cells["Documento"].Value.ToString();
            txtCliente.Text = dgvClientes.CurrentRow.Cells["Cliente"].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            Boolean estado = Convert.ToBoolean(dgvClientes.CurrentRow.Cells["Estado"].Value.ToString());
            if (estado == true)
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdInactivo.Checked = true;
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

        private void cboxTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDocCliente.Clear();
            txtDocCliente.Focus();

            switch (cboxTipoDoc.Text)
            {
                case "DNI":
                    txtDocCliente.MaxLength = 8;
                    btnBuscarCliente.Enabled = txtDocCliente.Enabled;
                    break;

                case "RUC":
                    txtDocCliente.MaxLength = 11;
                    btnBuscarCliente.Enabled = txtDocCliente.Enabled;
                    break;

                case "PASAPORTE":
                    txtDocCliente.MaxLength = 8;
                    btnBuscarCliente.Enabled = false;
                    break;

                case "CARNET EXT.":
                    txtDocCliente.MaxLength = 9;
                    btnBuscarCliente.Enabled = false;
                    break;

                default:
                    txtDocCliente.MaxLength = 0;
                    btnBuscarCliente.Enabled = false;
                    break;
            }
        }

        private void txtDocCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxTipoDoc.Text == "DNI")
            {
                if ((e.KeyChar >= 32 & e.KeyChar <= 47) || (e.KeyChar >= 58 & e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BuscarPersonaDNI_API();
                }
            }
            else if (cboxTipoDoc.Text == "RUC")
            {
                if ((e.KeyChar >= 32 & e.KeyChar <= 47) || (e.KeyChar >= 58 & e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BuscarEmpresaRUC_API();
                }
            }
            else if (cboxTipoDoc.Text == "PASAPORTE")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
                {
                    e.Handled = true;
                }
            }
            else if (cboxTipoDoc.Text == "CARNET EXT.")
            {
                if ((e.KeyChar >= 32 & e.KeyChar <= 47) || (e.KeyChar >= 58 & e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
