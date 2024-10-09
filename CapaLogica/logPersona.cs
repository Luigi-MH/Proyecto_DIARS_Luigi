using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPersona
    {
        private readonly static logPersona _instancia = new logPersona();

        private logPersona()
        { }

        public static logPersona Instancia
        {
            get { return _instancia; }
        }

        public async Task<string> GET_DNI_Dato(string dni)
        {
            return await datPersona.Instancia.GET_DNI_Datos(dni);
        }
    }
}
