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
    public class datCliente
    {
        private readonly static datCliente _instancia = new datCliente();

        private datCliente()
        { }

        public static datCliente Instancia
        {
            get { return _instancia; }
        }

        public List<entCliente> ListarClientes()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entCliente cliente = new entCliente();
                    cliente.Id_Cliente = Convert.ToInt32(reader["id_Cliente"]);
                    cliente.Id_TipoDocumento = Convert.ToInt32(reader["id_tipo_documento"]);
                    cliente.Tipo_Documento = reader["tipo_documento"].ToString();
                    cliente.Documento = reader["numero_doc"].ToString();
                    cliente.Cliente = reader["cliente"].ToString();
                    cliente.Direccion = reader["direccion"].ToString();
                    cliente.Telefono = reader["telefono"].ToString();
                    cliente.Estado = Convert.ToBoolean(reader["estado"]);
                    lista.Add(cliente);
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

        public Boolean AgregarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_documento", cliente.Id_TipoDocumento);
                cmd.Parameters.AddWithValue("@num_doc", cliente.Documento);
                cmd.Parameters.AddWithValue("@cliente", cliente.Cliente);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);
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

        public Boolean ModificarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Cliente", cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@id_tipo_documento", cliente.Id_TipoDocumento);
                cmd.Parameters.AddWithValue("@num_doc", cliente.Documento);
                cmd.Parameters.AddWithValue("@cliente", cliente.Cliente);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);
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
    }
}
