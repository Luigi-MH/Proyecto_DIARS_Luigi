using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUsuario
    {
        private readonly static logUsuario _instancia = new logUsuario();

        private logUsuario()
        { }

        public static logUsuario Instancia
        {
            get { return _instancia; }
        }

        public List<entUsuario> ListarUsuarios()
        {
            return datUsuario.Instancia.ListarUsuarios();
        }

    }
}
