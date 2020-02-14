using RastreadorPaquetesService.Interfaces;
using System;

namespace RastreadorPaquetesService
{
    public class ManejadorRangoTiempo : IManejadorRangoTiempo
    {
        public string ObtenerRangoTiempo(DateTime fechaEntrega, DateTime fechaActual)
        {
            if (fechaEntrega == DateTime.MinValue)
            {
                throw new ArgumentException("El formato de fecha es inválido");
            }
            if (fechaActual == DateTime.MinValue)
            {
                throw new ArgumentException("El formato de fecha es inválido");
            }

            string mensajeTiempo = string.Empty;
            int difMinutos = Math.Abs((fechaEntrega - fechaActual).Minutes);
            int difHoras = Math.Abs((fechaEntrega - fechaActual).Hours);
            int difDias = Math.Abs((fechaEntrega - fechaActual).Days);
            int difMeses = Math.Abs((fechaEntrega.Month - fechaActual.Month) + 12 * (fechaEntrega.Year - fechaActual.Year));

            if (difMinutos < 60)
            {
                mensajeTiempo = $"{ difMinutos} minutos.";
            }
            if (difHoras < 24 && difHoras != 0)
            {
                mensajeTiempo = $"{ difHoras} horas.";
            }
            if (difDias <= 30 && difDias != 0)
            {
                mensajeTiempo = $"{ difDias} días.";
            }
            if (difMeses != 0)
            {
                mensajeTiempo = $"{difMeses} meses.";
            }

            return mensajeTiempo;
        }
    }
}
