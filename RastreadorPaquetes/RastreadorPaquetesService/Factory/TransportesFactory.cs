using Entidades.Transportes.Interfaces;

namespace RastreadorPaquetesService.Factory
{
    public abstract class TransportesFactory
    {
        public abstract IMedioTransporte CrearTransporte();
    }
}
