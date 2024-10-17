using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logVentas
    {
        private readonly static logVentas _instancia = new logVentas();

        private logVentas()
        { }

        public static logVentas Instancia
        {
            get { return _instancia; }
        }

        public List<entVenta> ListarVentas()
        {
            return datVentas.Instancia.ListarVentas();
        }

        public int AgregarVenta(entVenta venta)
        {
            return datVentas.Instancia.AgregarVenta(venta);
        }

        public List<entDetalleVenta> ListarDetallesVenta(int Id_Venta)
        {
            return datVentas.Instancia.ListarDetallesVenta(Id_Venta);
        }

        public Boolean AgregarDetallesVenta(entDetalleVenta detVenta)
        {
            return datVentas.Instancia.AgregarDetallesVenta(detVenta);
        }

        public List<entCliente> BuscarCliente(string documeto, string nombre)
        {
            return datVentas.Instancia.BuscarCliente(documeto, nombre);
        }

        public List<entProducto> BuscarProducto_Nombre(string nombre)
        {
            return datVentas.Instancia.BuscarProducto_Nombre(nombre);
        }

        public List<entProducto> BuscarProducto_Id(int id_producto)
        {
            return datVentas.Instancia.BuscarProducto_Id(id_producto);
        }

        public List<entProducto> BuscarProducto_CodigoBarras(string codBarras)
        {
            return datVentas.Instancia.BuscarProducto_CodigoBarras(codBarras);
        }

        public List<entUnidMxProducto> BuscarUnidadesMP_Producto(int id_producto)
        {
            return datVentas.Instancia.BuscarUnidadesMP_Producto(id_producto);
        }

        public List<entPromocionProducto> BuscarPromocionProducto(int id_producto)
        {
            return datVentas.Instancia.BuscarPromocionProducto(id_producto);
        }
    }
}
