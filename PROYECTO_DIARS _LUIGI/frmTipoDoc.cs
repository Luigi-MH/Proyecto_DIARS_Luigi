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
    public partial class frmTipoDoc : Form
    {
        public frmTipoDoc()
        {
            InitializeComponent();
        }

        private void frmTipoDoc_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            txtTipoDoc.Enabled = false;
            ListarTiposDocumento();
            dgvTiposDocumento.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnAgregar, btnCancelar, btnModificar, btnNuevo, btnEditar, btnEliminar);
            limpiar();
            dgvTiposDocumento.Enabled = false;
            txtTipoDoc.Enabled = true;
            txtTipoDoc.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(btnModificar, btnCancelar, btnAgregar, btnNuevo, btnEditar, btnEliminar);
            txtTipoDoc.Enabled = true;
            txtTipoDoc.Focus();
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
                        entTipoDoc entTipDoc = new entTipoDoc();
                        entTipDoc.Id_TipoDoc = Convert.ToInt32(txtId.Text);
                        //logTipoDoc.Instancia.EliminarTipoDoc(entTipDoc);
                        MessageBox.Show("Aún no se implementa el eliminar", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error.." + ex);
                    }
                    MessageBox.Show("Se eliminó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTiposDocumento();
                }
                limpiar();
                txtTipoDoc.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione Tipo de Documento", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTipoDoc.Text != string.Empty)
            {
                deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                try
                {
                    entTipoDoc entTipDoc = new entTipoDoc();
                    entTipDoc.Documento = txtTipoDoc.Text.Trim();
                    logTipoDoc.Instancia.AgregarTipoDoc(entTipDoc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                MessageBox.Show("Se agrego con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                dgvTiposDocumento.Enabled = true;
                txtTipoDoc.Enabled = false;
                ListarTiposDocumento();
            }
            else
            {
                MessageBox.Show("Ingrese Tipo de Documento", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTipoDoc.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (txtTipoDoc.Text != string.Empty)
                {
                    DialogResult result = MessageBox.Show("Esta seguro de Modificar", "Aviso del Sitema Sys-MH", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
                        try
                        {
                            entTipoDoc entTipDoc = new entTipoDoc();
                            entTipDoc.Id_TipoDoc = Convert.ToInt32(txtId.Text);
                            entTipDoc.Documento = txtTipoDoc.Text.Trim();
                            logTipoDoc.Instancia.ModificaTipoDoc(entTipDoc);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error.." + ex);
                        }
                        MessageBox.Show("Se modificó con exito", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        ListarTiposDocumento();
                    }
                    else
                    {
                        txtTipoDoc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Edite Tipo de Documento", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipoDoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione Tipo de Documento", "Aviso del Sitema Sys-MH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBtn(btnNuevo, btnEditar, btnEliminar, btnAgregar, btnModificar, btnCancelar);
            limpiar();
            dgvTiposDocumento.Enabled = true;
            txtTipoDoc.Enabled = false;
        }
        public void ListarTiposDocumento()
        {
            dgvTiposDocumento.DataSource = logTipoDoc.Instancia.ListarTiposDocumento_Todo();
            dgvTiposDocumento.Columns["Id_TipoDoc"].Width = 90;
            dgvTiposDocumento.Columns["Documento"].Width = 140;
        }
        public void limpiar()
        {
            txtTipoDoc.Clear();
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

        private void dgvTiposDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTiposDocumento.CurrentRow.Cells["Id_TipoDoc"].Value.ToString();
            txtTipoDoc.Text = dgvTiposDocumento.CurrentRow.Cells["Documento"].Value.ToString();
        }
    }
}
