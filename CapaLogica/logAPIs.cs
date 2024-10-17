using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logAPIs
    {
        private readonly static logAPIs _instancia = new logAPIs();

        private logAPIs()
        { }

        public static logAPIs Instancia
        {
            get { return _instancia; }
        }

        public async Task<string> GET_DNI_Dato(string dni)
        {
            return await datAPIs.Instancia.GET_DNI_Datos(dni);
        }

        public async Task<string> GET_RUC_Datos(string ruc)
        {
            return await datAPIs.Instancia.GET_RUC_Datos(ruc);
        }
    }
}
