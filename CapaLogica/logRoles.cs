using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRoles
    {
        private readonly static logRoles _instancia = new logRoles();

        private logRoles()
        { }

        public static logRoles Instancia
        {
            get { return _instancia; }
        }

        public List<entRoles> ListarRoles()
        {
            return datRoles.Instancia.ListarRoles();
        }
    }
}
