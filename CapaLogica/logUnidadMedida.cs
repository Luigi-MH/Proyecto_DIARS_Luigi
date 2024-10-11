using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUnidadMedida
    {
        private readonly static logUnidadMedida _instancia = new logUnidadMedida();

        private logUnidadMedida()
        { }

        public static logUnidadMedida Instancia
        {
            get { return _instancia; }
        }

        public List<entUnidadMedida> ListarUnidadesMedida()
        {
            return datUnidadMedida.Instancia.ListarUnidadesMedida();
        }
    }
}
