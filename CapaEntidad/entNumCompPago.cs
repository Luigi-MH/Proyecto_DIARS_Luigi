using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entNumCompPago
    {
        public int Id_NumCompPago { get; set; }
        public int Id_ComprobantePago { get; set; }
        public string ComprobantePago { get; set; }
        public int Id_Sucursal { get; set; }
        public string Sucursal { get; set; }
        public string Serie {  get; set; }
        public int Correlativo { get; set; }
    }
}
