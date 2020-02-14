using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService
{
    public class ManejadorPaqueteria : IManejadorPaqueteria
    {
        public double CalcularCostoEnvio(double costoKilometro, double distancia, double margenUtilidad)
        {
            return costoKilometro * distancia * (1 + (margenUtilidad / 100));
        }

        public DateTime CalcularFechaEntrega(DateTime fechaPedido, double TiempoTraslado)
        {
            return fechaPedido.AddHours(TiempoTraslado);
        }

        public double CalcularTiempoTraslado(double distancia, double velocidadTransporte)
        {
            return distancia / velocidadTransporte;
        }
    }
}
