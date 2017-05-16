using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPrograma.Aplicacion3
{
    public partial class Aplicacion3 : Form
    {

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public Aplicacion3()
        {
            InitializeComponent();
        }
        Aplicacion3_Logica SerieNumeros  = new Aplicacion3_Logica();
        
        /// <summary>
        /// Evento que recoge un numero entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBotonSerie_Click(object sender, EventArgs e)
        {
            int iNumero;
            string texto;
            iNumero = int.Parse(TNumero.Text);
            texto = SerieNumeros.Serie(iNumero);
            MessageBox.Show(texto);
        }
    }
}
