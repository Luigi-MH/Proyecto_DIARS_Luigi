using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logVentas
    {
        private readonly static logVentas _instancia = new logVentas();

        private logVentas()
        { }

        public static logVentas Instancia
        {
            get { return _instancia; }
        }

    }
}
