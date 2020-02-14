using Entidades.Paqueterias.Interfaces;
using Entidades.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Factory
{
    public abstract class PaqueteriasFactory
    {
        private readonly List<IMedioTransporte> _mediosTransportes = new List<IMedioTransporte>();
        public abstract IPaqueteria CrearPaqueteria();

        public List<IMedioTransporte> MediosTransportes => _mediosTransportes;

        public void AgregarMedioTransporte(IMedioTransporte medioTransporte)
        {
            _mediosTransportes.Add(medioTransporte);
        }
    }
}
