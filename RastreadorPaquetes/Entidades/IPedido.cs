using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface IPedido
    {
        string Destino { get; set; }
        double Distancia { get; set; }
        DateTime FechaPedido { get; set; }
        string MedioTransporte { get; set; }
        string Origen { get; set; }
        string Paqueteria { get; set; }
    }
}
