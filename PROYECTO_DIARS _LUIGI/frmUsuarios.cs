using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

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
                    ListarUsuarios();
                }
                limpiar();
                ElementosBloqueados();
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
                try
                {
                    entUsuario usuario = new entUsuario();
                    usuario.NombreUsuario = txtUsuario.Text.Trim();
                    usuario.Contraseña = txtContraseña.Text.Trim();
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
                MessageBox.Show("Ingrese datos usuario", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (ValidarDatosVacios())
                {
                    DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            entUsuario usuario = new entUsuario();
                            usuario.Id_Usuario = Convert.ToInt32(txtId.Text);
                            usuario.NombreUsuario = txtUsuario.Text.Trim();
                            usuario.Contraseña = txtContraseña.Text.Trim();
                            usuario.Id_Rol = (int)cboxRol.SelectedValue;
                            usuario.Id_Empleado = (int)cboxEmpleado.SelectedValue;
                            usuario.FechaCreacion = DateTime.Now;
                            usuario.Estado = rdActivo.Checked ? true : false;
                            try
                            {
                                logUsuario.Instancia.ModificarUsuario(usuario);
                                MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                limpiar();
                                ElementosBloqueados();
                                ListarUsuarios();
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
            limpiar();
            dgvUsuarios.Enabled = true;
            ElementosBloqueados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        public void ListarUsuarios()
        {
            dgvUsuarios.DataSource = logUsuario.Instancia.ListarUsuarios();
            dgvUsuarios.Columns["Id_Usuario"].Width = 100;
            dgvUsuarios.Columns["NombreUsuario"].Width = 140;
            dgvUsuarios.Columns["Contraseña"].Width = 140;
            dgvUsuarios.Columns["Id_Rol"].Width = 140;
            dgvUsuarios.Columns["Rol"].Width = 140;
            dgvUsuarios.Columns["Id_Empleado"].Width = 140;
            dgvUsuarios.Columns["NombreEmpleado"].Width = 140;
            dgvUsuarios.Columns["ApellidoEmpleado"].Width = 140;
            dgvUsuarios.Columns["FechaCreacion"].Width = 140;
            dgvUsuarios.Columns["Estado"].Width = 140;
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
            cboxEmpleado.SelectedValue = 1;
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
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            cboxRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["Id_Rol"].Value;
            //cboxEmpleado.SelectedValue = dgvUsuarios.CurrentRow.Cells["Id_TipoDocumento"].Value; // aca debo de buscar a mi empleado y ponerlo en listra otra vez
            // la fecha no se muestra, solo en el dgvUsuarios                                        // juntar mi apellido y nombre y listarlo en un mismo combobox
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
    }
}
