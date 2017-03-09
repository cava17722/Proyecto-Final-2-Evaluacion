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
        public Aplicacion4()
        {
            InitializeComponent();
        }
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
        private void BBotonTabla_Click(object sender, EventArgs e)
        {
            int iNumero;
            iNumero = int.Parse(TNumTabla.Text);
            TablaMultiplicar(iNumero);
        }
    }
}
