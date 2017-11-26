using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestVirtualMind.Entidades;

namespace TestVirtualMind.Controllers
{
    public class CotizacionController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetCotizacion(string nombreMoneda)
        {

           var serv = new Servicios.ServicioCotizacion();
           var result = serv.GetCotizacion(nombreMoneda);



            if(result!=null )
            {
                return Ok(result);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
