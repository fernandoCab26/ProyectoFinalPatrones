using Entidades.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Transportes
{
    public class Avion : IMedioTransporte
    {
        private readonly string _nombre = "Avión";
        private readonly double _costoKilometro = 10;
        private readonly double _velocidad = 600;

        public string Nombre => _nombre;
        public double CostoKilometro => _costoKilometro;
        public double VelocidadEntrega => _velocidad;

        public double CalcularTimpoTraslado(double distancia)
        {
            return distancia * _velocidad;
        }
    }
}
