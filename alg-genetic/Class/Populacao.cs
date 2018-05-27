using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.Class
{
    public class Populacao
    {
        //Atributos
        private Individuo[] populacao; //Array com n individuos

        //Construtor
        public Populacao()
        {
            this.populacao = new Individuo[Constants.sizePopulacao];

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                populacao[i] = new Individuo();
            }

            //Avaliaçao da populacao
            CalcularFitness();
            CalcularFitnessPercent();
            CalcularRangeRoleta();
        }

        //Getters & Setters
        public Individuo[] GetPopulacao()
        {
            return this.populacao;
        }

        public void SetIndividuo(int pos, Individuo ind)
        {
            this.populacao[pos] = ind;
        }

        public double GetMediaPopulacao()
        {
            double sum = 0;

            foreach (Individuo ind in populacao)
            {
                sum += ind.GetFitness();
            }

            return sum / Constants.sizePopulacao;
        }

        //Métodos

        /*
         * Método que cálcula o fitness de cada individuo da populacao
         * Para calcular aplica o valor inteiro do individui na funcao de aptidao
         */
        public void CalcularFitness()
        {
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                this.populacao[i].SetFitness(Constants.function1(this.populacao[i].GetInt()));
            }
        }

        /*
         * Cálculo do fitness percentual de cada individuo da populacao
         */
         public void CalcularFitnessPercent()
        {
            double somatoriaFitness = 0;

            //Somatorio de todos os valores de aptidao
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                somatoriaFitness += populacao[i].GetFitness();
            }

            //Cálculo do valor da taxa fitness em relação ao total da populacao
            double fitPercent;
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                fitPercent = populacao[i].GetFitness() * 100 / somatoriaFitness;
                populacao[i].SetFitnessPercent(fitPercent);
            }
        }

        /*
         * Cálculo do Range da Roleta em que o Individuo faz parte
         */
         public void CalcularRangeRoleta()
        {
            //Ordenacao dos individuos em ordem crescente
            //Chamada do método para ordendar a populacao
            OrdenarPopulacao();
            double somatoria = 0;

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                //Indivivuo menos apto
                if (i == 0)
                {
                    somatoria += populacao[i].GetFitnessPercent();
                    populacao[i].SetRangeRoleta(0, somatoria);
                }
                else if (i == (Constants.sizePopulacao - 1))
                {
                    populacao[i].SetRangeRoleta(somatoria, 100);
                }
                else
                {
                    populacao[i].SetRangeRoleta(somatoria, somatoria + populacao[i].GetFitnessPercent());
                    somatoria += populacao[i].GetFitnessPercent();
                }
            }
        }

        /*
         * Atualiza os valores da roleta
         */
         public void AtualizarValores()
        {
            //Calcular Fitness
            CalcularFitness();

            //Calcular FitnessPercent
            CalcularFitnessPercent();

            //Calcular Range da roleta
            CalcularRangeRoleta();
        }

        /*
         * Metodo para ordenar a populacao
         */ 
        public void OrdenarPopulacao()
        {
            Individuo aux = new Individuo();

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                for(int j = 0; j < Constants.sizePopulacao; j++)
                {
                    if (populacao[i].GetFitnessPercent() < populacao[j].GetFitnessPercent())
                    {
                        aux = populacao[i];
                        populacao[i] = populacao[j];
                        populacao[j] = aux;
                    }
                }
            }
        }

        /*
         * Exibe os valores da populacao
         */
         public string PrintPop()
        {
            string result = string.Empty;

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                result = result + populacao[i].PrintIndividuo() + " | " + 
                    populacao[i].GetInt().ToString() + " | " + 
                    populacao[i].GetFitness().ToString() + " | " + 
                    populacao[i].GetFitnessPercent().ToString() + "| " + 
                    populacao[i].GetRangeRoleta()[0].ToString() + ":" + 
                    populacao[i].GetRangeRoleta()[1].ToString() + "\n";
            }

            return result;
        } 
    }
}
