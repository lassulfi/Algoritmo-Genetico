using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.Class;
using ZedGraph;

namespace AlgoritmoGenetico
{
    public partial class TelaPrincipal : Form
    {
        //Atributos
        private Populacao pop;

        //ZedGraph
        private GraphPane panePop;
        private GraphPane paneMedia;

        //Pares de pontos
        private PointPairList curvaGrafico = new PointPairList();
        private PointPairList populacaoGrafico = new PointPairList();
        private PointPairList mediaPopulacao = new PointPairList();

        public TelaPrincipal()
        {
            InitializeComponent();

            //Desabilita o botão para executar o algoritmo genetico
            btnExecutarAG.Enabled = false;

            //Configuraçao dos gráficos
            panePop = zedPopulacao.GraphPane;
            panePop.Title.Text = "Evolução";
            panePop.XAxis.Title.Text = "Gerações";
            panePop.YAxis.Title.Text = "Indivíduos";
            zedPopulacao.Refresh();

            paneMedia = zedMediaPopulacao.GraphPane;
            paneMedia.Title.Text = "Média da população";
            paneMedia.XAxis.Title.Text = "Gerações";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMediaPopulacao.Refresh();

            //plotagem do gráfico da população
            for (int i = 0; i < Constants.functionXSize; i++)
            {
                curvaGrafico.Add(i, Constants.function1(i));
            }

            LineItem func = panePop.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);

            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();

            zedMediaPopulacao.AxisChange();
            zedMediaPopulacao.Invalidate();
            zedMediaPopulacao.Refresh();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            //Habilita o botão para executar o algoritmo genético
            btnExecutarAG.Enabled = true;
            
            //Instancia uma nova população
            pop = new Populacao();

            populacaoGrafico = new PointPairList();

            for (int i = 0; i < Constants.sizePopulacao; i++)
            {
                populacaoGrafico.Add(pop.GetPopulacao()[i].GetInt(), pop.GetPopulacao()[i].GetFitness());
            }

            LineItem inds = panePop.AddStick("Indivíduos", populacaoGrafico, Color.Blue);

            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();
        }

        private void btnExecutarAG_Click(object sender, EventArgs e)
        {
            //Recupera os elementos das textbox
            double taxaMutacao = double.Parse(txtTaxaMutacao.Text);
            double taxaCrossover = double.Parse(txtTaxaCrossover.Text);
            int iteracoes = int.Parse(txtEvolucoes.Text);

            //Instancia do algoritmo genetico
            AlgoritmoGeneticoImpl ag = new AlgoritmoGeneticoImpl(taxaCrossover, taxaMutacao);

            for (int i = 0; i < iteracoes; i++)
            {
                pop = ag.ExecutaAG(pop);

                //Adicionando os pontos ao gráfico
                mediaPopulacao.Add(i, pop.GetMediaPopulacao());

                zedMediaPopulacao.GraphPane.CurveList.Clear();
                zedMediaPopulacao.GraphPane.GraphObjList.Clear();

                zedPopulacao.GraphPane.CurveList.Clear();
                zedPopulacao.GraphPane.GraphObjList.Clear();

                populacaoGrafico = new PointPairList();
                for (int j = 0; j < Constants.sizePopulacao; j++)
                {
                    populacaoGrafico.Add(pop.GetPopulacao()[j].GetInt(), pop.GetPopulacao()[j].GetFitness());
                }

                LineItem media = paneMedia.AddCurve("Média", mediaPopulacao, Color.Red, SymbolType.None);
                LineItem func = panePop.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);
                LineItem indv = panePop.AddStick("Indivíduo", populacaoGrafico, Color.Blue);

                zedPopulacao.AxisChange();
                zedPopulacao.Invalidate();
                zedPopulacao.Refresh();

                zedMediaPopulacao.AxisChange();
                zedMediaPopulacao.Invalidate();
                zedMediaPopulacao.Refresh();
            }

            //Seleção dos melhores e piores individuos
            pop.OrdenarPopulacao();

            //Piores individuos
            string pioresInd = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                pioresInd += pop.GetPopulacao()[i].PrintIndividuo() + "\n";
            }

            txtPioresIndividuos.Text = pioresInd;

            string melhoresInd = string.Empty;
            for (int i = Constants.sizePopulacao - 1; i > (Constants.sizePopulacao -1 ) - 10; i--)
            {
                melhoresInd += pop.GetPopulacao()[i].PrintIndividuo() + "\n";
            }

            txtMelhoresIndividuos.Text = melhoresInd;

        }
    }
}
