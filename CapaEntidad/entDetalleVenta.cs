using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleVenta
    {
        public int Id_DetVenta { get; set; }
        public int Id_Venta { get; set; }
        public int Id_Producto { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Id_UnidadMedida { get; set; }
        public string UnidadMedida { get; set;}
        public decimal Precio { get; set; }
        public int Id_Promocion { get; set; }
        public int Descuento { get; set; }
        public decimal SubTotalDet { get; set; }
    }
}
