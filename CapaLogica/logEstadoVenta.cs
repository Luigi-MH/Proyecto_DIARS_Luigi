using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEstadoVenta
    {
        private readonly static logEstadoVenta _instancia = new logEstadoVenta();

        private logEstadoVenta()
        { }

        public static logEstadoVenta Instancia
        {
            get { return _instancia; }
        }

        public List<entEstadoVenta> ListarEstadosVenta()
        {
            return datEstadosVenta.Instancia.ListarEstadosVenta();
        }
    }
}
