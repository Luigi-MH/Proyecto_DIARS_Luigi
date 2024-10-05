using CapaDatos;
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
    }
}
