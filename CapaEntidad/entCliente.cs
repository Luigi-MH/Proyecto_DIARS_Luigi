using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int Id_Cliente { get; set; }
        public int Id_TipoDocumento { get; set; }
        public string Tipo_Documento { get; set; }
        public string Documento { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Boolean Estado { get; set; }
    }
}
