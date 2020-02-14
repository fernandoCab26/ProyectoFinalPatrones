using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IValidadorFecha
    {
        bool ValidarFechaActual(DateTime dateTime);
    }
}
