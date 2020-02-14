using Entidades;
using Entidades.Transportes.Interfaces;
using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService
{
    public class CreadorDetallesPedido : ICreardorDetallesPedido
    {
        IManejadorPaqueteria _manejadorPaqueteria;
        IVerificadorPrecios _verificadorPrecios;
        public CreadorDetallesPedido(IManejadorPaqueteria manejadorPaqueteria, IVerificadorPrecios verificadorPrecios) 
        {
            _manejadorPaqueteria = manejadorPaqueteria;
            _verificadorPrecios = verificadorPrecios;
        }
        public IDetallesPedido CrearDetallesPedido(IPedido pedido, IMedioTransporte medioTransporte, double margenUtilidad)
        {
            DetallesPedido detallesPedido = new DetallesPedido();

            detallesPedido.TiempoTraslado= _manejadorPaqueteria.CalcularTiempoTraslado(pedido.Distancia, medioTransporte.VelocidadEntrega);
             detallesPedido.FechaEntrega = _manejadorPaqueteria.CalcularFechaEntrega(pedido.FechaPedido, detallesPedido.TiempoTraslado);
            detallesPedido.CostoEnvio = _manejadorPaqueteria.CalcularCostoEnvio(medioTransporte.CostoKilometro, pedido.Distancia, margenUtilidad);
             detallesPedido.Cotizacion = _verificadorPrecios.CotizadorPrecios(detallesPedido.CostoEnvio, pedido);
 

            return detallesPedido;
        }
    }
}
