using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        private readonly static logProveedor _instancia = new logProveedor();

        private logProveedor()
        { }

        public static logProveedor Instancia
        {
            get { return _instancia; }
        }

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        public Boolean AgregarProveedor(entProveedor proveedor)
        {
            return datProveedor.Instancia.AgregarProveedor(proveedor);
        }

        public Boolean ModificarProveedor(entProveedor proveedor)
        {
            return datProveedor.Instancia.ModificarProveedor(proveedor);
        }

        public Boolean EliminarProveedor(int id_proveedor)
        {
            return datProveedor.Instancia.EliminarProveedor(id_proveedor);
        }
    }
}
