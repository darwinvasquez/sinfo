using Newtonsoft.Json;
using sinfo.Areas.Cnp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace sinfo.Models
{
    public static class GeneradorToken
    {
        public static async Task<string> Sincronizador(string accion, string user, string pass, string urlBase, string urlSw)
        {
            ContextCnp db = new ContextCnp();
            string result = "";

            var client = new HttpClient();
            client.BaseAddress = new Uri(urlBase);
            var url = urlSw;
            var token = TokenPonal(user, pass);
            client.DefaultRequestHeaders.Add("Authorization", token);
            var response = await client.GetAsync(url);

            //Validar el estado de la respuesta 200
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted)
            {
                return result = await response.Content.ReadAsStringAsync();
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                StatusCodeWebService status = new StatusCodeWebService();
                status.Accion = accion;
                status.Usuario = user;
                status.Url = url;
                status.CodigoResponseId = (int)EnumCodigoResponse.Unauthorized;
                status.PropietarioSw = "Policia Nacional de Colombia";
                status.FechaRegistro = DateTime.Now;
                status.Vigente = true;
                db.StatusCodeWebService.Add(status);
                db.SaveChanges();
                return null;
            }
            return null;
        }


        public static string TokenPonal(string user, string pass)
        {


            string username = user;
            string password = pass;

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://catalogoservicioweb.policia.gov.co");
            var url = "sw/token";
            var response = client.PostAsync(url, new FormUrlEncodedContent(new Dictionary<string, string> { { "grant_type", "password" }, { "username", username }, { "password", password } })).Result;
            if (!response.IsSuccessStatusCode)
            {
                return string.Empty;
            }

            var result = response.Content.ReadAsStringAsync().Result;
            Dictionary<string, string> tokenDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            string accessToken = tokenDictionary["access_token"];
            return string.Format("Bearer {0}", accessToken);
        }
    }

    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }

        public int expires_in { get; set; }

        public string userName { get; set; }

    }
}