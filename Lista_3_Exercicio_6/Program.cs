using System;

namespace Lista_3_Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int[] vetorMultiplicar = new int[5];

            int posicao = 0;
            int posicao2 = 0;


            for (int i = 0; i < vetorA.Length; i++)
            {
                posicao++;
                Console.WriteLine(posicao + " A - insira um número: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < vetorB.Length; j++)
            {
                posicao2++;
                Console.WriteLine(posicao2 + " B - insira um número: ");
                vetorB[j] = Convert.ToInt32(Console.ReadLine());
            }

            for (int k = 0; k < vetorMultiplicar.Length; k++)
            {
                vetorMultiplicar[k] = vetorA[k] * vetorB[k];
                Console.WriteLine($"seu resultado é {vetorMultiplicar[k]}");
            }

        }
    }
}
