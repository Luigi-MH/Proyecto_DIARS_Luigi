using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logNumCompPago
    {
        private readonly static logNumCompPago _instancia = new logNumCompPago();

        private logNumCompPago()
        { }

        public static logNumCompPago Instancia
        {
            get { return _instancia; }
        }

        public List<entNumCompPago> ListarNumeracionesComprobantesPago()
        {
            return datNumCompPago.Instancia.ListarNumeracionesComprobantesPago();
        }

        public List<entNumCompPago> ListarSeriesComprobantePago_Numeracion(int id_sucursal)
        {
            return datNumCompPago.Instancia.ListarSeriesComprobantePago_Numeracion(id_sucursal);
        }
    }
}
