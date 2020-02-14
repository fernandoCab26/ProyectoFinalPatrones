using Entidades;
using Entidades.Paqueterias.Interfaces;
using Entidades.Transportes.Interfaces;
using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RastreadorPaquetesService
{
    public class VerificadorPrecios : IVerificadorPrecios
    {
        IManejadorPaqueteria _manejadorPaqueteria;
        IPaqueteriaService _paqueteriaService;
        public VerificadorPrecios(IManejadorPaqueteria manejadorPaqueteria, IPaqueteriaService paqueteriaService)
        {
            _manejadorPaqueteria = manejadorPaqueteria;
            _paqueteriaService = paqueteriaService;
        }
        public string CotizadorPrecios(double costoOriginal, IPedido pedido)
        {
            string mensaje = string.Empty;
            List<IPaqueteria> paqueterias = _paqueteriaService.ObtenerPaqueterias();

            foreach (IPaqueteria paqueteria in paqueterias.Where(x => x.NombreEmpresa.ToLowerInvariant() != pedido.Paqueteria.ToLowerInvariant()))
            {
                IMedioTransporte transporte = paqueteria.MediosTransportes
                                .FirstOrDefault(x => x.Nombre.ToLowerInvariant() == pedido.MedioTransporte.ToLowerInvariant());

                if (transporte != null)
                {
                    double cotizacion = _manejadorPaqueteria.CalcularCostoEnvio(transporte.CostoKilometro, pedido.Distancia, paqueteria.MargenUtilidad);
                    if (costoOriginal > cotizacion)
                    {
                        mensaje = $"Si hubieras pedido en {paqueteria.NombreEmpresa} te hubiera costado (${cotizacion}).";
                    }
                }
            }

            return mensaje;
        }
    }
}
