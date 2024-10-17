using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPromocionProducto
    {
        public int Id_PromocionProducto { get; set; }
        public int Id_Promocion {  get; set; }
        public string Descripcion_Promocion_Nombre { get; set; }
        public double Descuento {  get; set; }
        public int Id_Producto { get; set; }
        public string NombreProducto { get; set; }
    }
}
