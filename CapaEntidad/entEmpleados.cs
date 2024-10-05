using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleados
    {
        public int Id { get; set; }
        public int Id_TipoDocumento { get; set; }
        public string NumDoc { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //public FotoEmpleado aun nose el tipo de dato
        public DateTime FechaContratacion { get; set; }
        public int Id_Cargo { get; set; }
        public double Salario { get; set; }
        public Boolean Estado { get; set; }

        // acaban los campos que tmb se requieren 

    }
}
