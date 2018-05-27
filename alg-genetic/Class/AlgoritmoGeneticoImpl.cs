using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.Class
{
    public class AlgoritmoGeneticoImpl
    {

        //Atributos
        private double taxaCrossover;
        private double taxaMutacao;

        static int PAI = 0;
        static int MAE = 1;

        //Construtor
        public AlgoritmoGeneticoImpl(double taxaCrossover, double taxaMutacao)
        {
            this.taxaCrossover = taxaCrossover;
            this.taxaMutacao = taxaMutacao;
        }

        //Métodos

        /*
         * Método que executa o algoritmo genétrico
         */
         public Populacao ExecutaAG(Populacao pop)
        {

            //Início do algoritmo genético

            //Avaliação da população
            Populacao novaPopulacao = new Populacao();
            List<Individuo> popBuffer = new List<Individuo>();

            for (int i = 0; i < Constants.sizePopulacao / 2; i++)
            {
                //Selecionar os pais para cruzamento
                Individuo pai = Roleta(pop);
                Individuo mae = Roleta(pop);

                //Realizar cruzamento
                Individuo[] filhos = Crossover(pai, mae);

                //Aplicar mutação
                Individuo filhoA = Mutacao(filhos[0]);
                Individuo filhoB = Mutacao(filhos[1]);

                popBuffer.Add(filhoA);
                popBuffer.Add(filhoB);
            }

            //Apagar velhos membros
            //Inserir novos membros
            for (int i = 0; i < Constants.sizePopulacao; i++)
            {
                novaPopulacao.SetIndividuo(i, popBuffer[i]);
            }
            popBuffer = null;

            //reavaliar a população
            novaPopulacao.AtualizarValores();

            return novaPopulacao;
        }

        /*
         * Realiza o cruzamento (crossover) entre individuos
         */
        public Individuo[] Crossover(Individuo pai, Individuo mae)
        {
            Individuo[] novoInd = new Individuo[2];

            //Ponto de corte dos cromossos dos individuos
            int pontoDeCorte = Constants.random.Next(0, Constants.sizeCromossomo - 1);

            //Individuos pai e mãe auxiliares
            Individuo paiBuffer = new Individuo();
            Individuo maeBuffer = new Individuo();

            novoInd[PAI] = new Individuo();
            novoInd[MAE] = new Individuo();

            for(int i = 0; i < Constants.sizeCromossomo; i++)
            {
                paiBuffer.SetGene(i, pai.GetGene(i));
                maeBuffer.SetGene(i, mae.GetGene(i));

                //Define inicialmente para evitar perda de referencia na memoria devido ao C#
                novoInd[PAI].SetGene(i, pai.GetGene(i));
                novoInd[MAE].SetGene(i, mae.GetGene(i));
            }

            //Valida se o individuo está na caixa de Crossover
            if (Constants.random.NextDouble() < taxaCrossover)
            {
                //Console.Write("Caiu na taxa de crossover. Ponto de corte " + pontoDeCorte +" \n");
                for(int i = pontoDeCorte; i < Constants.sizeCromossomo; i++)
                {
                    novoInd[PAI].SetGene(i, maeBuffer.GetGene(i));
                    novoInd[MAE].SetGene(i, paiBuffer.GetGene(i));
                }
            }

            return novoInd;
        }

        /*
         * Verifica se um indivíduo está dentro da taxa de mutacao.
         * Realiza a mutação do individuo. 
         * Retorna o individuo mutado se está na taxa de mutacao, caso contrario retorna o 
         * mesmo individuo
         */
        public Individuo Mutacao(Individuo ind)
        {
            //Verifica se o individuo cai na taxa de mutacao
            if (Constants.random.NextDouble() <= taxaMutacao)
            {
                int genePosition = Constants.random.Next(0, Constants.sizeCromossomo);
                ind.MutarBit(genePosition);
            }

            return ind;
        }

        /*
         * Retorna um individuo a partir da populacao, sendo esse individuo retornado conforme
         * sorteio
         */
        public Individuo Roleta(Populacao pop)
        {
            double numSorteado = Constants.random.NextDouble() * 100;

            foreach (Individuo ind in pop.GetPopulacao())
            {
                if(numSorteado >= ind.GetRangeRoleta()[0] && numSorteado <= ind.GetRangeRoleta()[1])
                {
                    return ind;
                }
            }

            return null;
        }

    }
}
