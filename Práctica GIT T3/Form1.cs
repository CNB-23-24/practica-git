﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Práctica_GIT_T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
                string textoTelegrama;
                char tipoTelegrama = ' ';
                double coste;
                
                textoTelegrama = txtTelegrama.Text;
                String[]palabras=textoTelegrama.Split(' ');
                int numPalabras = palabras.Length;

                if (cbUrgente.Checked)
                    tipoTelegrama = 'u';
                
                if (tipoTelegrama == 'u')
                    if (numPalabras <= 10)
                        coste = 5;
                    else
                        coste = 5 + 0.75 * (numPalabras - 10);
                else
                    if (numPalabras <= 10)
                    coste = 2.5;
                    else 
                    coste = 2.5 + 0.5 * (numPalabras - 10); 

                txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}