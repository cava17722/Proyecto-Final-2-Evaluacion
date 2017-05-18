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
        Aplicacion4_Logica Tabla = new Aplicacion4_Logica();
        
        /// <summary>
        /// Evento que recoge un numero entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBotonTabla_Click(object sender, EventArgs e)
        {
            int iNumero;
            string texto;
            iNumero = int.Parse(TNumTabla.Text);
            texto = Tabla.TablaMultiplicar(iNumero);
            if (iNumero > 0 && iNumero <= 100)
            {
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("El número no esta comprendido entre los valores que permite la aplicacion. Vuelva a intentarlo con los valores permitidos");
            }
        }
    }
}
