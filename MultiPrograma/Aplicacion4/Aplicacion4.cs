using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPrograma.Aplicacion4
{
    public partial class Aplicacion4 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public Aplicacion4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo que recibe un numero entero
        /// </summary>
        /// <remarks>
        /// Si el valor esta entre 0 y 100 entra en el while, se inicializa en 1 y se ejecuta hasta
        /// que llega a 10 y devuelve un texto
        /// </remarks>
        /// <param name="iNumero"> Valor de tipo int recogido por el evento </param>
        void TablaMultiplicar (int iNumero)
        {
            int iMultiplo;
            int iResultado;
            string sTexto;

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
                MessageBox.Show(sTexto);
            }
            else
            {
                MessageBox.Show("El numero no es correcto");
            }
        }
        /// <summary>
        /// Evento que recoge un numero entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBotonTabla_Click(object sender, EventArgs e)
        {
            int iNumero;
            iNumero = int.Parse(TNumTabla.Text);
            TablaMultiplicar(iNumero);
        }
    }
}
