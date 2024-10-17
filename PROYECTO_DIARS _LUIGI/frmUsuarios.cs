using CapaEntidad;
using CapaLogica;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        string ContraseñaGuardada = string.Empty;

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados();
            ListarUsuarios();
            ListarRoles();
            limpiar();
            dgvUsuarios.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvUsuarios.Enabled = false;
            ElementosActivos();
            txtUsuario.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            lblContraseña.Text = "Nueva Contraseña";
            txtUsuario.Focus();
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
                        entUsuario usuario = new entUsuario();
                        usuario.Id_Empleado = Convert.ToInt32(txtId.Text);
                        try
                        {
                            //logEmpleados.Instancia.EliminarEmpleado(entEmpleados);
                            MessageBox.Show("Aún no se implementa el eliminar", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se eliminó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarUsuarios();
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
                        MessageBox.Show("Error.." + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione Empleado", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosVacios())
            {
                if(EsContrasenaFuerte(txtContraseña.Text))
                {
                    try
                    {
                        entUsuario usuario = new entUsuario();
                        usuario.NombreUsuario = txtUsuario.Text.Trim();
                        usuario.Contraseña = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text.Trim());
                        usuario.Id_Rol = (int)cboxRol.SelectedValue;
                        usuario.Id_Empleado = (int)cboxEmpleado.SelectedValue;
                        usuario.FechaCreacion = DateTime.Now;
                        usuario.Estado = rdActivo.Checked ? true : false;
                        try
                        {
                            logUsuario.Instancia.AgregarUsuario(usuario);
                            MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                            limpiar();
                            dgvUsuarios.Enabled = true;
                            ElementosBloqueados();
                            ListarUsuarios();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627 || ex.Number == 2601)
                            {
                                MessageBox.Show($"El usuario:'{txtUsuario.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsuario.Focus();
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
                    MessageBox.Show("Contraseña mínimo de 8 caracteres, una mayúscula, una minúscula, un número y un caracter especial.", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos usuario", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (txtUsuario.Text != string.Empty && cboxEmpleado.Text != string.Empty)
                {
                    entUsuario usuario = new entUsuario();
                    if (txtContraseña.Text != string.Empty)
                    {
                        if (EsContrasenaFuerte(txtContraseña.Text))
                        {
                            usuario.Contraseña = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Nueva Contraseña mínimo de 8 caracteres, una mayúscula, una minúscula, un número y un caracter especial.", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtContraseña.Focus();
                            return;
                        }
                    }
                    else if (ContraseñaGuardada != string.Empty)
                    {
                        usuario.Contraseña = ContraseñaGuardada;
                    }
                    DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            usuario.Id_Usuario = Convert.ToInt32(txtId.Text);
                            usuario.NombreUsuario = txtUsuario.Text.Trim();
                            usuario.Id_Rol = (int)cboxRol.SelectedValue;
                            usuario.Id_Empleado = (int)cboxEmpleado.SelectedValue;
                            usuario.FechaCreacion = DateTime.Now;
                            usuario.Estado = rdActivo.Checked ? true : false;
                            try
                            {
                                logUsuario.Instancia.ModificarUsuario(usuario);
                                MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                ContraseñaGuardada = string.Empty;
                                limpiar();
                                ElementosBloqueados();
                                ListarUsuarios();
                                lblContraseña.Text = "Contraseña";
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627 || ex.Number == 2601)
                                {
                                    MessageBox.Show($"El usuario:'{txtUsuario.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtUsuario.Focus();
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
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Edite usuario", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione usuario", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            ContraseñaGuardada = string.Empty;
            limpiar();
            dgvUsuarios.Enabled = true;
            ElementosBloqueados();
            lblContraseña.Text = "Contraseña";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado(txtDocumentoApellidos.Text.Trim());
        }

        private void BuscarEmpleado(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    object resultadoBusqueda = null;

                    if (ValidarDocumento(input) && input.Length > 1)
                    {
                        resultadoBusqueda = logUsuario.Instancia.BuscarEmpleado(null, input);
                    }
                    else if (Regex.IsMatch(input, @"^[a-zA-Z\sáéíóúÁÉÍÓÚñÑ]+$") && input.Length > 1)
                    {
                        resultadoBusqueda = logUsuario.Instancia.BuscarEmpleado(input, null);
                    }
                    else
                    {
                        MessageBox.Show("DNI o Apellidos inválidos.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocumentoApellidos.Focus();
                        return;
                    }

                    if (resultadoBusqueda == null || ((IList)resultadoBusqueda).Count == 0)
                    {
                        MessageBox.Show("No se encontró empleado.", "AVISO DEL SISTEMA SYS-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocumentoApellidos.Focus();
                        return;
                    }
                    else
                    {
                        cboxEmpleado.DataSource = resultadoBusqueda;
                        cboxEmpleado.DisplayMember = "NombreCompleto"; // nombre del empleado
                        cboxEmpleado.ValueMember = "Id_Empleado";
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
                txtDocumentoApellidos.Focus();
            }
        }

        private bool EsContrasenaFuerte(string password)
        {
            return password.Length >= 8 && 
                   password.Any(char.IsUpper) && 
                   password.Any(char.IsLower) && 
                   password.Any(char.IsDigit) && 
                   password.Any(ch => "!@#$%^&*()_+[]{}|;:,.<>?".Contains(ch));
        }

        private bool ValidarDocumento(string documento)
        {
            // Validar si es DNI: 8 dígitos numéricos
            if (Regex.IsMatch(documento, @"^\d{8}$"))
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

        public void ListarUsuarios()
        {
            dgvUsuarios.DataSource = logUsuario.Instancia.ListarUsuarios();
            dgvUsuarios.Columns["Id_Usuario"].Width = 70;
            dgvUsuarios.Columns["NombreUsuario"].Width = 140;
            dgvUsuarios.Columns["Contraseña"].Visible = false;
            dgvUsuarios.Columns["Id_Rol"].Visible = false;
            dgvUsuarios.Columns["Rol"].Width = 80;
            dgvUsuarios.Columns["Id_Empleado"].Visible = false;
            dgvUsuarios.Columns["DocumentoEmpleado"].Visible = false;
            dgvUsuarios.Columns["NombreEmpleado"].Width = 250;
            dgvUsuarios.Columns["FechaCreacion"].Width = 120;
            dgvUsuarios.Columns["Estado"].Width = 80;
        }

        public void ListarRoles()
        {
            cboxRol.DataSource = logRoles.Instancia.ListarRoles();
            cboxRol.DisplayMember = "Rol"; // nombre del cargo
            cboxRol.ValueMember = "Id_Rol";
        }

        public void limpiar()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            cboxRol.SelectedValue = 2;
            txtDocumentoApellidos.Clear();
            cboxEmpleado.SelectedValue = 1; // hay posibilidad de que funcione sin este linea ya que la busque se hacer despues
            rdActivo.Checked = true;
        }

        public void ElementosBloqueados()
        {
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            cboxRol.Enabled = false;
            txtDocumentoApellidos.Enabled = false;
            cboxEmpleado.Enabled = false;
            btnBuscar.Enabled = false;
            rdActivo.Enabled = false;
            rdInactivo.Enabled = false;
        }
        public void ElementosActivos()
        {
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            cboxRol.Enabled = true;
            txtDocumentoApellidos.Enabled = true;
            cboxEmpleado.Enabled = true;
            btnBuscar.Enabled = true;
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

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
            ContraseñaGuardada = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            cboxRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["Id_Rol"].Value;
            BuscarEmpleado(dgvUsuarios.CurrentRow.Cells["DocumentoEmpleado"].Value.ToString());
            //cboxEmpleado.SelectedValue = dgvUsuarios.CurrentRow.Cells["Id_Empleado"].Value;
            Boolean estado = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells["Estado"].Value.ToString());
            if (estado == true)
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdInactivo.Checked = true;
            }
        }

        private bool ValidarDatosVacios()
        {
            if (txtUsuario.Text != string.Empty & txtContraseña.Text != string.Empty & cboxEmpleado.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back) // Permitir la tecla Backspace
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
            }
        }

        private void txtDocumentoApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar == ' ' && !"!@#$%^&*()_+[]{}|;:,.<>?".Contains(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si el carácter no es permitido
            }
        }
    }
}
