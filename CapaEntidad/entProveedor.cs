using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int Id_Proveedor { get; set; }
        public string RUC {  get; set; }
        public string RazonSocial { get; set; }
        public string Ciudad {  get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Representate { get; set; }
        public string Telefono_Rep {  get; set; }
        public Boolean Estado { get; set; }
    }
}
