using CeibaEstacionamientoGjmg.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasDeIntegracionEstacionamiento
{
    [TestClass]
    public class PruebasIntegracionEstacionamiento
    {
        private IConsultasEstacionemiento consultasEstacionemiento;
        private IProcesoIngreso procesoIngreso;
        private IProcesoSalida procesoSalida;

        [TestInitialize]
        public void Inicializador()
        {
            consultasEstacionemiento = new ConsultasEstacionemiento();
            procesoIngreso = new ProcesoIngreso();
            procesoSalida = new ProcesoSalida();
        }

        [TestMethod]
        public void ComprobarSiHayDisponivilidad()
        {
            Assert.IsTrue(consultasEstacionemiento.OcupacionEstacionamiento("Carro"));
        }

        [TestMethod]
        public void ComprobarSiPlacaEsIgualARestriccion()
        {
            Assert.IsTrue(procesoIngreso.VerificarPlaca("azz123"));
        }

        [TestMethod]
        public void ComprobarSiPlacaEsDiferenteDeRestriccion()
        {
            Assert.IsFalse(procesoIngreso.VerificarPlaca("bcd875"));
        }

        [TestMethod]
        public void ComprobarSiDiaNoAplicaRestriccion()
        {
            Assert.IsTrue(procesoIngreso.VerificarDia(DayOfWeek.Tuesday));
        }

        [TestMethod]
        public void ComprobarSiDiaAplicaRestriccion()
        {
            Assert.IsFalse(procesoIngreso.VerificarDia(DayOfWeek.Monday));
        }

        //Cilindraje, tipo, placa

        [TestMethod]
        public void ComprobarRegistroVehiculoExitoso()
        {
            Assert.IsTrue(procesoIngreso.ParametrosRegistroVehiculo(0, 2, "hjn765"));
        }

        [TestMethod]
        public void ComprobarRegistroComprobanteExitoso()
        {
            DateTime fechaIngreso = DateTime.Now;

            DateTime fechaSalida = DateTime.Now;

            Assert.IsTrue(procesoIngreso.parametrosRegistroComprobante(false, fechaIngreso, fechaSalida, 5, 0, 0));
        }

        [TestMethod]
        public void ComprobarConteoHoras()
        {
            DateTime fechaIngreso = new DateTime(2018, 3, 6, 15, 30, 0);

            DateTime fechaSalida = DateTime.Now;

            Assert.IsTrue(procesoSalida.ContarHoras(fechaIngreso, fechaSalida));
        }

        [TestMethod]
        public void ComprobarConsultaUltimoRegistro()
        {
            Assert.IsTrue();
        }
    }
}
