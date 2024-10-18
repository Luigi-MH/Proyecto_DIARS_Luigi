using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int Id_Venta { get; set; }
        public int Id_TipoComprobante { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie {  get; set; }
        public string Correlativo { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_TipoDoc {  get; set; }
        public string TipoDoc { get; set; }
        public string Documento { get; set; }
        public string Cliente { get; set; }
        public int Id_MetodoPago { get; set; }
        public string MedotoPago { get; set; }
        public int Id_Usuario { get; set; }
        public string Usuario { get; set; }
        public int Id_Caja { get; set; }
        public string Caja { get; set; }
        public int Id_SesionCaja { get; set; }
        public decimal SubTotal { get; set; }
        public decimal IGV { get; set; }
        public decimal Total { get; set; } 
        public DateTime Fecha {  get; set; }
        public string Notas { get; set; }
        public int Id_Estado { get; set; }
        public string Estado { get; set; }
        public int? Id_EstadoSUNAT { get; set; }
    }
}
