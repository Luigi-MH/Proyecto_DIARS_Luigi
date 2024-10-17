using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoComPago
    {
        private readonly static logTipoComPago _instancia = new logTipoComPago();

        private logTipoComPago()
        { }

        public static logTipoComPago Instancia
        {
            get { return _instancia; }
        }

        public List<entTipoComPago> ListarTiposComPago()
        {
            return datTipoComPago.Instancia.ListarTiposComPago();
        }
    }
}
