using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.Class
{
    /**
     * Classe que armazena as contantes do algoritmo 
     **/
    public abstract class Constants
    {
        //Atributos
        static public int sizeCromossomo = 9; //Tamanho do individuo
        static public int sizePopulacao = 1000; //Tamanho da populacao
        static public int functionXSize = (int)Math.Pow(2, sizeCromossomo); //Tamanho da funcao no eixo X
        public static Random random = new Random((int)DateTime.Now.Ticks); //Objeto randomico. Gera numeros pelo clock do processador

        //Métodos
        public static double function1(double x)
        {
            return (double) (100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
        }
    }
}
