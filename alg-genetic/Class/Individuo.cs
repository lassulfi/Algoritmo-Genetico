using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.Class
{
    public class Individuo
    {
        //Atributos
        private BitArray cromossomo; //Vetor de bits, possui apenas dois estados (true or false)
        private double fitness; //Nota de aptidão do individuo
        private double fitnessPercentual; //Taxa de aptidão do individuo (%)
        private double[] faixaRoleta = { 0, 0 }; //Faixa da pizza em que é provável que o individuo seja selecionado

        //Construtor
        public Individuo() {
            //Instancia do cromossomo com a quantidade de bits na classe Constants
            this.cromossomo = new BitArray(Constants.sizeCromossomo);
            //Cria os genes do cromossomo (bits aleatórios)
            for (int i = 0; i < cromossomo.Length; i++)
            {
                this.cromossomo[i] = (Constants.random.NextDouble() > 0.5) ? true : false;
            }
        }

        //Getters & Setters

        /**
         * Retorna o vetor de cromossomos
         **/
        public BitArray GetCromossomo()
        {
            return this.cromossomo;
        }

        /**
         * Inserir valor booleano em uma determinada posição do vetor de cromossomos
         **/
        public void SetGene(int position, bool gene)
        {
            this.cromossomo[position] = gene;
        }

        /*
         * Recupera o bit equivalente ao gene do cromossomo
         */
        public bool GetGene(int position)
        {
            return this.cromossomo[position];
        }

        /*
         * Define o fitness
         */
        public void SetFitness(double fitness)
        {
            this.fitness = fitness;
        }

        /*
         * Recupera o fitness
         */
        public double GetFitness()
        {
            return this.fitness;
        }

        /*
         * Define a taxa de fitness
         */
        public void SetFitnessPercent(double fitPercent)
        {
            this.fitnessPercentual = fitPercent;
        }

        /*
         * Retorna o fitness percentual
         */
        public double GetFitnessPercent()
        {
            return this.fitnessPercentual;
        }

        /*
         * Realiza a mutação de um determinado bit
         */
         public void MutarBit(int position)
        {
            if (position < cromossomo.Length)
            {
                cromossomo.Set(position, cromossomo[position] == false ? true : false);
            }
        }

        /* 
         * Define o range da roleta
         */
         public void SetRangeRoleta(double inicio, double fim)
        {
            this.faixaRoleta[0] = inicio;
            this.faixaRoleta[1] = fim;
        } 

        /*
         * Retorna o range da roleta
         */
         public double[] GetRangeRoleta()
        {
            return this.faixaRoleta;
        }

        /*
         * Retorna o valor em decimal do array de bits
         * Esse valor é utilizado para avaliar a aptidão do individuo
         */

        public int GetInt()
        {
            if(this.cromossomo.Length > 32)
            {
                throw new ArgumentException("O cromossomo deve ter no máximo 32 bits");
            }

            int[] array = new int[1];

            //Através do método CopyTo copia todos os valores do vetor cromossomo para o vetor
            //array
            this.cromossomo.CopyTo(array, 0);

            return array[0];
        }

        /*
         * Retorna uma string com todas as características do indivíduo
         */
         public string PrintIndividuo()
        {
            string result = string.Empty;
            //Representacao binaria do individuo
            result += "BITS: ";
            for (int i = cromossomo.Length - 1; i >= 0; i--)
            {
                result += (cromossomo[i] == false ? "0" : "1");
            }
            //Apitidao
            result += " INT: " + GetInt();
            result += " APTIDÃO: " + GetFitness();
            result += " TAXA DE APTIDÃO: " + GetFitnessPercent() + "\n";

            return result;
        }   

    }
}
