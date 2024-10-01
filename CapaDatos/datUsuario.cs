using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datUsuario
    {
        private readonly static datUsuario _instancia = new datUsuario();

        private datUsuario()
        { }

        public static datUsuario Instancia
        {
            get { return _instancia; }
        }

        public List<entUsuario> ListarUsuarios()
        {
            SqlCommand cmd = null;
            List<entUsuario> lista = new List<entUsuario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entUsuario user = new entUsuario();
                    user.IdUsuario = Convert.ToInt32(reader["id_Usuario"]);
                    user.NombreUsuario = reader["nombre_usuario"].ToString();
                    user.Contraseña = reader["contraseña"].ToString();
                    user.IdRol = Convert.ToInt32(reader["id_rol"]);
                    user.Rol = reader["rol"].ToString();
                    user.IdEmpleado = Convert.ToInt32(reader["dni_empleado"]);
                    user.ApellidoEmpleado = reader["apellidos"].ToString();
                    user.NombreEmpleado = reader["nombres"].ToString();
                    user.Estado = Convert.ToBoolean(reader["estado"]);
                    lista.Add(user);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
