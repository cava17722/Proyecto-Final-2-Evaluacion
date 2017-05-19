using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPrograma.Aplicacion1
{
    public partial class Aplicacion1 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public Aplicacion1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que recoge dos numeros positivos o negativos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBotonMulti_Click(object sender, EventArgs e)
        {

            int iNum;
            int iNumDos;
            int iSuma;
            iNum = int.Parse(TNumero.Text);
            iNumDos = int.Parse(TNumero2.Text);
            Aplicacion1_Logica.SumaProductos(iNum, iNumDos);
            iSuma = Aplicacion1_Logica.SumaProductos(iNum, iNumDos);
            if (iNum < 100 && iNumDos < 100)
            {
                MessageBox.Show("El producto de los numeros es: " + iNum + " * " + iNumDos + " = " + iSuma);

            }
            else
            {
                MessageBox.Show("Introduce numeros menores a 100");
            }
        }
    }
}
