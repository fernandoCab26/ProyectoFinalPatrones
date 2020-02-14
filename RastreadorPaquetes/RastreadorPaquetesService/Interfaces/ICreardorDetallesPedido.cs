using Entidades;
using Entidades.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface ICreardorDetallesPedido
    {
        IDetallesPedido CrearDetallesPedido(IPedido pedido, IMedioTransporte medioTransporte, double margenUtilidad);
    }
}
