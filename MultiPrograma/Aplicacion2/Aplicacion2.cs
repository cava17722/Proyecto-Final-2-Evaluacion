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
        /// Evento que recoge un numero entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBotonPrimo_Click(object sender, EventArgs e)
        {
            int iNumero;
            string texto;

            iNumero = int.Parse(TNumero.Text);
            texto = Aplicacion2_Logica.FuncionPrimo(iNumero);
            if (iNumero > 0)
            {
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("Vuelva a intentarlo con los valores permitidos por la aplicación. Valores mayores a 0"); 
            }
        }
    }
    
}
