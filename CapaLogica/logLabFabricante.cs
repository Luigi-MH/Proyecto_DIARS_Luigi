using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logLabFabricante
    {
        private readonly static logLabFabricante _instancia = new logLabFabricante();

        private logLabFabricante()
        { }

        public static logLabFabricante Instancia
        {
            get { return _instancia; }
        }

        public List<entLabFabricante> ListarLaboratoriosFabricantes()
        {
            return datLabFabricante.Instancia.ListarLaboratoriosFabricantes();
        }
    }
}
