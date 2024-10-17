using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datPromocionProducto
    {
        private readonly static datPromocionProducto _instancia = new datPromocionProducto();

        private datPromocionProducto()
        { }

        public static datPromocionProducto Instancia
        {
            get { return _instancia; }
        }
    }
}
