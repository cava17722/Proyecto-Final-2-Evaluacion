using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiPrograma.Aplicacion2;

namespace BankTests
{
    [TestClass]
    public class UnitTest2
    {

        /// <summary>
        /// Caso de prueba número 1
        /// Valor minimo
        /// </summary>
        [TestMethod]
        public void PrimoMinimo()
        {

            //escenario
            int NumeroInicial = 1;
            string ResultadoEsperado = "El numero introducido es primo";

            string ResultadoObtenido = "El numero introducido es primo";
           
           //acción
           ResultadoObtenido = Aplicacion2_Logica.FuncionPrimo(NumeroInicial);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
           
        }

        /// <summary>
        /// Caso de prueba número 2
        /// El numero introducido es primo
        /// </summary>
        [TestMethod]
        public void PrimoCorrect()
        {

            //escenario
            int NumeroInicial = 2;
            string ResultadoEsperado = "El numero introducido es primo";

            string ResultadoObtenido = "El numero introducido es primo";

            //acción
            ResultadoObtenido = Aplicacion2_Logica.FuncionPrimo(NumeroInicial);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        /// <summary>
        /// Caso de prueba número 3
        /// El numero introducido es primo
        /// </summary>
        [TestMethod]
        public void PrimoCorrect2()
        {

            //escenario
            int NumeroInicial = 3;
            string ResultadoEsperado = "El numero introducido es primo";

            string ResultadoObtenido = "El numero introducido es primo";

            //acción
            ResultadoObtenido = Aplicacion2_Logica.FuncionPrimo(NumeroInicial);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }
        /// <summary>
        /// Caso de prueba número 4
        /// El numero introducido no es primo
        /// </summary>
        [TestMethod]
        public void PrimoIncorrect()
        {

            //escenario
            int NumeroInicial = 6;
            string ResultadoEsperado = "El numero introducido no es primo";

            string ResultadoObtenido = "El numero introducido no es primo";

            //acción
            ResultadoObtenido = Aplicacion2_Logica.FuncionPrimo(NumeroInicial);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }
        /// <summary>
        /// Caso de prueba número 5
        /// Valor maximo
        /// </summary>
        [TestMethod]
        public void PrimoMaximo()
        {

            //escenario
            int NumeroInicial = 99;
            string ResultadoEsperado = "El numero introducido no es primo";

            string ResultadoObtenido = "El numero introducido no es primo";

            //acción
            ResultadoObtenido = Aplicacion2_Logica.FuncionPrimo(NumeroInicial);


            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }
    }
}
