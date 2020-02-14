using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RastreadorPaquetesService;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Tests
{
    [TestClass()]
    public class CreadorDetallesPedidoTests
    {

        [TestMethod]
        public void CrearDetallesPedido_EjecucionMetodo_DevuelveDetallesPedido()
        {
            //Arrange
            Mock<IPedido> pedido = new Mock<IPedido>();
            //Act
            //Assert
        }

    }
}