using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// llama a la aplicación1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Aplicacion1.Aplicacion1 oFormulario = new Aplicacion1.Aplicacion1();
            oFormulario.ShowDialog();

        }
        /// <summary>
        /// llama a la aplicacion2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Aplicacion2.Aplicacion2 oFormulario = new Aplicacion2.Aplicacion2();
            oFormulario.ShowDialog();

        }
        /// <summary>
        /// llama a la aplicacion3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Aplicacion3.Aplicacion3 oFormulario = new Aplicacion3.Aplicacion3();
            oFormulario.ShowDialog();

        }
        /// <summary>
        /// llama a la aplicacion4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Aplicacion4.Aplicacion4 oFormulario = new Aplicacion4.Aplicacion4();
            oFormulario.ShowDialog();

        }
    }
}
