using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCargos
    {
        private readonly static logCargos _instancia = new logCargos();

        private logCargos()
        { }

        public static logCargos Instancia
        {
            get { return _instancia; }
        }

        public List<entCargo> ListarCargos()
        {
            return datCargo.Instancia.ListarCargos();
        }

        public Boolean AgregarCargo(entCargo cargo)
        {
            return datCargo.Instancia.AgregarCargo(cargo);
        }

        public Boolean ModificarCargo(entCargo cargo)
        {
            return datCargo.Instancia.ModificarCargo(cargo);
        }
    }
}
