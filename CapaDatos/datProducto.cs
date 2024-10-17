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
    public class datProducto
    {
        private readonly static datProducto _instancia = new datProducto();

        private datProducto()
        { }

        public static datProducto Instancia
        {
            get { return _instancia; }
        }

        public List<entProducto> ListarProductos()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto prod = new entProducto();
                    prod.Id_Producto = Convert.ToInt32(reader["id_Producto"]);
                    prod.Nombre = reader["nombre"].ToString();
                    if (reader["imagen"] != DBNull.Value)
                    {
                        prod.Foto_Producto = (byte[])reader["imagen"];
                    }
                    prod.Descripcion = reader["descripcion"].ToString();
                    prod.Id_Categoria = Convert.ToInt32(reader["id_categoria"]);
                    prod.Categoria = reader["categoria"].ToString();
                    prod.Id_LabFabricante = Convert.ToInt32(reader["id_fabricante"]);
                    prod.Laboratorio = reader["fafricante"].ToString();
                    prod.CodigoBarras = reader["codigo_barras"].ToString();
                    prod.Requiere_Receta = Convert.ToBoolean(reader["requiere_receta"]);
                    prod.Es_Generio = Convert.ToBoolean(reader["es_generico"]);
                    prod.Id_UnidadMendida = Convert.ToInt32(reader["id_unidad_medida"]);
                    prod.UnidadMedida = reader["unidad_medida"].ToString();
                    prod.Precio = Convert.ToDecimal(reader["precio"]);
                    prod.Id_Estado = Convert.ToInt32(reader["id_estado"]);
                    prod.Estado = reader["estado"].ToString();
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

        public int AgregarProducto(entProducto prod)
        {
            SqlCommand cmd = null;
            int id_Producto = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@imagen", prod.Foto_Producto);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", prod.Id_Categoria);
                cmd.Parameters.AddWithValue("@id_fabricante", prod.Id_LabFabricante);
                cmd.Parameters.AddWithValue("@codigo_barras", prod.CodigoBarras);
                cmd.Parameters.AddWithValue("@requiere_receta", prod.Requiere_Receta);
                cmd.Parameters.AddWithValue("@es_generio", prod.Es_Generio);
                cmd.Parameters.AddWithValue("@id_unidad_medida", prod.Id_UnidadMendida);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
                cmd.Parameters.AddWithValue("@id_estado", prod.Id_Estado);
                SqlParameter outputIdParam = new SqlParameter();
                outputIdParam.ParameterName = "@ultimo_id";
                outputIdParam.SqlDbType = SqlDbType.Int;
                outputIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputIdParam);
                cn.Open();
                cmd.ExecuteNonQuery();
                id_Producto = (int)cmd.Parameters["@ultimo_id"].Value;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return id_Producto;
        }

        public Boolean ModificarProducto(entProducto prod)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", prod.Id_Producto);
                cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@imagen", prod.Foto_Producto);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", prod.Id_Categoria);
                cmd.Parameters.AddWithValue("@id_fabricante", prod.Id_LabFabricante);
                cmd.Parameters.AddWithValue("@codigo_barras", prod.CodigoBarras);
                cmd.Parameters.AddWithValue("@requiere_receta", prod.Requiere_Receta);
                cmd.Parameters.AddWithValue("@es_generio", prod.Es_Generio);
                cmd.Parameters.AddWithValue("@id_unidad_medida", prod.Id_UnidadMendida);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
                cmd.Parameters.AddWithValue("@id_estado", prod.Id_Estado);
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

        public Boolean ModificarProducto_sin_UnidadMedida(entProducto prod)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProducto_sin_UnidadMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", prod.Id_Producto);
                cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@imagen", prod.Foto_Producto);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", prod.Id_Categoria);
                cmd.Parameters.AddWithValue("@id_fabricante", prod.Id_LabFabricante);
                cmd.Parameters.AddWithValue("@codigo_barras", prod.CodigoBarras);
                cmd.Parameters.AddWithValue("@requiere_receta", prod.Requiere_Receta);
                cmd.Parameters.AddWithValue("@es_generio", prod.Es_Generio);
                cmd.Parameters.AddWithValue("@precio", prod.Precio);
                cmd.Parameters.AddWithValue("@id_estado", prod.Id_Estado);
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

        public List<entLabFabricante> BuscarLaboratorio(string labFafricante, string Id_LabFab)
        {
            SqlCommand cmd = null;
            List<entLabFabricante> lista = new List<entLabFabricante>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarLaboratoriosFabricantes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_labFab", Id_LabFab);
                cmd.Parameters.AddWithValue("@fabricante", labFafricante);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entLabFabricante lab = new entLabFabricante();
                    lab.Id_LabFabricante = Convert.ToInt32(reader["id_LabFab"]);
                    lab.LaboratorioFabricante = reader["fafricante"].ToString();
                    lista.Add(lab);
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
