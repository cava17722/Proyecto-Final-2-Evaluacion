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
        Aplicacion_2 oAplicacion2 = new Aplicacion_2();
        public Aplicacion2()
        {
            InitializeComponent();
        }

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
        private void BBotonPrimo_Click(object sender, EventArgs e)
        {
            int iNumero;
            iNumero = int.Parse(TNumero.Text);
            FuncionPrimo(iNumero);
        }
    }
}
