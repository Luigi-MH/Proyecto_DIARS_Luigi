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
    public class datTipoDoc
    {
        private readonly static datTipoDoc _instancia = new datTipoDoc();

        private datTipoDoc()
        { }

        public static datTipoDoc Instancia
        {
            get { return _instancia; }
        }

        public List<entTipoDoc> ListarTipoDoc()
        {
            SqlCommand cmd = null;
            List<entTipoDoc> lista = new List<entTipoDoc>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTiposDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entTipoDoc tipoDoc = new entTipoDoc();
                    tipoDoc.Id_TipoDoc = Convert.ToInt32(reader["id_TipoDocumento"]);
                    tipoDoc.Documento = reader["tipo_documento"].ToString();
                    lista.Add(tipoDoc);
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

        public List<entTipoDoc> ListarTiposDocumento_Todo()
        {
            SqlCommand cmd = null;
            List<entTipoDoc> lista = new List<entTipoDoc>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTiposDocumento_Todos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entTipoDoc tipoDoc = new entTipoDoc();
                    tipoDoc.Id_TipoDoc = Convert.ToInt32(reader["id_TipoDocumento"]);
                    tipoDoc.Documento = reader["tipo_documento"].ToString();
                    lista.Add(tipoDoc);
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

        public Boolean AgregarTipoDoc(entTipoDoc tipoDoc)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarTiposDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_documento", tipoDoc.Documento);
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

        public Boolean ModificaTipoDoc(entTipoDoc tipoDoc)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarTiposDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_doc", tipoDoc.Id_TipoDoc);
                cmd.Parameters.AddWithValue("@tipo_documento", tipoDoc.Documento);
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
