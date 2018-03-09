using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace sinfo.Models
{
    public static class GeneradorToken
    {
        public static string TokenPonal()
        {
            string username = "darwi.vasquez@correo.policia.gov.co";
            string password = "Policia2018*2019";

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