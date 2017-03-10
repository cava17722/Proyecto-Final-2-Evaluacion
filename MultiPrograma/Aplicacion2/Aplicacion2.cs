using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPrograma.Aplicacion2
{
    public partial class Aplicacion2 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public Aplicacion2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo que recibe un numero entero
        /// </summary>
        /// <remarks> 
        /// El for se inicializa en 2 y se ejecuta mientra el 2 sea menor al numero introducido, 
        /// devuelve bool false o true si es o no es primo
        /// </remarks>
        /// <param name="iNumero"> Valor de tipo int recogido por el evento </param>
        void FuncionPrimo (int iNumero)
        {
            bool bPrimo;

            bPrimo = true;

            for (int i = 2; i < iNumero; i++)
            {
                if (iNumero % i == 0)
                {
                    bPrimo = false;
                }
            }
            if (bPrimo == true)
            {
                MessageBox.Show("El numero introducido es primo");
            }
            else
            {
                MessageBox.Show("El numero introducido no es primo");
            }
        }
        /// <summary>
        /// Evento que recoge un numero entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBotonPrimo_Click(object sender, EventArgs e)
        {
            int iNumero;
            iNumero = int.Parse(TNumero.Text);
            FuncionPrimo(iNumero);
        }
    }
}
