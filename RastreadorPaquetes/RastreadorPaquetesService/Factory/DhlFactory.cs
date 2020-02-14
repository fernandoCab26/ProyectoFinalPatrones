using Entidades.Paqueterias;
using Entidades.Paqueterias.Interfaces;

namespace RastreadorPaquetesService.Factory
{
    public class DhlFactory : PaqueteriasFactory
    {
        public override IPaqueteria CrearPaqueteria()
        {
            Dhl PaqueteriaDhl = new Dhl();
            AvionFactory avionFactory = new AvionFactory();
            BarcoFactory barcoFactory = new BarcoFactory();

            PaqueteriaDhl.AgregarTransporte(avionFactory.CrearTransporte());
            PaqueteriaDhl.AgregarTransporte(barcoFactory.CrearTransporte());

            return PaqueteriaDhl;

        }
    }
}
