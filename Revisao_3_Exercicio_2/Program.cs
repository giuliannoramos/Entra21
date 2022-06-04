using System;

namespace Revisao_3_Exercicio_2
{
    //Faça um programa que receba um vetor de 10 posições e mostre a média dos valores;

    class Program
    {
        static void Main(string[] args)
        {
            string[] posicao = new string[10] { "Posição 1", "Posição 2", "Posição 3", "Posição 4", "Posição 5", "Posição 6", "Posição 7", "Posição 8", "Posição 9", "Posição 10" };

            Console.WriteLine($" Insira os 10 valores para que o programa calcule a média: ");
            double[] valores = new double[10];
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" Insira um valor para {posicao[i]}: ");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }

            CalcularMedia(valores);

        }

        static double CalcularMedia(double[] valores)
        {
            double media = 0;

            for (int i = 0; i < 10; i++)
            {
                media = valores[i] + valores[i] / 20;
            }

            Console.WriteLine($" A média é {media}.");
            return media;
        }

    }
}
