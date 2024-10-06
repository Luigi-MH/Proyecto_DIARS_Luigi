using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_DIARS__LUIGI
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            //ElementosBloqueados(); // grupo de los elemento(heramientas) inabilitadas
            //ListarEmpleados();
            ListarTiposDocumentos();
            ListarCargos();
            dgvEmpleados.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = logCargos.Instancia.ListarCargos();
            dgvEmpleados.Columns["Id_Cargo"].Width = 90;
            dgvEmpleados.Columns["Cargo"].Width = 140;
        }

        public void ListarTiposDocumentos()
        {
            cboxTipoDoc.DataSource = logTipoDoc.Instancia.ListarTipoDoc();
            cboxTipoDoc.DisplayMember = "Documento"; // Muestra el nombre del cargo
            cboxTipoDoc.ValueMember = "Id_TipoDoc";
        }

        public void ListarCargos()
        {
            cboxCargo.DataSource = logCargos.Instancia.ListarCargos();
            cboxCargo.DisplayMember = "Cargo"; // Muestra el nombre del cargo
            cboxCargo.ValueMember = "Id_Cargo";
        }

        public void limpiar()
        {
            txtId.Clear();
            cboxTipoDoc.Enabled = false;
            txtDocEmpleado.Clear();
            btnBuscar.Enabled = false;
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumero.Clear();
            dtpFehaNacimiento.Enabled = false;
            btnSeleccionarFoto.Enabled = false;
            txtCorreo.Clear();
            cboxCargo.Enabled = false;
            dtpFechaContratacionE.Enabled = false;
            txtSalario.Clear();
            rdActivo.Enabled = false;
            rdInactivo.Enabled = false;
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
            MetodoFoto_Byte_memoryStream_Image(pbFoto, dgvEmpleados.CurrentRow.Cells["FotoEmpleado"].Value as byte[]);
            txtCorreo.Text = dgvEmpleados.CurrentRow.Cells["Correo"].Value.ToString();
            cboxCargo.SelectedValue = dgvEmpleados.CurrentRow.Cells["Id_Cargo"].Value;
            dtpFechaContratacionE.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["FechaContratacion"].Value);
            txtSalario.Text = dgvEmpleados.CurrentRow.Cells["Salario"].Value.ToString();
            //cboxCargo.SelectedItem = dgvEmpleados.CurrentRow.Cells["NomCargo"].Value.ToString();
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

        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionarFoto = new OpenFileDialog();
            ofdSeleccionarFoto.Filter = "Imagenes(*.jpg)|*.jpg"; //Imagenes(*.png)|*.png|
            ofdSeleccionarFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionarFoto.Title = "Seleccionar Foto";
            
            if(ofdSeleccionarFoto.ShowDialog() == DialogResult.OK )
            {
                pbFoto.Image = Image.FromFile(ofdSeleccionarFoto.FileName);
            }
        }

        public void MetodoFoto_Byte_memoryStream_Image(PictureBox pbFotoEmpleado, byte[] fotoBytes)
        {
            using (MemoryStream ms = new MemoryStream(fotoBytes))
            {
                pbFotoEmpleado.Image = Image.FromStream(ms);
            }
        }

        public byte[] ComprimirImagen(Image image, long calidad)
        {
            // Configurar la compresión
            ImageCodecInfo jpegCodec = GetEncoderInfo(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder calidadEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters encoderParams = new EncoderParameters(1);

            // Asignar la calidad de la compresión (entre 0 y 100)
            encoderParams.Param[0] = new EncoderParameter(calidadEncoder, calidad);

            using (MemoryStream ms = new MemoryStream())
            {
                // Guardar la imagen comprimida en el MemoryStream
                image.Save(ms, jpegCodec, encoderParams);
                return ms.ToArray(); // Convertir la imagen a array de bytes
            }
        }

        private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            // Obtener el codec del formato de imagen deseado (JPEG)
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
