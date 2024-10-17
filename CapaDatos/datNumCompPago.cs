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
    public class datNumCompPago
    {
        private readonly static datNumCompPago _instancia = new datNumCompPago();

        private datNumCompPago()
        { }

        public static datNumCompPago Instancia
        {
            get { return _instancia; }
        }

        public List<entNumCompPago> ListarNumeracionesComprobantesPago()
        {
            SqlCommand cmd = null;
            List<entNumCompPago> lista = new List<entNumCompPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarNumeracionCompPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entNumCompPago numCP = new entNumCompPago();
                    numCP.Id_NumCompPago = Convert.ToInt32(reader["id_NumeracionComprobantePago"]);
                    numCP.Id_ComprobantePago = Convert.ToInt32(reader["id_tipo_comprobante"]);
                    numCP.ComprobantePago = reader["tipo_comprobante"].ToString();
                    numCP.Id_Sucursal = Convert.ToInt32(reader["id_sucursal"]);
                    numCP.Sucursal = reader["sucursal"].ToString();
                    numCP.Serie = reader["serie"].ToString();
                    numCP.Correlativo = Convert.ToInt32(reader["correlativo"]);
                    lista.Add(numCP);
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

        public List<entNumCompPago> ListarSeriesComprobantePago_Numeracion(int id_sucursal)
        {
            SqlCommand cmd = null;
            List<entNumCompPago> lista = new List<entNumCompPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarSeriesCompPago_Numeracion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entNumCompPago numCP = new entNumCompPago();
                    numCP.Id_NumCompPago = Convert.ToInt32(reader["id_NumeracionComprobantePago"]);
                    numCP.Id_ComprobantePago = Convert.ToInt32(reader["id_tipo_comprobante"]);
                    numCP.ComprobantePago = reader["tipo_comprobante"].ToString();
                    numCP.Serie = reader["serie"].ToString();
                    lista.Add(numCP);
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
