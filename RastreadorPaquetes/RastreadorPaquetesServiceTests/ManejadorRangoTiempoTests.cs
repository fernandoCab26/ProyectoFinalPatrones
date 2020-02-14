using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreadorPaquetesService;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreadorPaquetesService.Tests
{
    [TestClass()]
    public class ManejadorRangoTiempoTests
    {
        [TestMethod]
        [DataRow("06/02/2020 00:20:30", "06/02/2020 00:40:30", 20)]
        [DataRow("06/02/2020 00:40:30", "06/02/2020 00:15:30", 25)]
        [DataRow("06/02/2020 00:00:30", "06/02/2020 00:59:30", 59)]
        public void ObtenerRangoTiempo_DifEnMinutos_DevuelveMensajeMinutos(string sfechaEvento, string sfechaActual, int diferencia)
        {
            //Arrange
            string expected = diferencia + " minutos.";
            DateTime fechaEvento = DateTime.Parse(sfechaEvento);
            DateTime fechaActual = DateTime.Parse(sfechaActual);
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            string act = ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual);
            //Assert
            Assert.AreEqual(expected, act);
        }


        [TestMethod]
        [DataRow("06/02/2020 01:20:30", "06/02/2020 02:40:30", 1)]
        [DataRow("06/02/2020 01:40:30", "06/02/2020 03:40:30", 2)]
        [DataRow("07/02/2020 00:00:00", "06/02/2020 00:00:01", 23)]
        public void ObtenerRangoTiempo_DifEnHoras_DevuelveMensajeHoras(string sfechaEvento, string sfechaActual, int diferencia)
        {
            //Arrange
            string expected = diferencia + " horas.";
            DateTime fechaEvento = DateTime.Parse(sfechaEvento);
            DateTime fechaActual = DateTime.Parse(sfechaActual);
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            string act = ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        [DataRow("07/02/2020 00:00:00", "06/02/2020 00:00:00", 1)]
        [DataRow("08/02/2020 04:40:30", "06/02/2020 03:40:30", 2)]
        [DataRow("01/03/2020 00:00:00", "31/03/2020 00:00:00", 30)]
        public void ObtenerRangoTiempo_DifEnDias_DevuelveMensajeDias(string sfechaEvento, string sfechaActual, int diferencia)
        {
            //Arrange
            string expected = diferencia + " días.";
            DateTime fechaEvento = DateTime.Parse(sfechaEvento);
            DateTime fechaActual = DateTime.Parse(sfechaActual);
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            string act = ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        [DataRow("07/03/2020 00:00:00", "06/04/2020 00:00:00", 1)]
        [DataRow("08/04/2020 04:40:30", "06/02/2020 03:40:30", 2)]
        [DataRow("01/03/2021 00:00:00", "31/03/2020 00:00:00", 12)]
        public void ObtenerRangoTiempo_DifEnMeses_DevuelveMensajeMeses(string sfechaEvento, string sfechaActual, int diferencia)
        {
            //Arrange
            string expected = diferencia + " meses.";
            DateTime fechaEvento = DateTime.Parse(sfechaEvento);
            DateTime fechaActual = DateTime.Parse(sfechaActual);
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            string act = ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual);
            //Assert
            Assert.AreEqual(expected, act);
        }


        [TestMethod]
        public void ObtenerRangoTiempo_FechaEventoInvalida_LanzaExcepcion()
        {
            //Arrange
            DateTime fechaEvento = new DateTime();
            DateTime fechaActual = DateTime.Now;
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual));
        }

        [TestMethod]
        public void ObtenerRangoTiempo_FechaEventoInvalida_DevuelveMensajeEnExcepcion()
        {
            //Arrange
            string message = "El formato de fecha es inválido";
            DateTime fechaEvento = new DateTime();
            DateTime fechaActual = DateTime.Now;
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            //Assert
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(() => ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual));
            Assert.AreEqual(message, exception.Message);
        }

        [TestMethod]
        public void ObtenerRangoTiempo_FechaActualInvalida_LanzaExcepcion()
        {
            //Arrange
            DateTime fechaActual = new DateTime();
            DateTime fechaEvento = DateTime.Now;
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual));
        }

        [TestMethod]
        public void ObtenerRangoTiempo_FechaActualInvalida_DevuelveMensajeEnExcepcion()
        {
            //Arrange
            string message = "El formato de fecha es inválido";
            DateTime fechaEvento = DateTime.Now;
            DateTime fechaActual = new DateTime();
            ManejadorRangoTiempo ManejadorRangoTiempo = new ManejadorRangoTiempo();
            //Act
            //Assert
            ArgumentException exception = Assert.ThrowsException<ArgumentException>(() => ManejadorRangoTiempo.ObtenerRangoTiempo(fechaEvento, fechaActual));
            Assert.AreEqual(message, exception.Message);
        }
    }
}