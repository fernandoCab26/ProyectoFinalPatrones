using System;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IConstructorRespuestaPedido
    {

        public void ConstruirExpresion1(bool fechaEntregaMenorActual);
        public void ConstruirOrigen(string origen);
        public void ConstruirExpresion2(bool fechaEntregaMenorActual);
        public void ConstuirDestino(string destino);
        public void ConstruirExpresion3(bool fechaEntregaMenorActual);
        public void ConstruirExpresion4(bool fechaEntregaMenorActual);
        public void AsignarRangoTiempo(string rangotiempo);
        public void ConstruirFinal(string paqueteria);
        public void ConstuirCostoEnvio(string costoEnvio);
        public void AsignarColorMensaje(bool fechaEntregaMenorActual);
        public void AgregarOpcionEconomica(string opcion);

        public void Reset();
    }
}
