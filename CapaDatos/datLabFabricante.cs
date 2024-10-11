using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datLabFabricante
    {
        private readonly static datLabFabricante _instancia = new datLabFabricante();

        private datLabFabricante()
        { }

        public static datLabFabricante Instancia
        {
            get { return _instancia; }
        }

        public List<entLabFabricante> ListarLaboratoriosFabricantes()
        {
            SqlCommand cmd = null;
            List<entLabFabricante> lista = new List<entLabFabricante>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarFabricantes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entLabFabricante labFabricante = new entLabFabricante();
                    labFabricante.Id_LabFabricante = Convert.ToInt32(reader["id_LabFab"]);
                    labFabricante.LaboratorioFabricante = reader["fafricante"].ToString();
                    labFabricante.Direccion = reader["direccion"].ToString();
                    labFabricante.Telefono = reader["telefono"].ToString();
                    labFabricante.Estado = Convert.ToBoolean(reader["estado"]);
                    lista.Add(labFabricante);
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

        //public Boolean AgregarUsuario(entUsuario usuario)
        //{
        //    SqlCommand cmd = null;
        //    Boolean inserta = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spAgregarUsuario", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
        //        cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
        //        cmd.Parameters.AddWithValue("@id_rol", usuario.Id_Rol);
        //        cmd.Parameters.AddWithValue("@id_empleado", usuario.Id_Empleado);
        //        cmd.Parameters.AddWithValue("@fecha_creacion", usuario.FechaCreacion);
        //        cmd.Parameters.AddWithValue("@estado", usuario.Estado);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            inserta = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        cmd.Connection.Close();
        //    }
        //    return inserta;
        //}

        //public Boolean ModificarUsuario(entUsuario usuario)
        //{
        //    SqlCommand cmd = null;
        //    Boolean edita = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spModificarUsuario", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_Usuario);
        //        cmd.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
        //        cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
        //        cmd.Parameters.AddWithValue("@id_rol", usuario.Id_Rol);
        //        cmd.Parameters.AddWithValue("@id_empleado", usuario.Id_Empleado);
        //        cmd.Parameters.AddWithValue("@fecha_creacion", usuario.FechaCreacion);
        //        cmd.Parameters.AddWithValue("@estado", usuario.Estado);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            edita = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally
        //    {
        //        cmd.Connection.Close();
        //    }
        //    return edita;
        //}
    }
}
