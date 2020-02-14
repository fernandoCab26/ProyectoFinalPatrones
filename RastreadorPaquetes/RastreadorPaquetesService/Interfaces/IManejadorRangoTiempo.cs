using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IManejadorRangoTiempo
    {
        string ObtenerRangoTiempo(DateTime fechaEntrega, DateTime fechaActual);
    }
}
