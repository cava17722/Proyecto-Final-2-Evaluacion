﻿using System;
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
        public Aplicacion3()
        {
            InitializeComponent();
        }

        void Serie (int iNumero)
        {
            int i;
            double dSuma;
            double dResta;
            double dResultado;

            i = 1;
            dSuma = 0;
            dResta = 0;

            while (i <= iNumero)
            {
                if (i % 2 == 0)
                {
                    dResta = dResta - (1.0 / i);
                }
                else
                {
                    dSuma = dSuma + (1.0 / i);
                }
                i++;
            }
            dResultado = dSuma + dResta;
            MessageBox.Show("El valor de la serie hasta el numero introducido es: " + dResultado);
        }
        private void BBotonSerie_Click(object sender, EventArgs e)
        {
            int iNumero;
            iNumero = int.Parse(TNumero.Text);
            Serie(iNumero);
        }
    }
}