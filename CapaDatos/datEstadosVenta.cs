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
    public class datEstadosVenta
    {
        private readonly static datEstadosVenta _instancia = new datEstadosVenta();

        private datEstadosVenta()
        { }

        public static datEstadosVenta Instancia
        {
            get { return _instancia; }
        }

        public List<entEstadoVenta> ListarEstadosVenta()
        {
            SqlCommand cmd = null;
            List<entEstadoVenta> lista = new List<entEstadoVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEstadosVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entEstadoVenta estado = new entEstadoVenta();
                    estado.Id_EstadoVenta = Convert.ToInt32(reader["id_EstadoVenta"]);
                    estado.Estado_Venta = reader["estado"].ToString();
                    lista.Add(estado);
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
