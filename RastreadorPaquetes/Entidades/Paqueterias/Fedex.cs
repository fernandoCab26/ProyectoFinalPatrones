using Entidades.Paqueterias.Interfaces;
using Entidades.Transportes;
using Entidades.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Paqueterias
{
    public class Fedex : IPaqueteria
    {
        private readonly string _nombre = "Fedex";
        private readonly double _margenUrilidad = 50;
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
