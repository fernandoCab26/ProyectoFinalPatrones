using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IDetallesPedido
    { 

        public double CostoEnvio { get; set; }
        public double TiempoTraslado { get; set; }
        public string OpcionEconomica { get; set; }
        DateTime FechaEntrega { get; set; }

        string Cotizacion { get; set; }
    }
}
