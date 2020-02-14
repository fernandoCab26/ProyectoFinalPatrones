using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
   public interface IProcesadorPedidos
    {
        List<MensajePedidoDto> ProcesarPedidos(ConstructorMensajePedidos constructorMensajePedidos);
    }
}
