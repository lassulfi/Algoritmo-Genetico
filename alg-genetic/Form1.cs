﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.Class;

namespace AlgoritmoGenetico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Individuo ind = new Individuo();

            txtIndividuo.Text = ind.PrintIndividuo();

            Populacao pop = new Populacao();

            txtPopulacao.Text = pop.PrintPop();
        }
    }
}
