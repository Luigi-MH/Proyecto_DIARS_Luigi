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

        public Boolean AgregarUsuario(entUsuario usuario)
        {
            return datUsuario.Instancia.AgregarUsuario(usuario);
        }

        public Boolean ModificarUsuario(entUsuario usuario)
        {
            return datUsuario.Instancia.ModificarUsuario(usuario);
        }

        public List<entEmpleados> BuscarEmpleado(string apellidos, string documeto)
        {
            return datUsuario.Instancia.BuscarEmpleado(apellidos,documeto);
        }
    }
}
