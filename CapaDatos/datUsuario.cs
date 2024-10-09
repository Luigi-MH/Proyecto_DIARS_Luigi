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
                    user.Id_Usuario = Convert.ToInt32(reader["id_Usuario"]);
                    user.NombreUsuario = reader["nombre_usuario"].ToString();
                    user.Contraseña = reader["contraseña"].ToString();
                    user.Id_Rol = Convert.ToInt32(reader["id_rol"]);
                    user.Rol = reader["rol"].ToString();
                    user.Id_Empleado = Convert.ToInt32(reader["dni_empleado"]);
                    user.ApellidoEmpleado = reader["apellidos"].ToString();
                    user.NombreEmpleado = reader["nombres"].ToString();
                    user.FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"]);
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

        public Boolean AgregarUsuario(entUsuario usuario)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@id_rol", usuario.Id_Rol);
                cmd.Parameters.AddWithValue("@id_empleado", usuario.Id_Empleado);
                cmd.Parameters.AddWithValue("@fecha_creacion", usuario.FechaCreacion);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
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
            return inserta;
        }

        public Boolean ModificarUsuario(entUsuario usuario)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_Usuario);
                cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@id_rol", usuario.Id_Rol);
                cmd.Parameters.AddWithValue("@id_empleado", usuario.Id_Empleado);
                cmd.Parameters.AddWithValue("@fecha_creacion", usuario.FechaCreacion);
                cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
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
            return edita;
        }

        public List<entEmpleados> BuscarEmpleado(string apellidos, string documeto)
        {
            SqlCommand cmd = null;
            List<entEmpleados> lista = new List<entEmpleados>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarEmpleadoUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                cmd.Parameters.AddWithValue("@documento", documeto);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entEmpleados empleado = new entEmpleados();
                    empleado.Id_Empleado = Convert.ToInt32(reader["id_Empleado"]);
                    empleado.Nombres = reader["nombres"].ToString();
                    empleado.Apellidos = reader["apellidos"].ToString();
                    lista.Add(empleado);
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
