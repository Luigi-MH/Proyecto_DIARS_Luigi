using CapaEntidad;
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
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCargo.Enabled = false; // gruopo de los elemento(heramientas) inabilitadas
            ListarCargos();
            dgvCargos.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvCargos.Enabled = false;
            txtCargo.Enabled = true;
            txtCargo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            txtCargo.Enabled = true;
            txtCargo.Focus();
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
                        entCargo entCargo = new entCargo();
                        entCargo.Id_Cargo = Convert.ToInt32(txtId.Text);
                        //logCargos.Instancia.EliminarCargo(entCargo);
                        MessageBox.Show("Aún no se implementa el eliminar", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error.." + ex);
                    }
                    MessageBox.Show("Se eliminó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarCargos();
                }
                limpiar();
                txtCargo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione Cargo", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text != string.Empty)
            {
                deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                try
                {
                    entCargo entCargo = new entCargo();
                    entCargo.Cargo = txtCargo.Text.Trim();
                    logCargos.Instancia.AgregarCargo(entCargo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                dgvCargos.Enabled = true;
                txtCargo.Enabled = false;
                ListarCargos();
            }
            else
            {
                MessageBox.Show("Ingrese Cargo", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (txtCargo.Text != string.Empty)
                {
                    DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                        try
                        {
                            entCargo entCargo = new entCargo();
                            entCargo.Id_Cargo = Convert.ToInt32(txtId.Text);
                            entCargo.Cargo = txtCargo.Text.Trim();
                            logCargos.Instancia.ModificarCargo(entCargo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error.." + ex);
                        }
                        MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        ListarCargos();
                    }
                    else
                    {
                        txtCargo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Edite Cargo", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCargo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione Cargo", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvCargos.Enabled = true;
            txtCargo.Enabled = false;
        }

        public void ListarCargos()
        {
            dgvCargos.DataSource = logCargos.Instancia.ListarCargos();
            dgvCargos.Columns["Id_Cargo"].Width = 90;
            dgvCargos.Columns["Cargo"].Width = 140;
        }
        public void limpiar()
        {
            txtCargo.Clear();
            txtId.Clear();
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

        private void dgvCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCargos.CurrentRow.Cells["Id_Cargo"].Value.ToString();
            txtCargo.Text = dgvCargos.CurrentRow.Cells["Cargo"].Value.ToString();
        }
    }
}
