using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        private readonly static logProducto _instancia = new logProducto();

        private logProducto()
        { }

        public static logProducto Instancia
        {
            get { return _instancia; }
        }

        public List<entProducto> ListarProductos()
        {
            return datProducto.Instancia.ListarProductos();
        }

        public Boolean AgregarProducto(entProducto prod)
        {
            return datProducto.Instancia.AgregarProducto(prod);
        }

        public Boolean ModificarProducto(entProducto prod)
        {
            return datProducto.Instancia.ModificarProducto(prod);
        }

        public List<entLabFabricante> BuscarLaboratorio(string labFafricante, string Id_LabFab)
        {
            return datProducto.Instancia.BuscarLaboratorio(labFafricante, Id_LabFab);
        }
    }
}
