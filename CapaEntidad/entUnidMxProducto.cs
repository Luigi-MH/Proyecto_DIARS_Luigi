using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUnidMxProducto
    {
        public int Id_UMxP_id {  get; set; }
        public int Id_Producto { get; set; }
        public string Producto { get; set; }
        public int Id_UM_Producto { get; set; }
        public string UM_Producto { get; set; }
        public decimal Precio_Prod { get; set; }
        public int Id_UnidadMedida { get; set; }
        public string Unidad_Medida { get; set; }
        public int Cantidad_Equivalente { get; set; }
        public decimal Precio_Equivalente { get; set; }
    }
}
