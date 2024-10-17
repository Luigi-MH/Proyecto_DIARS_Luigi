using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetodoPago
    {
        private readonly static logMetodoPago _instancia = new logMetodoPago();

        private logMetodoPago()
        { }

        public static logMetodoPago Instancia
        {
            get { return _instancia; }
        }

        public List<entMetodoPago> ListarMetododosPago()
        {
            return datMetodoPago.Instancia.ListarMetododosPago();
        }
    }
}
