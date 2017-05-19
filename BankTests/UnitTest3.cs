using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiPrograma.Aplicacion3;

namespace BankTests
{
    [TestClass]
    public class UnitTest3
    {
        /// <summary>
        /// Caso de prueba número 1
        /// Intoducimos un numero mayor a 0 y esperamos que nos devuelva correctamente el resultado
        /// Valor minimo
        /// </summary>
        [TestMethod]
        public void SerieMinimo()
        {

            //escenario
            int NumeroInicial = 1;
            string ResultadoEsperado = "1";

            string ResultadoObtenido = "1";
            Aplicacion3_Logica serie = new Aplicacion3_Logica();

            //acción
            serie.Serie(NumeroInicial);

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        /// <summary>
        /// Caso de prueba número 2
        /// Intoducimos un numero mayor a 0 y esperamos que nos devuelva correctamente el resultado
        /// </summary>
        [TestMethod]
        public void SerieCorrect()
        {

            //escenario
            int NumeroInicial = 4;
            string ResultadoEsperado = "0.583...";

            string ResultadoObtenido = "0.583...";
            Aplicacion3_Logica serie = new Aplicacion3_Logica();

            //acción
            serie.Serie(NumeroInicial);

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
        /// <summary>
        /// Caso de prueba número 3
        /// Intoducimos un numero mayor a 0 y esperamos que nos devuelva correctamente el resultado
        /// Valor maximo
        /// </summary>
        [TestMethod]
        public void SerieMaximos()
        {

            //escenario
            int NumeroInicial = 99;
            string ResultadoEsperado = "0.698...";

            string ResultadoObtenido = "0.698...";
            Aplicacion3_Logica serie = new Aplicacion3_Logica();

            //acción
            serie.Serie(NumeroInicial);

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
    }
}
