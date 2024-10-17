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
    public class datMetodoPago
    {
        private readonly static datMetodoPago _instancia = new datMetodoPago();

        private datMetodoPago()
        { }

        public static datMetodoPago Instancia
        {
            get { return _instancia; }
        }

        public List<entMetodoPago> ListarMetododosPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMetodosPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entMetodoPago metodoPago = new entMetodoPago();
                    metodoPago.Id_MetodoPago = Convert.ToInt32(reader["id_MetodoPago"]);
                    metodoPago.Metodo_Pago = reader["metodo_pago"].ToString();
                    lista.Add(metodoPago);
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
