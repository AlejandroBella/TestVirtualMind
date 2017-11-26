using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using TestVirtualMind.Interfaces;

namespace TestVirtualMind.Entidades
{
    public class Dolar:IMoneda
    {
        public Cotizacion GetCotizacion()
        {
            var coti = new Cotizacion();

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.bancoprovincia.com.ar/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            

            HttpResponseMessage response = client.GetAsync("Principal/Dolar").Result;
            if (response.IsSuccessStatusCode)
            {
               ParseCotizacion(response,coti);
            }

            return coti;
        }

        private void ParseCotizacion(HttpResponseMessage response,Cotizacion coti)
        {
            var result = response.Content.ReadAsAsync<List<String>>().Result;
            coti.Venta = Convert.ToDouble(result[0].Replace(".",","));
            coti.Compra = Convert.ToDouble(result[1].Replace(".", ","));
        }
    }
}