using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPromocionProducto
    {
        private readonly static logPromocionProducto _instancia = new logPromocionProducto();

        private logPromocionProducto()
        { }

        public static logPromocionProducto Instancia
        {
            get { return _instancia; }
        }
    }
}
