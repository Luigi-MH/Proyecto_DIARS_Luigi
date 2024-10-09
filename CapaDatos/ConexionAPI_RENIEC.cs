using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class ConexionAPI_RENIEC
    {
        private readonly static ConexionAPI_RENIEC _instancia = new ConexionAPI_RENIEC();

        private ConexionAPI_RENIEC()
        { }

        public static ConexionAPI_RENIEC Instancia
        {
            get { return _instancia; }
        }

        //public SqlConnection ConectarAPI_RENIEC(string dni)
        //{
        //    string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Im1lbmRvemFoZXJyZXJhbHVpZ2lAZ21haWwuY29tIn0.KZndBWQaW-JoObjcsTEjDbFqcIRtIUK5im8GctUYjfM";
        //    string apiUrl = $"https://dniruc.apisperu.com/api/v1/dni/{dni}?token={token}";

        //    return conexion;
        //}
    }
}
