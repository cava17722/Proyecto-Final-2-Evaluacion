using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// namespace de la aplicación1
/// </summary>

namespace MultiPrograma.Aplicacion1
{
    /// <summary>
    /// clase que ejecuta la lógica de la aplicación 1
    /// </summary>
    public static class Aplicacion1_Logica
    {
        /// <summary>
        /// Metodo que recibe dos numeros positivos o negativos
        /// </summary>
        /// <remarks> Se comprueba si es negativo o positivo y realiza la sucesion de sumas para obtener el producto</remarks>
        /// <param name="iNum"> Valor de tipo int recogido por el evento </param>
        /// <param name="iNumDos"> Valor de tipo int recogido por el evento </param>
        public static int SumaProductos(int iNum, int iNumDos)
        {
            int iNumero1;
            int iNumero2;
            int iSuma;
            string sTexto;

            iSuma = 0;
            sTexto = "";

            iNumero1 = iNum;
            iNumero2 = iNumDos;

            if (iNum >= 0)
            {
                while (iNum >= 1)
                {
                    iSuma = iSuma + iNumDos;
                    sTexto = sTexto + " ( " + iNumDos + " ) " + " + ";
                    iNum--;
                }
            }
            else
            {
                while (iNum <= -1)
                {
                    iSuma = iSuma + -(iNumDos);
                    sTexto = sTexto + " ( " + iNumDos + " ) " + " + ";
                    iNum++;
                }
            }
            return iSuma;

        }
    }
        
}
