using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiPrograma.Aplicacion4;

namespace BankTests
{
    [TestClass]
    public class UnitTest4
    {
        /// <summary>
        /// Caso de prueba número 1
        /// Intoducimos un numero mayor a 0 y menor o igual a 100 y esperamos que nos devuelva correctamente el resultado
        /// Valor minimo
        /// </summary>
        [TestMethod]
        public void TablaMultiMinimo()
        {

            //escenario
            int NumeroInicial = 1;
            string ResultadoEsperado = "Tabla del 1";

            string ResultadoObtenido = "Tabla del 1";
            Aplicacion4_Logica tabla = new Aplicacion4_Logica();

            //acción
            tabla.TablaMultiplicar(NumeroInicial);

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        /// <summary>
        /// Caso de prueba número 2
        /// Intoducimos un numero mayor a 0 y menor o igual a 100 y esperamos que nos devuelva correctamente el resultado
        /// </summary>
        [TestMethod]
        public void TablaMultiCorrect()
        {

            //escenario
            int NumeroInicial = 8;
            string ResultadoEsperado = "Tabla del 8";

            string ResultadoObtenido = "Tabla del 8";
            Aplicacion4_Logica tabla = new Aplicacion4_Logica();

            //acción
            tabla.TablaMultiplicar(NumeroInicial);

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
        /// <summary>
        /// Caso de prueba número 3
        /// Intoducimos un numero mayor a 0 y menor o igual a 100 y esperamos que nos devuelva correctamente el resultado
        /// Valor maximo
        /// </summary>
        [TestMethod]
        public void TablaMultiMaximo()
        {

            //escenario
            int NumeroInicial = 100;
            string ResultadoEsperado = "Tabla del 100";

            string ResultadoObtenido = "Tabla del 100";
            Aplicacion4_Logica tabla = new Aplicacion4_Logica();

            //acción
            tabla.TablaMultiplicar(NumeroInicial);

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
    }
}
