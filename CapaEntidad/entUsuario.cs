using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int Id_Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Id_Rol { get; set; }
        public string Rol { get; set; }
        public int Id_Empleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
    }
}
