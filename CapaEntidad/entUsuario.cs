using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdRol { get; set; }
        public int IdEmpleado { get; set; }
        public bool Estado { get; set; }

        // Propiedades para las relaciones con otras tablas
        public string Rol { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
    }
}
