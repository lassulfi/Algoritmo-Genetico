using System;
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
    public partial class TesteCrossover : Form
    {

        AlgoritmoGeneticoImpl ag = new AlgoritmoGeneticoImpl(0.8, 0.01);
        Populacao pop = new Populacao();

        public TesteCrossover()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            Individuo pai = new Individuo();
            Individuo mae = new Individuo();

            txtPai.Text = pai.PrintIndividuo();
            txtMae.Text = mae.PrintIndividuo();

            Individuo[] filhos = ag.Crossover(pai, mae);

            txtFilhoPai.Text = filhos[0].PrintIndividuo();
            txtFilhoMae.Text = filhos[1].PrintIndividuo();

            

            txtPop.Text = ag.ExecutaAG(pop).PrintPop();
        }

        private void btnIterar_Click(object sender, EventArgs e)
        {
            pop = ag.ExecutaAG(pop);
            txtPop.Text = pop.PrintPop();
            lblMedia.Text = pop.GetMediaPopulacao().ToString();
        }
    }
}
