using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IManejadorPaqueteria
    {
        double CalcularTiempoTraslado(double distancia, double velocidadTransporte);
        DateTime CalcularFechaEntrega(DateTime fechaPedido, double TiempoTraslado);
        double CalcularCostoEnvio(double costoKilometro, double distancia, double margenUtilidad);
    }
}
