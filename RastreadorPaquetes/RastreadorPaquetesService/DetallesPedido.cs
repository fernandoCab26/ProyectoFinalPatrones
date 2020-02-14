using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService
{
    public class DetallesPedido : IDetallesPedido
    {
        public double CostoEnvio { get ; set ; }
        public double TiempoTraslado { get ; set ; }
        public string OpcionEconomica { get ; set ; }
        public DateTime FechaEntrega { get ; set ; }
        public string Cotizacion { get; set; }
    }
}
