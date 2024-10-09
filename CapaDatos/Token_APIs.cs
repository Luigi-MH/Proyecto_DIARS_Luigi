using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class Token_APIs
    {
        private readonly static Token_APIs _instancia = new Token_APIs();

        private Token_APIs()
        { }

        public static Token_APIs Instancia
        {
            get { return _instancia; }
        }

        public HttpClient TokenClient()
        {
            HttpClient client = new HttpClient();
            string token = "apis-token-10898.EUCPdGJPAt6vqJSL444YhZep3AGvyqXJ";
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            return client;
        }
    }
}
