using Entidades;
using Entidades.Paqueterias.Interfaces;
using Entidades.Transportes.Interfaces;
using RastreadorPaquetesService.Interfaces;
using System;
using System.Linq;

namespace RastreadorPaquetesService
{

    public class DirectorMensajePedidos : IDirectorMensajePedidos
    {

        private readonly IConstructorRespuestaPedido _constructorRespuestaPedido;
        private readonly IValidadorFecha _validadorFecha;
        private readonly IManejadorRangoTiempo _manejadorRangoTiempo;
        private readonly ICreardorDetallesPedido _creardorDetallesPedido;
        public DirectorMensajePedidos(IConstructorRespuestaPedido constructorRespuestaPedido, 
                                        IValidadorFecha validadorFecha,
                                        IManejadorRangoTiempo manejadorRangoTiempo, 
                                        ICreardorDetallesPedido creardorDetallesPedido)
        {
            _constructorRespuestaPedido = constructorRespuestaPedido;
            _validadorFecha = validadorFecha;
            _manejadorRangoTiempo = manejadorRangoTiempo;
            _creardorDetallesPedido = creardorDetallesPedido;
        }

        public void CrearMensajePaqueteria(IPedido pedido, IPaqueteria paqueteria)
        {

            IMedioTransporte medioTransporte = paqueteria.MediosTransportes.FirstOrDefault(x => x.Nombre.ToLowerInvariant() == pedido.MedioTransporte.ToLowerInvariant());

            if (medioTransporte == null)
            {
                throw new ArgumentException($"{paqueteria.NombreEmpresa} no ofrece el servicio de transporte por {pedido.MedioTransporte}, te recomendamos cotizar en otra empresa.");
            }
            IDetallesPedido detallesPedido = _creardorDetallesPedido.CrearDetallesPedido(pedido, medioTransporte, paqueteria.MargenUtilidad);


            string rangoTiempo = _manejadorRangoTiempo.ObtenerRangoTiempo(detallesPedido.FechaEntrega, DateTime.Now);
            bool fechaEntregaMenorActual = _validadorFecha.ValidarFechaActual(detallesPedido.FechaEntrega);

            _constructorRespuestaPedido.Reset();
            _constructorRespuestaPedido.ConstruirExpresion1(fechaEntregaMenorActual);
            _constructorRespuestaPedido.ConstruirOrigen(pedido.Origen);
            _constructorRespuestaPedido.ConstruirExpresion2(fechaEntregaMenorActual);
            _constructorRespuestaPedido.ConstruirExpresion3(fechaEntregaMenorActual);
            _constructorRespuestaPedido.AsignarRangoTiempo(rangoTiempo);
            _constructorRespuestaPedido.ConstruirExpresion4(fechaEntregaMenorActual);
            _constructorRespuestaPedido.ConstuirCostoEnvio(detallesPedido.CostoEnvio.ToString());
            _constructorRespuestaPedido.AsignarColorMensaje(fechaEntregaMenorActual);
            _constructorRespuestaPedido.ConstuirDestino(pedido.Destino);
            _constructorRespuestaPedido.AgregarOpcionEconomica(detallesPedido.Cotizacion);
            _constructorRespuestaPedido.ConstruirFinal(pedido.Paqueteria);

        }
    }
}
