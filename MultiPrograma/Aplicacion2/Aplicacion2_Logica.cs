using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// namespace de la aplicación2
/// </summary>
namespace MultiPrograma.Aplicacion2
{
        /// <summary>
        /// clase que ejecuta la lógica de la aplicación 2
        /// </summary>

        public static class Aplicacion2_Logica
        {
            /// <summary>
            /// Metodo que recibe un numero entero
            /// </summary>
            /// <remarks> 
            /// El for se inicializa en 2 y se ejecuta mientra el 2 sea menor al numero introducido, 
            /// devuelve bool false o true si es o no es primo
            /// </remarks>
            /// <param name="iNumero"> Valor de tipo int recogido por el evento </param>
            public static string FuncionPrimo(int iNumero)
            {
                bool bPrimo;
                string texto;
                bPrimo = true;
                texto = "";
                for (int i = 2; i < iNumero; i++)
                {
                    if (iNumero % i == 0)
                    {
                        bPrimo = false;
                    }
                }
                if (bPrimo == true)
                {
                    texto = ("El numero introducido es primo");
                }
                else
                {
                    texto = ("El numero introducido no es primo");
                }
                return texto;
            }
        }
    
}
