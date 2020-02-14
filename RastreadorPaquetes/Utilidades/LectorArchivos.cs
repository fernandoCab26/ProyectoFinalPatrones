using System;
using System.IO;
using Utilidades.Interfaces;

namespace Utilidades
{
    public class LectorArchivos :ILectorArchivos
    {
        private string RutaPedidos = AppDomain.CurrentDomain.BaseDirectory + "Pedidos.txt";

        public string[] ObtenerContenidoArchivo()
        {
            StreamReader file = new StreamReader(RutaPedidos);
            var fileContent = file.ReadToEnd().Split(Environment.NewLine,
                              StringSplitOptions.RemoveEmptyEntries);
            file.Dispose();
            return fileContent;
        }
    }
}
