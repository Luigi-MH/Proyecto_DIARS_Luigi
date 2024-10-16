﻿using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        byte[] fotoEmpleadoBytes = null;
        bool NuevaFoto = false;

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados(); // grupo de los elemento(heramientas) inabilitadas
            ListarEmpleados();
            dgvEmpleados.Columns["FotoEmpleado"].Visible = false;
            dgvEmpleados.Columns["Telefono"].Visible = false;
            ListarTiposDocumentos();
            ListarCargos();
            limpiar();
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dtpFehaNacimiento.MaxDate = DateTime.Now.AddYears(-18);
            dtpFechaContratacionE.MaxDate = DateTime.Now.AddSeconds(60);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvEmpleados.Enabled = false;
            ElementosActivos();
            txtDocEmpleado.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            txtDocEmpleado.Focus();
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
                    ListarEmpleados();
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
                if (txtSalario.Text == "." || Convert.ToDecimal(txtSalario.Text) < 500)
                {
                    MessageBox.Show("Salario inválido", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(ValidarTodosLosCampos())
                {
                    try
                    {
                        entEmpleados entEmpleado = new entEmpleados();
                        entEmpleado.Id_TipoDocumento = (int)cboxTipoDoc.SelectedValue;
                        entEmpleado.NumDoc = txtDocEmpleado.Text.Trim();
                        entEmpleado.Nombres = txtNombres.Text.Trim().ToUpper();
                        entEmpleado.Apellidos = txtApellidos.Text.Trim().ToUpper();
                        entEmpleado.Correo = txtCorreo.Text.Trim();
                        entEmpleado.Telefono = txtNumero.Text.Trim();
                        entEmpleado.FechaNacimiento = dtpFehaNacimiento.Value;
                        entEmpleado.FotoEmpleado = pbFoto.Image != null ? ImageToByteArray(pbFoto.Image) : null;
                        entEmpleado.FechaContratacion = dtpFechaContratacionE.Value;
                        entEmpleado.Id_Cargo = (int)cboxCargo.SelectedValue;
                        entEmpleado.Salario = Convert.ToDecimal(txtSalario.Text);
                        entEmpleado.Estado = rdActivo.Checked ? true : false;
                        try
                        {
                            logEmpleados.Instancia.AgregarEmpleado(entEmpleado);
                            MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                            limpiar();
                            dgvEmpleados.Enabled = true;
                            ElementosBloqueados();
                            ListarEmpleados();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627 || ex.Number == 2601)
                            {
                                MessageBox.Show($"El Empleado con '{cboxTipoDoc.Text}': '{txtDocEmpleado.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtDocEmpleado.Focus();
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
                MessageBox.Show("Ingrese Datos Empleado", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocEmpleado.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (ValidarDatosVacios())
                {
                    if (txtSalario.Text == "." || Convert.ToDecimal(txtSalario.Text) < 500)
                    {
                        MessageBox.Show("Salario inválido", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (ValidarTodosLosCampos())
                    {
                        DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                entEmpleados entEmpleado = new entEmpleados();
                                entEmpleado.Id_Empleado = Convert.ToInt32(txtId.Text);
                                entEmpleado.Id_TipoDocumento = (int)cboxTipoDoc.SelectedValue;
                                entEmpleado.NumDoc = txtDocEmpleado.Text.Trim();
                                entEmpleado.Nombres = txtNombres.Text.Trim().ToUpper();
                                entEmpleado.Apellidos = txtApellidos.Text.Trim().ToUpper();
                                entEmpleado.Correo = txtCorreo.Text.Trim();
                                entEmpleado.Telefono = txtNumero.Text.Trim();
                                entEmpleado.FechaNacimiento = dtpFehaNacimiento.Value;
                                if (pbFoto.Image != null)
                                {
                                    if(NuevaFoto)
                                    {
                                        entEmpleado.FotoEmpleado = ImageToByteArray(pbFoto.Image);
                                    }
                                    else
                                    {
                                        entEmpleado.FotoEmpleado = fotoEmpleadoBytes != null ? fotoEmpleadoBytes : null;
                                    }
                                }
                                else
                                {
                                    entEmpleado.FotoEmpleado = null;
                                }
                                entEmpleado.FechaContratacion = dtpFechaContratacionE.Value;
                                entEmpleado.Id_Cargo = (int)cboxCargo.SelectedValue;
                                entEmpleado.Salario = Convert.ToDecimal(txtSalario.Text);
                                entEmpleado.Estado = rdActivo.Checked ? true : false;
                                try
                                {
                                    logEmpleados.Instancia.ModificarEmpleado(entEmpleado);
                                    MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                                    limpiarValidacionFoto();
                                    limpiar();
                                    ElementosBloqueados();
                                    ListarEmpleados();
                                }
                                catch (SqlException ex)
                                {
                                    if (ex.Number == 2627 || ex.Number == 2601)
                                    {
                                        MessageBox.Show($"El empleado con '{cboxTipoDoc.Text}': '{txtDocEmpleado.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtDocEmpleado.Focus();
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
                            txtDocEmpleado.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Edite Empleado", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDocEmpleado.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione Empleado", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvEmpleados.Enabled = true;
            ElementosBloqueados();
            limpiarValidacionFoto();
        }

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = logEmpleados.Instancia.ListarEmpleados();
            dgvEmpleados.Columns["Id_Empleado"].Visible = false;
            dgvEmpleados.Columns["Id_TipoDocumento"].Visible = false;
            dgvEmpleados.Columns["TipoDocumento"].Width = 90;
            dgvEmpleados.Columns["NumDoc"].Width = 80;
            dgvEmpleados.Columns["NombreCompleto"].Visible = false;
            dgvEmpleados.Columns["Nombres"].Width = 160;
            dgvEmpleados.Columns["Apellidos"].Width = 150;
            dgvEmpleados.Columns["Correo"].Width = 200;
            dgvEmpleados.Columns["Telefono"].Width = 80;
            dgvEmpleados.Columns["FechaNacimiento"].Visible = false;
            ((DataGridViewImageColumn)dgvEmpleados.Columns["FotoEmpleado"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEmpleados.Columns["FotoEmpleado"].Width = 80;
            dgvEmpleados.Columns["FechaContratacion"].Visible = false;
            dgvEmpleados.Columns["Id_Cargo"].Visible = false;
            dgvEmpleados.Columns["Cargo"].Width = 90;
            dgvEmpleados.Columns["Salario"].Visible = false;
            dgvEmpleados.Columns["Estado"].Width = 80;
        }

        public void ListarTiposDocumentos()
        {
            cboxTipoDoc.DataSource = logTipoDoc.Instancia.ListarTipoDoc();
            cboxTipoDoc.DisplayMember = "Documento"; 
            cboxTipoDoc.ValueMember = "Id_TipoDoc"; 
        }

        public void ListarCargos()
        {
            cboxCargo.DataSource = logCargos.Instancia.ListarCargos();
            cboxCargo.DisplayMember = "Cargo";
            cboxCargo.ValueMember = "Id_Cargo";
        }

        public void limpiar()
        {
            txtId.Clear();
            cboxTipoDoc.SelectedValue = 1;
            txtDocEmpleado.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumero.Clear();
            pbFoto.Image = null;
            txtCorreo.Clear();
            cboxCargo.SelectedValue = 1;
            txtSalario.Clear();
            rdActivo.Checked = true;
            dtpFehaNacimiento.Value = dtpFehaNacimiento.MaxDate;
            dtpFechaContratacionE.Value = dtpFechaContratacionE.Value.ToLocalTime();
        }

        public void limpiarValidacionFoto()
        {
            fotoEmpleadoBytes = null;
            NuevaFoto = false;
        }

        private bool ValidarDatosVacios()
        {
            if (txtDocEmpleado.Text != string.Empty & txtNombres.Text != string.Empty & txtApellidos.Text != string.Empty & txtSalario.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
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
        private bool ValidarTelefono(string telefono)
        {
            // Validar si es un número móvil: 9 dígitos y empieza con 9
            if (Regex.IsMatch(telefono, @"^9\d{8}$"))
            {
                return true;
            }

            // Validar si es un número fijo: 7 o 9 dígitos con opcional código de área (01)
            if (Regex.IsMatch(telefono, @"^(\d{7}|\d{9})$"))
            {
                return true;
            }

            return false;
        }

        private bool ValidarCorreo(string correo)
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$"; // Expresión regular para validar correos
            if (Regex.IsMatch(correo, patronCorreo)) // Devuelve true si el formato es válido
            {
                string[] partes = correo.Split('@');
                string dominio = partes[1];

                if (EsDominioValido(dominio))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool EsDominioValido(string dominio) // puedo quitar el metodo porque no encontrara dominios privados ej: upn.pe
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(dominio);
                return host.AddressList.Length > 0;
            }
            catch (SocketException)
            {
                return false; // Si no se pudo resolver el dominio, es inválido.
            }
        }

        private bool ValidarTodosLosCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text) && string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Completar correo o número.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtNumero.Text) && !ValidarTelefono(txtNumero.Text))
            {
                MessageBox.Show("Número de teléfono inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !ValidarCorreo(txtCorreo.Text))
            {
                MessageBox.Show("Correo electrónico inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreo.Focus();
                return false;
            }

            if (!ValidarDocumento(txtDocEmpleado.Text))
            {
                MessageBox.Show("Número de documento inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocEmpleado.Focus();
                return false;
            }

            return true;
        }

        public void ElementosBloqueados()
        {
            cboxTipoDoc.Enabled = false;
            txtDocEmpleado.Enabled = false;
            btnBuscar.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtNumero.Enabled = false;
            dtpFehaNacimiento.Enabled = false;
            btnSeleccionarFoto.Enabled = false;
            txtCorreo.Enabled = false;
            cboxCargo.Enabled = false;
            dtpFechaContratacionE.Enabled = false;
            txtSalario.Enabled = false;
            rdActivo.Enabled = false;
            rdInactivo.Enabled = false;
        }
        public void ElementosActivos()
        {
            cboxTipoDoc.Enabled = true;
            txtDocEmpleado.Enabled = true;
            btnBuscar.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtNumero.Enabled = true;
            dtpFehaNacimiento.Enabled = true;
            btnSeleccionarFoto.Enabled = true;
            txtCorreo.Enabled = true;
            cboxCargo.Enabled = true;
            dtpFechaContratacionE.Enabled = true;
            txtSalario.Enabled = true;
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
            txtId.Text = dgvEmpleados.CurrentRow.Cells["Id_Empleado"].Value.ToString();
            cboxTipoDoc.SelectedValue = dgvEmpleados.CurrentRow.Cells["Id_TipoDocumento"].Value;
            txtDocEmpleado.Text = dgvEmpleados.CurrentRow.Cells["NumDoc"].Value.ToString();
            txtNombres.Text = dgvEmpleados.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgvEmpleados.CurrentRow.Cells["Apellidos"].Value.ToString();
            txtNumero.Text = dgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
            dtpFehaNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["FechaNacimiento"].Value);
            fotoEmpleadoBytes = dgvEmpleados.CurrentRow.Cells["FotoEmpleado"].Value as byte[];
            if (fotoEmpleadoBytes != null)
            {
                MetodoFoto_Byte_memoryStream_Image(pbFoto, fotoEmpleadoBytes);
            }
            else
            {
                pbFoto.Image = null;
            }
            txtCorreo.Text = dgvEmpleados.CurrentRow.Cells["Correo"].Value.ToString();
            cboxCargo.SelectedValue = dgvEmpleados.CurrentRow.Cells["Id_Cargo"].Value;
            dtpFechaContratacionE.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["FechaContratacion"].Value);
            txtSalario.Text = dgvEmpleados.CurrentRow.Cells["Salario"].Value.ToString();
            Boolean estado = Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells["Estado"].Value.ToString());
            if (estado == true)
            {
                rdActivo.Checked = true;
            }
            else
            {
                rdInactivo.Checked = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersonaDNI_API();
        }

        private async void BuscarPersonaDNI_API()
        {
            if (txtDocEmpleado.TextLength == 8)
            {
                btnBuscar.Enabled = false;
                txtDocEmpleado.Enabled = false;
                bool huboError = false;
                try
                {
                    string result = await logAPIs.Instancia.GET_DNI_Dato(txtDocEmpleado.Text);
                    var persona = JsonConvert.DeserializeObject<entPersona>(result);
                    if (persona.nombres != string.Empty)
                    {
                        txtNombres.Text = persona.nombres;
                        txtApellidos.Text = persona.apellidoPaterno.ToString() + " " + persona.apellidoMaterno.ToString();
                        txtNumero.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Persona con DNI:'{txtDocEmpleado.Text}' no encontrada", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombres.Clear();
                        txtApellidos.Clear();
                        txtDocEmpleado.Focus();
                    }
                }
                catch
                {
                    huboError = true;
                    MessageBox.Show("DNI innválido ", "RENIEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnBuscar.Enabled = true;
                    txtDocEmpleado.Enabled = true;
                    if (huboError)
                    {
                        txtDocEmpleado.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("DNI Incompleto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocEmpleado.Focus();
            }
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionarFoto = new OpenFileDialog();
            ofdSeleccionarFoto.Filter = "Imagenes(*.png)|*.png|Imagenes(*.jpg)|*.jpg";
            ofdSeleccionarFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionarFoto.Title = "Seleccionar Foto";
            
            if(ofdSeleccionarFoto.ShowDialog() == DialogResult.OK )
            {
                pbFoto.Image = System.Drawing.Image.FromFile(ofdSeleccionarFoto.FileName);
                NuevaFoto = true;
            }
        }

        public void MetodoFoto_Byte_memoryStream_Image(PictureBox pbFotoEmpleado, byte[] fotoBytes)
        {
            using (MemoryStream ms = new MemoryStream(fotoBytes))
            {
                pbFotoEmpleado.Image = System.Drawing.Image.FromStream(ms);
            }
        }
        private byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Aquí decides el formato
                return ms.ToArray();
            }
        }

        private void cboxTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDocEmpleado.Clear();
            txtDocEmpleado.Focus();

            switch (cboxTipoDoc.Text)
            {
                case "DNI":
                    txtDocEmpleado.MaxLength = 8;
                    btnBuscar.Enabled = txtDocEmpleado.Enabled;
                    break;

                case "PASAPORTE":
                    txtDocEmpleado.MaxLength = 8;
                    btnBuscar.Enabled = false;
                    break;

                case "CARNET EXT.":
                    txtDocEmpleado.MaxLength = 9;
                    btnBuscar.Enabled = false;
                    break;

                default:
                    txtDocEmpleado.MaxLength = 0;
                    btnBuscar.Enabled = false;
                    break;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Verifica si la tecla es un número, backspace o punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela la entrada si no es un número, punto o control
                return;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true; // Cancela la entrada si ya existe un punto
                return;
            }

            // Limitar a dos dígitos después del punto decimal
            if (txt.Text.Contains("."))
            {
                int indicePunto = txt.Text.IndexOf('.');
                if (txt.SelectionStart > indicePunto && txt.Text.Substring(indicePunto + 1).Length >= 2)
                {
                    e.Handled = true; // Cancela la entrada si hay más de 2 dígitos después del punto
                }
            }
        }

        private void txtDocEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxTipoDoc.Text == "DNI")
            {
                if ((e.KeyChar >= 32 & e.KeyChar <= 47) || (e.KeyChar >= 58 & e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (cboxTipoDoc.Text == "RUC")
            {
                if ((e.KeyChar >= 32 & e.KeyChar <= 47) || (e.KeyChar >= 58 & e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarPersonaDNI_API();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255 && e.KeyChar != 209 && e.KeyChar != 241))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidos.Focus();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255 && e.KeyChar != 209 && e.KeyChar != 241))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 47) || (e.KeyChar >= 58 & e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCorreo.Focus();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSalario.Focus();
            }
        }
        private void dtpFehaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtpFechaContratacionE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void chboxVerFotoLista_CheckedChanged(object sender, EventArgs e)
        {
            dgvEmpleados.Columns["FotoEmpleado"].Visible = chbVerFoto.Checked ? true : false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dgvEmpleados.Columns["Telefono"].Visible =  chbVerNumero.Checked ? true : false;
        }
    }
}
