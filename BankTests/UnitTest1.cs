using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiPrograma.Aplicacion1;

namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
       
             /// <summary>
             /// Caso de prueba número 1
             /// Los datos son numeros positivos y espero que me realice la operacion
             /// </summary>
        [TestMethod]
        public void ProductoPositivos()
        {

            //escenario
            int NumInicial = 2;
            int NumInicial2 = 2;
            int ResultadoEsperado = 4;

            int ResultadoObtenido = 4;

            //acción
            ResultadoObtenido = Aplicacion1_Logica.SumaProductos(NumInicial, NumInicial2);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }

        /// <summary>
        /// Caso de prueba número 2
        /// Los datos son numeros negativos y espero que me realice la operación
        /// </summary>
        [TestMethod]
        public void ProductoNegativos()
        {

            //escenario
            int NumInicial = -2;
            int NumInicial2 = -5;
            int ResultadoEsperado = 10;

            int ResultadoObtenido = 10;

            //acción
            ResultadoObtenido = Aplicacion1_Logica.SumaProductos(NumInicial, NumInicial2);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }

        /// <summary>
        /// Caso de prueba número 3
        /// Los datos son numeros positivos y negativos y espero que me realice la operación
        /// </summary>
        [TestMethod]
        public void ProductoPositivosyNegativos()
        {

            //escenario
            int NumInicial = 2;
            int NumInicial2 = -5;
            int ResultadoEsperado = -10;

            int ResultadoObtenido = -10;

            //acción
            ResultadoObtenido = Aplicacion1_Logica.SumaProductos(NumInicial, NumInicial2);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
        /// <summary>
        /// Caso de prueba número 4
        /// Los datos son valores minimos
        /// </summary>
        [TestMethod]
        public void ProductoLimitesMinimo()
        {

            //escenario
            int NumInicial = -99;
            int NumInicial2 = -99;
            int ResultadoEsperado = 9801;

            int ResultadoObtenido = 9801;

            //acción
            ResultadoObtenido = Aplicacion1_Logica.SumaProductos(NumInicial, NumInicial2);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
        /// <summary>
        /// Caso de prueba número 5
        /// Los datos son valores maximos 
        /// </summary>
        [TestMethod]
        public void ProductoLimitesMaximo()
        {

            //escenario
            int NumInicial = 99;
            int NumInicial2 = 99;
            int ResultadoEsperado = 9801;

            int ResultadoObtenido = 9801;

            //acción
            ResultadoObtenido = Aplicacion1_Logica.SumaProductos(NumInicial, NumInicial2);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
        /// <summary>
        /// Caso de prueba número 6
        /// Los datos son valores neutros
        /// </summary>
        [TestMethod]
        public void ProductoNeutro()
        {

            //escenario
            int NumInicial = 0;
            int NumInicial2 = 0;
            int ResultadoEsperado = 0;

            int ResultadoObtenido = 0;

            //acción
            ResultadoObtenido = Aplicacion1_Logica.SumaProductos(NumInicial, NumInicial2);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
    }
}
