using Entidades.Paqueterias.Interfaces;
using RastreadorPaquetesService.Factory;
using RastreadorPaquetesService.Interfaces;
using System;

namespace RastreadorPaquetesService
{
    public class ProductorDePaqueteriasFactory : IProductorDePaqueteriasFactory
    {
        public IPaqueteria CrearPaqueteria(string nombrePaqueteria)
        {
            IPaqueteria paqueteria;
            switch (nombrePaqueteria.ToLowerInvariant())
            {
                case "dhl":
                    DhlFactory dhlFactory = new DhlFactory();
                    paqueteria = dhlFactory.CrearPaqueteria();
                    break;
                case "fedex":
                    FedexFactory fedexFactory = new FedexFactory();
                    paqueteria = fedexFactory.CrearPaqueteria();
                    break;
                case "estafeta":
                    EstafetaFactory estafetaFactory = new EstafetaFactory();
                    paqueteria = estafetaFactory.CrearPaqueteria();
                    break;
                default:
                    throw new ArgumentException($"La Paquetería: [{nombrePaqueteria}] no se encuentra registrada en nuestra red de distribución.");

            }

            return paqueteria;
        }
    }
}
