using Entidades.Paqueterias.Interfaces;
using Entidades.Transportes;
using Entidades.Transportes.Interfaces;
using System.Collections.Generic;

namespace Entidades.Paqueterias
{
    public class Dhl : IPaqueteria
    {
        private readonly string _nombre = "DHL";
        private readonly double _margenUrilidad = 40;
        private readonly List<IMedioTransporte> _mediosTransportes = new List<IMedioTransporte>();
        public string NombreEmpresa => _nombre;

        public double MargenUtilidad => _margenUrilidad;

        public List<IMedioTransporte> MediosTransportes => _mediosTransportes;

        public void AgregarTransporte(IMedioTransporte medioTransporte)
        {
            _mediosTransportes.Add(medioTransporte);
        }
    }
}
