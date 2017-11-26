using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestVirtualMind.Entidades;
using TestVirtualMind.Interfaces;

namespace TestVirtualMind.Servicios
{
    public class ServicioCotizacion
    {
        IMoneda moneda;
        public Cotizacion GetCotizacion(string nombreMoneda)
        {
            switch (nombreMoneda.ToLower())
            {
                case "dolar":
                    moneda = new Dolar();
                    break;
                case "pesos":
                    moneda = new Peso();
                    break;
                case "real":
                    moneda = new Real();
                    break;
            }
            return moneda.GetCotizacion();
        }
    }
}