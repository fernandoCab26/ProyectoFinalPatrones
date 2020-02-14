using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IVerificadorPrecios
    {
       string CotizadorPrecios(double costoOriginal, IPedido pedido);
    }
}
