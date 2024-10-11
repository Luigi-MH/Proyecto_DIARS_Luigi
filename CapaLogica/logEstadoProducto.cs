using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEstadoProducto
    {
        private readonly static logEstadoProducto _instancia = new logEstadoProducto();

        private logEstadoProducto()
        { }

        public static logEstadoProducto Instancia
        {
            get { return _instancia; }
        }

        public List<entEstadoProducto> ListarEstadosProducto()
        {
            return datEstadosProducto.Instancia.ListarEstadosProducto();
        }
    }
}
