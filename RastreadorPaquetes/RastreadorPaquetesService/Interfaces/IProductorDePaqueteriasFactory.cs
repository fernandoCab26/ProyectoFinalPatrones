using Entidades.Paqueterias.Interfaces;
using RastreadorPaquetesService.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Interfaces
{
    public interface IProductorDePaqueteriasFactory
    {
        IPaqueteria CrearPaqueteria(string nombrePaqueteria);
    }
}
