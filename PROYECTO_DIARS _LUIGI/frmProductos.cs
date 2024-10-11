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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            ElementosBloqueados(); // grupo de los elemento(heramientas) inabilitadas
            ListarProductos();
            ListarCategorias();
            ListarUnidadesMedida();
            ListarEstadosDisponibilidadProducto();
            limpiar();
            dgvProductos.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvProductos.Enabled = false;
            ElementosActivos();
            txtNombreProducto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            ElementosActivos();
            txtNombreProducto.Focus();
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
                            ListarProductos();
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
                MessageBox.Show("Selecione Producto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosVacios())
            {
                try
                {
                    entProducto prod = new entProducto();
                    prod.Nombre = txtNombreProducto.Text.Trim();
                    prod.Foto_Producto = null;
                    prod.Descripcion = txtDescripcion.Text.Trim();
                    prod.Id_Categoria = (int)cboxCategoria.SelectedValue;
                    prod.Id_LabFabricante = (int)cboxLabFabricante.SelectedValue;
                    prod.CodigoBarras = txtNumCodBarras.Text.Trim();
                    prod.Requiere_Receta = chbNecesitaReceta.Checked ? true : false;
                    prod.Es_Generio = chbEsGenerico.Checked ? true : false;
                    prod.Id_UnidadMendida = (int)cboxUnidadMedida.SelectedValue;
                    prod.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());
                    prod.Id_Estado = (int)cboxEstado.SelectedValue;
                    try
                    {
                        logProducto.Instancia.AgregarProducto(prod);
                        MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                        limpiar();
                        dgvProductos.Enabled = true;
                        ElementosBloqueados();
                        ListarProductos();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                        {
                            MessageBox.Show($"El producto:'{txtNombreProducto.Text}' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNombreProducto.Focus();
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
                MessageBox.Show("Ingrese datos producto", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreProducto.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string input = txtLabFabricante.Text.Trim();
            BuscarLaboratorioFabricante(input);
        }

        public void BuscarLaboratorioFabricante(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                try
                {
                    object resultadoBusqueda = null;

                    if (input.Length > 1)
                    {
                        resultadoBusqueda = logProducto.Instancia.BuscarLaboratorio(input);
                    }
                    else
                    {
                        MessageBox.Show("Nombre de laboratorio inválido.", "Aviso del Sistema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLabFabricante.Focus();
                        return;
                    }

                    if (resultadoBusqueda == null || ((IList)resultadoBusqueda).Count == 0)
                    {
                        MessageBox.Show("No se encontró laboratorio.", "AVISO DEL SISTEMA SYS-MH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLabFabricante.Focus();
                    }
                    else
                    {
                        cboxLabFabricante.DataSource = resultadoBusqueda;
                        cboxLabFabricante.DisplayMember = "LaboratorioFabricante"; // nombre del empleado
                        cboxLabFabricante.ValueMember = "Id_LabFabricante";
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
            }
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionarFoto = new OpenFileDialog();
            ofdSeleccionarFoto.Filter = "Imagenes(*.png)|*.png|Imagenes(*.jpg)|*.jpg";
            ofdSeleccionarFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionarFoto.Title = "Seleccionar Foto";

            if (ofdSeleccionarFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = System.Drawing.Image.FromFile(ofdSeleccionarFoto.FileName);
                //NuevaFoto = true;
            }
        }

        public void ListarProductos()
        {
            dgvProductos.DataSource = logProducto.Instancia.ListarProductos();
            dgvProductos.Columns["Id_Producto"].Width = 70;
            dgvProductos.Columns["Nombre"].Width = 140;
            ((DataGridViewImageColumn)dgvProductos.Columns["Foto_Producto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvProductos.Columns["Foto_Producto"].Width = 80;
            dgvProductos.Columns["Descripcion"].Width = 250;
            dgvProductos.Columns["Id_Categoria"].Visible = false;
            dgvProductos.Columns["Categoria"].Width = 120;
            dgvProductos.Columns["Id_LabFabricante"].Visible = false;
            dgvProductos.Columns["Laboratorio"].Width = 120;
            dgvProductos.Columns["CodigoBarras"].Width = 120;
            dgvProductos.Columns["Requiere_Receta"].Width = 80;
            dgvProductos.Columns["Es_Generio"].Width = 80;
            dgvProductos.Columns["Id_UnidadMendida"].Visible = false;
            dgvProductos.Columns["UnidadMedida"].Width = 120;
            dgvProductos.Columns["Precio"].Width = 80;
            dgvProductos.Columns["Id_Estado"].Visible = false;
            dgvProductos.Columns["Estado"].Width = 80;
        }

        public void ListarCategorias()
        {
            cboxCategoria.DataSource = logCategoria.Instancia.ListarUsuarios();
            cboxCategoria.DisplayMember = "Categoria"; // nombre de la categoria
            cboxCategoria.ValueMember = "Id_Categoria";
        }

        public void ListarUnidadesMedida()
        {
            cboxUnidadMedida.DataSource = logUnidadMedida.Instancia.ListarUnidadesMedida();
            cboxUnidadMedida.DisplayMember = "Unidad_Medida"; // nombre de la unidad de medida
            cboxUnidadMedida.ValueMember = "Id_UnidadMedida";
        }

        public void ListarEstadosDisponibilidadProducto()
        {
            cboxEstado.DataSource = logEstadoProducto.Instancia.ListarEstadosProducto();
            cboxEstado.DisplayMember = "Estado"; // nombre del estado
            cboxEstado.ValueMember = "Id_Estado";
        }

        public void limpiar()
        {
            txtId.Clear();
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            cboxCategoria.SelectedValue = 1;
            txtNumCodBarras.Clear();
            txtLabFabricante.Clear();
            cboxLabFabricante.SelectedValue = 1; // se puede quitar que primero se busca y luego se seleccion por id, es opcional y creo que optimo
            chbEsGenerico.Checked = false;
            chbNecesitaReceta.Checked = false;
            cboxUnidadMedida.SelectedValue = 1;
            txtPrecio.Clear();
            cboxEstado.SelectedValue = 1;
        }

        public void ElementosBloqueados()
        {
            txtNombreProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            cboxCategoria.Enabled = false;
            txtNumCodBarras.Enabled = false;
            txtLabFabricante.Enabled = false;
            btnBuscar.Enabled = false;
            cboxLabFabricante.Enabled = false;
            chbEsGenerico.Enabled = false;
            chbNecesitaReceta.Enabled = false;
            cboxUnidadMedida.Enabled = false;
            txtPrecio.Enabled = false;
            cboxEstado.Enabled = false;
        }
        public void ElementosActivos()
        {
            txtNombreProducto.Enabled = true;
            txtDescripcion.Enabled = true;
            cboxCategoria.Enabled = true;
            txtNumCodBarras.Enabled = true;
            txtLabFabricante.Enabled = true;
            btnBuscar.Enabled = true;
            cboxLabFabricante.Enabled = true;
            chbEsGenerico.Enabled = true;
            chbNecesitaReceta.Enabled = true;
            cboxUnidadMedida.Enabled = true;
            txtPrecio.Enabled = true;
            cboxEstado.Enabled = true;
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

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool ValidarDatosVacios()
        {
            if (txtNombreProducto.Text != string.Empty & txtDescripcion.Text != string.Empty & cboxLabFabricante.Text != string.Empty)
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
