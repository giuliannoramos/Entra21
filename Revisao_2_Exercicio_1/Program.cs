using System;

namespace Revisao_2_Exercicio_1
{
    // (com vetor) Faca um programa que receba 5 números e mostre o dobro dos valores informados;

    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 1;
            int posicao2 = 1;

            Console.WriteLine($" Insira 5 números, para que o programa mostre o dobro de cada valor. ");                       
            
            double[] valor = new double[5];
            double[] ValorDobrado = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" Número {posicao++}: ");
                valor[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                ValorDobrado[i] = valor[i] * 2;
                Console.WriteLine($" Resultado do número {posicao2++} é: {ValorDobrado[i]}. ");
            }                            

        }
    }
}
