using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService
{
    public class ValidadorFecha : IValidadorFecha
    {
        public bool ValidarFechaActual(DateTime dateTime)
        {
            DateTime hoy = DateTime.Now;

            return dateTime < hoy;
        }
    }
}
