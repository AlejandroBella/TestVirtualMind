﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TestVirtualMind.Interfaces;

namespace TestVirtualMind.Entidades
{
    public class Real : IMoneda
    {
        public Cotizacion GetCotizacion()
        {
            return null;
        }
    }
}