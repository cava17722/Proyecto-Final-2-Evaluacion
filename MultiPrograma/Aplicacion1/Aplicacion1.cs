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
       
        Aplicacion_1 oAplicacion1 = new Aplicacion_1();
        public Aplicacion1()
        {
            InitializeComponent();
        }
       
        void SumaProductos (int iNum, int iNumDos)
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
            MessageBox.Show("El producto de los numeros es: " + iNumero1 + " * " + iNumero2 + " = " + sTexto + " = " + iSuma);
        }
        private void BBotonMulti_Click(object sender, EventArgs e)
        {
            int iNum;
            int iNumDos;

            iNum = int.Parse(TNumero.Text);
            iNumDos = int.Parse(TNumero2.Text);
            SumaProductos(iNum, iNumDos);
        }
    }
}
