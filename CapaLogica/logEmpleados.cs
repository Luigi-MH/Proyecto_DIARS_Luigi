using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEmpleados
    {
        private readonly static logEmpleados _instancia = new logEmpleados();

        private logEmpleados()
        { }

        public static logEmpleados Instancia
        {
            get { return _instancia; }
        }

        public List<entEmpleados> ListarEmpleados()
        {
            return datEmpleados.Instancia.ListarEmpleados();
        }

        public Boolean AgregarEmpleado(entEmpleados empleado)
        {
            return datEmpleados.Instancia.AgregarEmpleado(empleado);
        }

        public Boolean ModificarEmpleado(entEmpleados empleado)
        {
            return datEmpleados.Instancia.ModificarEmpleado(empleado);
        }
    }
}
