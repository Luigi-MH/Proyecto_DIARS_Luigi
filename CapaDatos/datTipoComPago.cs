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
    public class datTipoComPago
    {
        private readonly static datTipoComPago _instancia = new datTipoComPago();

        private datTipoComPago()
        { }

        public static datTipoComPago Instancia
        {
            get { return _instancia; }
        }

        public List<entTipoComPago> ListarTiposComPago()
        {
            SqlCommand cmd = null;
            List<entTipoComPago> lista = new List<entTipoComPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTiposComprobantePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entTipoComPago tipocp = new entTipoComPago();
                    tipocp.Id_TipoComPago = Convert.ToInt32(reader["id_TipoComprobante"]);
                    tipocp.TipoComprobantePago = reader["tipo_comprobante"].ToString();
                    lista.Add(tipocp);
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

        //public Boolean AgregarCargo(entCargo cargo)
        //{
        //    SqlCommand cmd = null;
        //    Boolean inserta = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spAgregarCargo", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@cargo", cargo.Cargo);
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

        //public Boolean ModificarCargo(entCargo cargo)
        //{
        //    SqlCommand cmd = null;
        //    Boolean edita = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spModificarCargo", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id_cargo", cargo.Id_Cargo);
        //        cmd.Parameters.AddWithValue("@cargo", cargo.Cargo);
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
