using Entidades.Transportes;
using Entidades.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Factory
{
    public class TrenFactory : TransportesFactory
    {
        public override IMedioTransporte CrearTransporte()
        {
           return new Tren();
        }
    }
}
