using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUnidMxProducto
    {
        private readonly static logUnidMxProducto _instancia = new logUnidMxProducto();

        private logUnidMxProducto()
        { }

        public static logUnidMxProducto Instancia
        {
            get { return _instancia; }
        }

        public List<entUnidMxProducto> ListarUnidMedXProducto()
        {
            return datUnidMxProducto.Instancia.ListarUnidMedXProducto();
        }

        public Boolean AgregarUnidMedXProducto(entUnidMxProducto ent_upm)
        {
            return datUnidMxProducto.Instancia.AgregarUnidMedXProducto(ent_upm);
        }

        public Boolean ModificarUnidMedXProducto(entUnidMxProducto ent_upm)
        {
            return datUnidMxProducto.Instancia.ModificarUnidMedXProducto(ent_upm);
        }

        public Boolean EliminarUnidMedXProducto(entUnidMxProducto upm)
        {
            return datUnidMxProducto.Instancia.EliminarUnidMedXProducto(upm);
        }

        public Boolean EliminarUnidMedXProducto_Cambio_Unidad_Base(int id_producto)
        {
            return datUnidMxProducto.Instancia.EliminarUnidMedXProducto_Cambio_Unidad_Base(id_producto);
        }

        public List<entProducto> BuscarProducto_Precio_UMxP(string id_producto, string nombre)
        {
            return datUnidMxProducto.Instancia.BuscarProducto_Precio_UMxP(id_producto, nombre);
        }
    }
}
