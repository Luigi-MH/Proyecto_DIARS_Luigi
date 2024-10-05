using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEmpleados
    {
        private readonly static datEmpleados _instancia = new datEmpleados();

        private datEmpleados()
        { }

        public static datEmpleados Instancia
        {
            get { return _instancia; }
        }
    }
}
