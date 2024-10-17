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
    public class datUnidMxProducto
    {
        private readonly static datUnidMxProducto _instancia = new datUnidMxProducto();

        private datUnidMxProducto()
        { }

        public static datUnidMxProducto Instancia
        {
            get { return _instancia; }
        }

        public List<entUnidMxProducto> ListarUnidMedXProducto()
        {
            SqlCommand cmd = null;
            List<entUnidMxProducto> lista = new List<entUnidMxProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUnidadesMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entUnidMxProducto umxp = new entUnidMxProducto();
                    umxp.Id_UMxP_id = Convert.ToInt32(reader["id_UnidadMedidaProducto"]);
                    umxp.Id_Producto = Convert.ToInt32(reader["id_producto"]);
                    umxp.Producto = reader["nombre"].ToString();
                    umxp.Precio_Prod = Convert.ToDecimal(reader["precio"]);
                    umxp.Id_UM_Producto = Convert.ToInt32(reader["Id_UM_Prod"]);
                    umxp.UM_Producto = reader["UM_Prod"].ToString();
                    umxp.Id_UnidadMedida = Convert.ToInt32(reader["id_unidad_medida"]);
                    umxp.Unidad_Medida = reader["unidad_medida"].ToString();
                    umxp.Cantidad_Equivalente = Convert.ToInt32(reader["cantidad_equivalente"]);
                    umxp.Precio_Equivalente = Convert.ToDecimal(reader["precio_equivalente"]);
                    lista.Add(umxp);
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

        public Boolean AgregarUnidMedXProducto(entUnidMxProducto ent_upm)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarUnidadMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", ent_upm.Id_Producto);
                cmd.Parameters.AddWithValue("@id_unidad_medida", ent_upm.Id_UnidadMedida);
                cmd.Parameters.AddWithValue("@cantidad_equivalente", ent_upm.Cantidad_Equivalente);
                cmd.Parameters.AddWithValue("@precio_equivalente", ent_upm.Precio_Equivalente);
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

        public Boolean ModificarUnidMedXProducto(entUnidMxProducto ent_upm)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarUnidadMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Unid_Medida_Producto", ent_upm.Id_UMxP_id);
                cmd.Parameters.AddWithValue("@id_unidad_med_prod_producto", ent_upm.Id_UM_Producto);
                cmd.Parameters.AddWithValue("@id_producto", ent_upm.Id_Producto);
                cmd.Parameters.AddWithValue("@id_unidad_medida", ent_upm.Id_UnidadMedida);
                cmd.Parameters.AddWithValue("@cantidad_equivalente", ent_upm.Cantidad_Equivalente);
                cmd.Parameters.AddWithValue("@precio_equivalente", ent_upm.Precio_Equivalente);
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

        public Boolean EliminarUnidMedXProducto(entUnidMxProducto upm)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarUnidadMedidaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_unid_med_prod", upm.Id_UMxP_id);
                cmd.Parameters.AddWithValue("@id_unidad_med_prod_producto", upm.Id_UM_Producto);
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

        public Boolean EliminarUnidMedXProducto_Cambio_Unidad_Base(int id_producto)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarUMxP_Cambio_Unidad_Base", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
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


        public List<entProducto> BuscarProducto_Precio_UMxP(string id_producto, string nombre)
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto_Precio_UMP", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cmd.Parameters.AddWithValue("@nombre_producto", nombre);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto prod = new entProducto();
                    prod.Id_Producto = Convert.ToInt32(reader["id_Producto"]);
                    prod.Nombre = reader["nombre"].ToString();
                    prod.Precio = Convert.ToDecimal(reader["precio"]);
                    prod.UnidadMedida = reader["unidad_medida"].ToString();
                    lista.Add(prod);
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
