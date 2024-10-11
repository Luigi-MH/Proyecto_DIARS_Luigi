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
    public class datCategoria
    {
        private readonly static datCategoria _instancia = new datCategoria();

        private datCategoria()
        { }

        public static datCategoria Instancia
        {
            get { return _instancia; }
        }

        public List<entCategoria> ListarUsuarios()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entCategoria categoria = new entCategoria();
                    categoria.Id_Categoria = Convert.ToInt32(reader["id_Categoria"]);
                    categoria.Categoria = reader["categoria"].ToString();
                    lista.Add(categoria);
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
