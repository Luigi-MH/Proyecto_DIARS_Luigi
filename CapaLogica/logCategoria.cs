using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoria
    {
        private readonly static logCategoria _instancia = new logCategoria();

        private logCategoria()
        { }

        public static logCategoria Instancia
        {
            get { return _instancia; }
        }

        public List<entCategoria> ListarUsuarios()
        {
            return datCategoria.Instancia.ListarUsuarios();
        }
    }
}
