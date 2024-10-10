using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleados
    {
        public int Id_Empleado { get; set; }
        public int Id_TipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDoc { get; set; }
        public string NombreCompleto { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[] FotoEmpleado { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int Id_Cargo { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public Boolean Estado { get; set; }
    }
}
