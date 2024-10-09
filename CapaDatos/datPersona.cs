using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datPersona
    {
        private readonly static datPersona _instancia = new datPersona();

        private datPersona()
        { }

        public static datPersona Instancia
        {
            get { return _instancia; }
        }

        public async Task<string> GET_DNI_Datos(string dni)
        {
            string url = $"https://api.apis.net.pe/v2/reniec/dni?numero={dni}";
            try
            {
                HttpClient client = Token_APIs.Instancia.TokenClient();
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    // Manejar el error si la respuesta no es exitosa
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                // Manejar posibles excepciones
                return $"Exception: {ex.Message}";
            }
        }
    }
}
