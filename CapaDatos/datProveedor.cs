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
    public class datProveedor
    {
        private readonly static datProveedor _instancia = new datProveedor();

        private datProveedor()
        { }

        public static datProveedor Instancia
        {
            get { return _instancia; }
        }

        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProveedor prov = new entProveedor();
                    prov.Id_Proveedor = Convert.ToInt32(reader["id_Proveedor"]);
                    prov.RUC = reader["ruc_Proveedor"].ToString();
                    prov.RazonSocial = reader["razon_social"].ToString();
                    prov.Ciudad = reader["ciudad"].ToString();
                    prov.Telefono = reader["telefono"].ToString();
                    prov.Direccion = reader["direccion"].ToString();
                    prov.Correo = reader["correo"].ToString();
                    prov.Representate = reader["nombre_representante"].ToString();
                    prov.Telefono_Rep = reader["telefono_representante"].ToString();
                    prov.Estado = Convert.ToBoolean(reader["estado"]);
                    lista.Add(prov);
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

        public Boolean AgregarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ruc_proveedor", proveedor.RUC);
                cmd.Parameters.AddWithValue("@razon_social", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@ciudad", proveedor.Ciudad);
                cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@nombre_rep", proveedor.Representate);
                cmd.Parameters.AddWithValue("@telefono_rep", proveedor.Telefono_Rep);
                cmd.Parameters.AddWithValue("@estado", proveedor.Estado);
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

        public Boolean ModificarProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", proveedor.Id_Proveedor);
                cmd.Parameters.AddWithValue("@ruc_proveedor", proveedor.RUC);
                cmd.Parameters.AddWithValue("@razon_social", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@ciudad", proveedor.Ciudad);
                cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@nombre_rep", proveedor.Representate);
                cmd.Parameters.AddWithValue("@telefono_rep", proveedor.Telefono_Rep);
                cmd.Parameters.AddWithValue("@estado", proveedor.Estado);
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

        public Boolean EliminarProveedor(int id_proveedor)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
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
            return elimina;
        }
    }
}
