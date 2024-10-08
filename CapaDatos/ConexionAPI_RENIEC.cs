using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class ConexionAPI_RENIEC
    {
        private readonly static ConexionAPI_RENIEC _instancia = new ConexionAPI_RENIEC();

        private ConexionAPI_RENIEC()
        { }

        public static ConexionAPI_RENIEC Instancia
        {
            get { return _instancia; }
        }

        public SqlConnection ConectarAPI_RENIEC()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LUIGI\\SQLEXPRESS_LUIGI; Initial Catalog = BD_MHL_Farmacia_Angel;" + "User ID=sa; Password=0100110001001001Luigi.";
            //"Integrated Security=true";

            return conexion;
        }
    }
}
