using RastreadorPaquetesService.Interfaces;
using System.Drawing;

namespace RastreadorPaquetesService
{
    public class ConstructorMensajePedidos : IConstructorRespuestaPedido
    {
        MensajePedidoDto _mensajePedidoDto;
        private string _expresion1;
        private string _origen;
        private string _destino;
        private string _expresion2;
        private string _expresion3;
        private string _rangoTiempo;
        private string _expresion4;
        private string _costoEnvio;
        private string _paqueteria;
        private string _opcionEconomica;


        public ConstructorMensajePedidos()
        {
            _mensajePedidoDto = new MensajePedidoDto();
        }
        public void ConstruirFinal(string paqueteria)
        {
            _paqueteria = paqueteria;
        }

        public void ConstruirExpresion1(bool fechaEntregaMenorActual)
        {
            if (fechaEntregaMenorActual)
            {
                _expresion1 = "salió";
            }
            else
            {
                _expresion1 = "ha salido";
            }

        }

        public void ConstruirOrigen(string origen)
        {
            _origen = origen;
        }

        public void ConstruirExpresion2(bool fechaEntregaMenorActual)
        {
            if (fechaEntregaMenorActual)
            {
                _expresion2 = "llegó";
            }
            else
            {
                _expresion2 = "llegará";
            }
        }

        public void ConstuirDestino(string destino)
        {
            _destino = destino;
        }

        public void ConstruirExpresion3(bool fechaEntregaMenorActual)
        {
            if (fechaEntregaMenorActual)
            {
                _expresion3 = "hace";
            }
            else
            {
                _expresion3 = "dentro de";
            }
        }

        public void ConstruirExpresion4(bool fechaEntregaMenorActual)
        {
            if (fechaEntregaMenorActual)
            {
                _expresion4 = "tuvo";
            }
            else
            {
                _expresion4 = "tendrá";
            }
        }

        public MensajePedidoDto ObtenerMensaje()
        {

            _mensajePedidoDto.Mensaje = $"Tu paquete {_expresion1} de { _origen} y {_expresion2} a {_destino} {_expresion3} {_rangoTiempo} y " +
                $"{_expresion4} un costo de ${_costoEnvio} (cualquier reclamación con {_paqueteria}) {_opcionEconomica}";

            return _mensajePedidoDto;
        }

        public void AsignarRangoTiempo(string rangoTiempo)
        {
            _rangoTiempo = rangoTiempo;
        }

        public void ConstuirCostoEnvio(string costoEnvio)
        {
            _costoEnvio = costoEnvio.ToString();
        }

        public void AsignarColorMensaje(bool fechaEntregaMenorActual)
        {
            if (fechaEntregaMenorActual)
            {
                _mensajePedidoDto.ColorMensaje = System.ConsoleColor.Yellow;
            }
            else
            {
                _mensajePedidoDto.ColorMensaje = System.ConsoleColor.Green;
            }
        }

        public void Reset()
        {
            _mensajePedidoDto = new MensajePedidoDto();
        }

        public void AgregarOpcionEconomica(string opcion)
        {
            _opcionEconomica = opcion;
        }
    }
}
