using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int Id_Producto { get; set; }
        public string Nombre { get; set; }
        public byte[] Foto_Producto { get; set; }
        public string Descripcion { get; set; }
        public int Id_Categoria { get; set; }
        public string Categoria { get; set; }
        public int Id_LabFabricante { get; set; }
        public string Laboratorio { get; set; }
        public string  CodigoBarras { get; set; }
        public Boolean Requiere_Receta {  get; set; }
        public Boolean Es_Generio { get; set; }
        public int Id_UnidadMendida { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Precio { get; set; }
        public int Id_Estado { get; set; }
        public string Estado { get; set; }
    }
}
