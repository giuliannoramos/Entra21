using System;

namespace Revisao_2_Exercicio_2
{
    //(com vetor) Faça um programa qye receba 7 valores e atribua em outro vetor;

    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 1;            

            Console.WriteLine($" Insira 7 valores, para que o programa os atribua em outro vetor. ");

            double[] valor1 = new double[7];
            double[] valor2 = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($" Valor {posicao++}: ");
                valor1[i] = Convert.ToDouble(Console.ReadLine());                
            }

            for (int i = 0; i < 7; i++)
            {
                valor2[i] = valor1[i];
                Console.WriteLine($" segundo vetor com os valores do primeiro: {valor2[i]} ");
            }

        }
    }
}
