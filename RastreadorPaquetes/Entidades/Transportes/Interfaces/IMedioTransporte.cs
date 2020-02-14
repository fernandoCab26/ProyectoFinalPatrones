using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Transportes.Interfaces
{
    public interface IMedioTransporte
    {
        string Nombre { get;}
        double CostoKilometro { get; }

        double VelocidadEntrega { get;}
        double CalcularTimpoTraslado(double distancia);
    }
}
