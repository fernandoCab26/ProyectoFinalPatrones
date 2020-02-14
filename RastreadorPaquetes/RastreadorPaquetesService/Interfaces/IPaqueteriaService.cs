using Entidades.Paqueterias.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IPaqueteriaService
    {
        List<IPaqueteria> ObtenerPaqueterias();
    }
}
