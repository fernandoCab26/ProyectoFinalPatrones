using Entidades.Paqueterias.Interfaces;
using RastreadorPaquetesService.Factory;
using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService
{
    public class PaqueteriaService : IPaqueteriaService
    {
        public List<IPaqueteria> ObtenerPaqueterias()
        {
            List<IPaqueteria> paqueterias = new List<IPaqueteria>();
            DhlFactory dhlFactory = new DhlFactory();

                    FedexFactory fedexFactory = new FedexFactory();
  
                    EstafetaFactory estafetaFactory = new EstafetaFactory();

            paqueterias.Add(dhlFactory.CrearPaqueteria());
            paqueterias.Add(fedexFactory.CrearPaqueteria());
            paqueterias.Add(estafetaFactory.CrearPaqueteria());

            return paqueterias;
        }
    }
}
