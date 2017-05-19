using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Caso de prueba número 2
        /// Los datos son correctos y espero que me de que es palíndromo
        /// </summary>
        [TestMethod]
        public void PalinCorrect()
        {

            //escenario
            string TextoInicial = "anna";
            string InversoEsperado = "anna";
            bool ResultadoEsperado = true;

            string InversoObtenido = "";
            bool ResultadoObtenido = false;

            //acción
            ResultadoObtenido = Aplicacion.EsPalindromo(TextoInicial, out InversoObtenido);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
            Assert.AreEqual(InversoEsperado, InversoObtenido);


        }
    }
}
