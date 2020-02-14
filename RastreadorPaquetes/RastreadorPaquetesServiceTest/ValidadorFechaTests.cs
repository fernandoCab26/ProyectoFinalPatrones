using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreadorPaquetesService;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Tests
{
    [TestClass()]
    public class ValidadorFechaTests
    {

        [TestMethod]
        public void ValidarFechaActualTest_FechaMenorActual_DevuelveTrue()
        {
            //Arrange
            ValidadorFecha validadorFecha = new ValidadorFecha();
            DateTime fechamenor = DateTime.Now.AddDays(-1);
            //Act
           bool act =validadorFecha.ValidarFechaActual(fechamenor);
            //Assert
            Assert.IsTrue(act);
        }

        [TestMethod]
        public void ValidarFechaActualTest_FechaMenorActual_DevuelveFalse()
        {
            //Arrange
            ValidadorFecha validadorFecha = new ValidadorFecha();
            DateTime fechamenor = DateTime.Now.AddDays(1);
            //Act
            bool act = validadorFecha.ValidarFechaActual(fechamenor);
            //Assert
            Assert.IsFalse(act);
        }

    }
}