using Entidades.Paqueterias;
using Entidades.Paqueterias.Interfaces;

namespace RastreadorPaquetesService.Factory
{
    public class FedexFactory : PaqueteriasFactory
    {
        public override IPaqueteria CrearPaqueteria()
        {
            Fedex fedex= new Fedex();
            BarcoFactory barcoFactory = new BarcoFactory();

            fedex.AgregarTransporte(barcoFactory.CrearTransporte());
            return fedex;
        }
    }
}
