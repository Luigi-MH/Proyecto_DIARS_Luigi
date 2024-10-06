using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace CapaDatos
{
    public class datEmpleados
    {
        private readonly static datEmpleados _instancia = new datEmpleados();

        private datEmpleados()
        { }

        public static datEmpleados Instancia
        {
            get { return _instancia; }
        }

        public List<entEmpleados> ListarEmpleados()
        {
            SqlCommand cmd = null;
            List<entEmpleados> lista = new List<entEmpleados>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEmpleados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    entEmpleados empleado = new entEmpleados();
                    empleado.Id_Empleado = Convert.ToInt32(reader["id_Empleado"]);
                    empleado.Id_TipoDocumento = Convert.ToInt32(reader["id_TipoDocumento"]);
                    empleado.NumDoc = reader["numero_doc"].ToString();
                    empleado.Nombres = reader["nombres"].ToString();
                    empleado.Apellidos = reader["apellidos"].ToString();
                    empleado.Correo = reader["correo"].ToString();
                    empleado.Telefono = reader["telefono"].ToString();
                    empleado.FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]);
                    if (reader["foto_empleado"] != DBNull.Value)
                    {
                        empleado.FotoEmpleado = (byte[])reader["foto_empleado"];
                    }
                    empleado.FechaContratacion = Convert.ToDateTime(reader["fecha_contratacion"]);
                    empleado.Id_Cargo = Convert.ToInt32(reader["id_Cargo"]);
                    empleado.Salario = Convert.ToDecimal(reader["salario"]);
                    empleado.Estado = Convert.ToBoolean(reader["estado"]);
                    empleado.TipoDocumento = reader["tipo_documento"].ToString();
                    empleado.Cargo = reader["cargo"].ToString();
                    lista.Add(empleado);
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

        public Boolean AgregarEmpleado(entEmpleados empleado)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_documento", empleado.Id_TipoDocumento);
                cmd.Parameters.AddWithValue("@numero_doc", empleado.NumDoc);
                cmd.Parameters.AddWithValue("@nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@foto_empleado", empleado.FotoEmpleado);
                cmd.Parameters.AddWithValue("@fecha_contratacion", empleado.FechaContratacion);
                cmd.Parameters.AddWithValue("@id_cargo", empleado.Id_Cargo);
                cmd.Parameters.AddWithValue("@salario", empleado.Salario);
                cmd.Parameters.AddWithValue("@estado", empleado.Estado);
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

        public Boolean ModificarEmpleado(entEmpleados empleado)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", empleado.Id_Empleado);
                cmd.Parameters.AddWithValue("@id_tipo_documento", empleado.Id_TipoDocumento);
                cmd.Parameters.AddWithValue("@numero_doc", empleado.NumDoc);
                cmd.Parameters.AddWithValue("@nombres", empleado.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
                cmd.Parameters.AddWithValue("@correo", empleado.Correo);
                cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@foto_empleado", empleado.FotoEmpleado);
                cmd.Parameters.AddWithValue("@fecha_contratacion", empleado.FechaContratacion);
                cmd.Parameters.AddWithValue("@id_cargo", empleado.Id_Cargo);
                cmd.Parameters.AddWithValue("@salario", empleado.Salario);
                cmd.Parameters.AddWithValue("@estado", empleado.Estado);
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
