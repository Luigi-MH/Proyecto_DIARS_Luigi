using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datVentas
    {
        private readonly static datVentas _instancia = new datVentas();

        private datVentas()
        { }

        public static datVentas Instancia
        {
            get { return _instancia; }
        }

    }
}
