using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class Conexion
    {
        private readonly static Conexion _instancia = new Conexion();

        private Conexion()
        { }

        public static Conexion Instancia
        {
            get { return _instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-L1RS5D2\\SQLEXPRESS; Initial Catalog = BD_MHL_Farmacia_Angel;" + "User ID=sa; Password=0100110001001001Luigi.";
            //"Integrated Security=true";

            return conexion;
        }
    }
}
