using Entidades;
using RastreadorPaquetesService.Interfaces;
using System.Collections.Generic;

namespace RastreadorPaquetesService
{
    public class ProcesadorPedidos : IProcesadorPedidos
    {
        private readonly ICreadorPedidos _creadorPedidos;
        private readonly IProductorDePaqueteriasFactory _productorDePaqueteriasFactory;
        private readonly IDirectorMensajePedidos _directorMensaje;
        public ProcesadorPedidos(ICreadorPedidos creadorPedidos, IProductorDePaqueteriasFactory productorDePaqueteriasFactory, IDirectorMensajePedidos directorMensaje)
        {
            _creadorPedidos = creadorPedidos;
            _productorDePaqueteriasFactory = productorDePaqueteriasFactory;
            _directorMensaje = directorMensaje;
        }
        public List<MensajePedidoDto> ProcesarPedidos( ConstructorMensajePedidos constructorMensajePedidos )
        {
            List<MensajePedidoDto> mensajePedidos = new List<MensajePedidoDto>();
            List<IPedido> pedidoRecibido = _creadorPedidos.CrearPedido();

            foreach (IPedido pedido in pedidoRecibido)
            {
                var paqueteria = _productorDePaqueteriasFactory.CrearPaqueteria(pedido.Paqueteria);
                _directorMensaje.CrearMensajePaqueteria(pedido, paqueteria);
                mensajePedidos.Add(constructorMensajePedidos.ObtenerMensaje());
            }
            return mensajePedidos;
        }
    }
}
