using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPrograma.Aplicacion3
{
    public class Aplicacion3_Logica
    {
        /// <summary>
        /// Metodo que recibe un numero entero
        /// </summary>
        /// <remarks> 
        /// El for se inicializa en 1 y se ejecuta mientras i sea menor al numero introducido, 
        /// devuelve el resultado de la serie
        /// </remarks>
        /// <param name="iNumero"> Valor de tipo int recogido por el evento </param>
        public string Serie(int iNumero)
        {
            int i;
            double dSuma;
            double dResta;
            double dResultado;
            string texto;

            i = 1;
            dSuma = 0;
            dResta = 0;

            while (i <= iNumero)
            {
                if (i % 2 == 0)
                {
                    dResta = dResta - (1.0 / i);
                }
                else
                {
                    dSuma = dSuma + (1.0 / i);
                }
                i++;
            }
            dResultado = dSuma + dResta;
            texto = "El valor de la serie hasta el numero introducido es: " + dResultado;
            return texto;
        }
    }
}
