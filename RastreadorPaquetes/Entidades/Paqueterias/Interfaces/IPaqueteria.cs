using Entidades.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Paqueterias.Interfaces
{
    public interface IPaqueteria
    {
        string NombreEmpresa { get;}
        double MargenUtilidad { get;}
        List<IMedioTransporte> MediosTransportes { get; }
        public void AgregarTransporte(IMedioTransporte medioTransporte);
    }
}
