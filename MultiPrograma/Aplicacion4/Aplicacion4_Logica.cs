using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPrograma.Aplicacion4
{
    public class Aplicacion4_Logica
    {
        /// <summary>
        /// Metodo que recibe un numero entero
        /// </summary>
        /// <remarks>
        /// Si el valor esta entre 0 y 100 entra en el while, se inicializa en 1 y se ejecuta hasta
        /// que llega a 10 y devuelve un texto
        /// </remarks>
        /// <param name="iNumero"> Valor de tipo int recogido por el evento </param>
        public string TablaMultiplicar(int iNumero)
        {
            int iMultiplo;
            int iResultado;
            string sTexto;
            string texto;

            iMultiplo = 1;
            sTexto = "";
            iResultado = 0;

            if (iNumero > 0 && iNumero <= 100)
            {
                while (iMultiplo <= 10)
                {
                    iResultado = iNumero * iMultiplo;
                    sTexto = sTexto + iNumero + " * " + iMultiplo + " = " + iResultado + "\n";
                    iMultiplo++;
                }
                texto = sTexto;
            }
            else
            {
                texto = "El numero no es correcto";
            }
            return texto;
        }
    }
}
