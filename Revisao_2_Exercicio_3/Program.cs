using System;

namespace Revisao_2_Exercicio_3
{
    // (com vetor) Faça um programa que receba 5 valores e multiplique cada posição do vetor pelo seu índice;

    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 1;
            int posicao2 = 1;

            Console.WriteLine($" Insira 5 valores, para que o programa os multiplique pelo índice. ");

            double[] valor = new double[5];
            double[] ValorVezesIndice = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" Número {posicao++}: ");
                valor[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                ValorVezesIndice[i] = valor[i] * i;
                Console.WriteLine($" Resultado do número {posicao2++} é: {ValorVezesIndice[i]}. ");
            }
        }
    }
}
