using Entidades.Transportes.Interfaces;

namespace Entidades.Transportes
{
    public class Barco : IMedioTransporte
    {
        private readonly string _nombre = "Barco";
        private readonly double _costoKilometro = 1;
        private readonly double _velocidad = 46;

        public string Nombre => _nombre;
        public double CostoKilometro => _costoKilometro;
        public double VelocidadEntrega => _velocidad;

        public double CalcularTimpoTraslado(double distancia)
        {
            return distancia * _velocidad;
        }
    }
}
