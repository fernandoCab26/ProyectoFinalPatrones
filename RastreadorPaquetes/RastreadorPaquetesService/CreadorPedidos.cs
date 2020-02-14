using Entidades;
using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using Utilidades.Interfaces;

namespace RastreadorPaquetesService
{
    public class CreadorPedidos : ICreadorPedidos
    {
        private readonly ILectorArchivos _lectorArchivos;

        public CreadorPedidos(ILectorArchivos lectorArchivos)
        {
            _lectorArchivos = lectorArchivos;
        }

        public List<IPedido> CrearPedido()
        {
            List<IPedido> pedidos = new List<IPedido>();
            try
            {
                
                string[] lineasArchivo = _lectorArchivos.ObtenerContenidoArchivo();

                foreach (string linea in lineasArchivo)
                {
                    Pedido pedido = new Pedido();
                    string[] textoArchivo= linea.Split(',');
                    pedido.Origen = textoArchivo[0];
                    pedido.Destino = textoArchivo[1];
                    pedido.Distancia = double.Parse(textoArchivo[2]);
                    pedido.Paqueteria = textoArchivo[3];
                    pedido.MedioTransporte = textoArchivo[4];
                    pedido.FechaPedido = DateTime.Parse(textoArchivo[5]);

                    pedidos.Add(pedido);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Formato de texto inválido {ex.Message } ");
            }

            return pedidos;
        }
    }
}
