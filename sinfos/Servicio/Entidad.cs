using Newtonsoft.Json;
using Servicio.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Entidad : IRetornarEntidad
    {
        public async Task<string> RetornarEntidad()
        {
            string username = "darwi.vasquez@correo.policia.gov.co";
            string password = "Policia2018*2019";           

            Token tok = new Token();

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://catalogoservicioweb.policia.gov.co");
            var url = "/sw/api/ListaValor/ConsultaEstadoMedida";
            var token = tok.GenerarTokenPonal(username, password);
            
            client.DefaultRequestHeaders.Add("Authorization", token);

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return "";
            }

            var result = await response.Content.ReadAsStringAsync();
            return result;

            //foreach (var item in datos)
            //{
            //    bool existe = db.EstadoMedida.Any(x => x.CodigoPonal == item.ID_DOMINIO);
            //    if (!existe)
            //    {
            //        EstadoMedida dato = new EstadoMedida();
            //        dato.CodigoPonal = Convert.ToInt32(item.ID_DOMINIO);
            //        dato.Descripcion = item.DESCRIPCION;
            //        dato.Vigente = true;
            //        db.EstadoMedida.Add(dato);
            //        db.SaveChanges();
            //    }
            //}           
        }
    }
}
