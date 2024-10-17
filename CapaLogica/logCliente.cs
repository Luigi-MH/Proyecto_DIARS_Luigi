using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        private readonly static logCliente _instancia = new logCliente();

        private logCliente()
        { }

        public static logCliente Instancia
        {
            get { return _instancia; }
        }

        public List<entCliente> ListarClientes()
        {
            return datCliente.Instancia.ListarClientes();
        }

        public Boolean AgregarCliente(entCliente cliente)
        {
            return datCliente.Instancia.AgregarCliente(cliente);
        }

        public Boolean ModificarCliente(entCliente cliente)
        {
            return datCliente.Instancia.ModificarCliente(cliente);
        }
    }
}
