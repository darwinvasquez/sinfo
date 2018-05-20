using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Token
    {
        public string GenerarTokenPonal(string user, string pass)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://catalogoservicioweb.policia.gov.co");
            var url = "sw/token";

            var response = client.PostAsync(url, new FormUrlEncodedContent(new Dictionary<string, string> { { "grant_type", "password" }, { "username", user }, { "password", pass } })).Result;

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
}
