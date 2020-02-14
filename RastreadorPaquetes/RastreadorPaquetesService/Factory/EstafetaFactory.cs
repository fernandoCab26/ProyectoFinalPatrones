using Entidades.Paqueterias;
using Entidades.Paqueterias.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Factory
{
    public class EstafetaFactory : PaqueteriasFactory
    {
        public override IPaqueteria CrearPaqueteria()
        {
            Estafeta estafeta = new Estafeta();
            TrenFactory trenFactory = new TrenFactory();
            BarcoFactory barcoFactory = new BarcoFactory();

            estafeta.AgregarTransporte(trenFactory.CrearTransporte());
            estafeta.AgregarTransporte(barcoFactory.CrearTransporte());

            return estafeta;
        }
    }
}
