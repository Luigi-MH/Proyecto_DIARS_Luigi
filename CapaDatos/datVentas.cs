using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDatos
{
    public class datVentas
    {
        private readonly static datVentas _instancia = new datVentas();

        private datVentas()
        { }

        public static datVentas Instancia
        {
            get { return _instancia; }
        }

        public List<entVenta> ListarVentas()
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entVenta venta = new entVenta();
                    venta.Id_Usuario = Convert.ToInt32(reader["id_Venta"]);
                    venta.Id_TipoComprobante = Convert.ToInt32(reader["id_TipoComprobante"]);
                    venta.TipoComprobante = reader["tipo_comprobante"].ToString();
                    venta.Serie = reader["serie"].ToString();
                    venta.Correlativo = reader["correlativo"].ToString();
                    venta.Id_Cliente = Convert.ToInt32(reader["id_cliente"]);
                    venta.Id_TipoDoc = Convert.ToInt32(reader["id_tipo_documento"]);
                    venta.TipoDoc = reader["tipo_documento"].ToString();
                    venta.Documento = reader["numero_doc"].ToString();
                    venta.Cliente = reader["cliente"].ToString();
                    venta.Id_MetodoPago = Convert.ToInt32(reader["id_metodo_pago"]);
                    venta.MedotoPago = reader["metodo_pago"].ToString();
                    venta.Id_Usuario = Convert.ToInt32(reader["id_usuario"]);
                    venta.Usuario = reader["nombre_usuario"].ToString();
                    venta.Id_Caja = Convert.ToInt32(reader["id_caja"]);
                    venta.Caja = reader["caja"].ToString();
                    venta.Id_SesionCaja = Convert.ToInt32(reader["id_sesion"]);
                    venta.SubTotal = Convert.ToDecimal(reader["sub_total"]);
                    venta.IGV = Convert.ToDecimal(reader["igv"]);
                    venta.Total = Convert.ToDecimal(reader["total"]);
                    venta.Fecha = Convert.ToDateTime(reader["fecha"]);
                    venta.Notas = reader["notas"].ToString();
                    venta.Id_Estado = Convert.ToInt32(reader["id_estado"]);
                    venta.Estado = reader["estado"].ToString();
                    venta.Id_EstadoSUNAT = Convert.ToInt32(reader["id_estado_sunat"]);
                    venta.EstadoSUNAT = reader["EstadoSUNAT"].ToString();
                    lista.Add(venta);
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

        public List<entDetalleVenta> ListarDetallesVenta(int Id_Venta)
        {
            SqlCommand cmd = null;
            List<entDetalleVenta> lista = new List<entDetalleVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_venta", Id_Venta);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entDetalleVenta detalleVenta = new entDetalleVenta();
                    detalleVenta.Id_DetVenta = Convert.ToInt32(reader["id_DetalleVenta"]);
                    detalleVenta.Id_Venta = Convert.ToInt32(reader["id_venta"]);
                    detalleVenta.Id_Producto = Convert.ToInt32(reader["id_producto"]);
                    detalleVenta.Producto = reader["nombre"].ToString();
                    detalleVenta.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    detalleVenta.Id_UnidadMedida = Convert.ToInt32(reader["id_unidad_medida"]);
                    detalleVenta.UnidadMedida = reader["unidad_medida"].ToString();
                    detalleVenta.Precio = Convert.ToDecimal(reader["precio"]);
                    detalleVenta.Id_Promocion = Convert.ToInt32(reader["id_promocion"]);
                    detalleVenta.Descuento = Convert.ToInt32(reader["descuento"]);
                    detalleVenta.SubTotalDet = Convert.ToDecimal(reader["subtotal"]);
                    lista.Add(detalleVenta);
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

        public int AgregarVenta(entVenta venta)
        {
            SqlCommand cmd = null;
            int id_venta = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_comp", venta);
                cmd.Parameters.AddWithValue("@id_cliente", venta);
                cmd.Parameters.AddWithValue("@id_metodoPago", venta);
                cmd.Parameters.AddWithValue("@id_usuario", venta);
                cmd.Parameters.AddWithValue("@id_caja", venta);
                cmd.Parameters.AddWithValue("@id_sesion", venta);
                cmd.Parameters.AddWithValue("@sub_total", venta);
                cmd.Parameters.AddWithValue("@igv", venta);
                cmd.Parameters.AddWithValue("@total", venta);
                cmd.Parameters.AddWithValue("@fecha", venta);
                cmd.Parameters.AddWithValue("@notas", venta);
                cmd.Parameters.AddWithValue("@id_estado", venta);
                SqlParameter outputIdParam = new SqlParameter("@id_Venta", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputIdParam);
                cn.Open();
                id_venta = (int)outputIdParam.Value;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return id_venta;
        }

        public Boolean AgregarDetallesVenta(entDetalleVenta detVenta)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarDetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_venta", detVenta.Id_Venta);
                cmd.Parameters.AddWithValue("@id_producto", detVenta.Id_Producto);
                cmd.Parameters.AddWithValue("@cantidad", detVenta.Cantidad);
                cmd.Parameters.AddWithValue("@id_unidadMedida", detVenta.Id_UnidadMedida);
                cmd.Parameters.AddWithValue("@id_promocion", detVenta.Id_Promocion);
                cmd.Parameters.AddWithValue("@subtotal", detVenta.SubTotalDet);
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

        public List<entCliente> BuscarCliente(string documeto, string nombre)
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarClienteVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documento", documeto);
                cmd.Parameters.AddWithValue("@nombre_cliente", nombre);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entCliente cliente = new entCliente();
                    cliente.Id_Cliente = Convert.ToInt32(reader["id_Cliente"]);
                    cliente.Cliente = reader["cliente"].ToString();
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

        public List<entProducto> BuscarProducto_Nombre(string nombre)
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto_Nombre_DetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_producto", nombre);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto prod = new entProducto();
                    prod.Id_Producto = Convert.ToInt32(reader["id_Producto"]);
                    prod.Nombre = reader["nombre"].ToString();
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
        public List<entProducto> BuscarProducto_Id(int id_producto)
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto_Id_DetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto prod = new entProducto();
                    prod.Id_Producto = Convert.ToInt32(reader["id_Producto"]);
                    prod.Nombre = reader["nombre"].ToString();
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
        public List<entProducto> BuscarProducto_CodigoBarras(string codBarras)
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto_CodBarras_DetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@digitos_codigo_barras", codBarras);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entProducto prod = new entProducto();
                    prod.Id_Producto = Convert.ToInt32(reader["id_Producto"]);
                    prod.Nombre = reader["nombre"].ToString();
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

        public List<entUnidMxProducto> BuscarUnidadesMP_Producto(int id_producto)
        {
            SqlCommand cmd = null;
            List<entUnidMxProducto> lista = new List<entUnidMxProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarUnidadesMedidaProducto_DetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entUnidMxProducto ump_p = new entUnidMxProducto();
                    ump_p.Id_UnidadMedida = Convert.ToInt32(reader["id_unidad_medida"]);
                    ump_p.Unidad_Medida = reader["unidad_medida"].ToString();
                    ump_p.Cantidad_Equivalente = Convert.ToInt32(reader["cantidad_equivalente"]);
                    ump_p.Precio_Equivalente = Convert.ToDecimal(reader["precio_equivalente"]);
                    lista.Add(ump_p);
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

        public List<entPromocionProducto> BuscarPromocionProducto(int id_producto)
        {
            SqlCommand cmd = null;
            List<entPromocionProducto> lista = new List<entPromocionProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPromocionProducto_DetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entPromocionProducto promo_prod = new entPromocionProducto();
                    promo_prod.Id_Promocion = Convert.ToInt32(reader["id_promocion"]);
                    promo_prod.Descuento = Convert.ToDouble(reader["descuento"].ToString());
                    lista.Add(promo_prod);
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
