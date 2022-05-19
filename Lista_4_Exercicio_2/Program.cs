using System;

namespace Lista_4_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int posicao = 0;
            int maiorValor = 0;


            for (int i = 0; i < valores.Length; i++)
            {
                posicao++;
                Console.WriteLine(posicao + " - insira um número: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            maiorValor = MaiorValor(valores, maiorValor);
            Console.WriteLine($"O maior valor é: {maiorValor}");

        }

        static int MaiorValor(int[] valores, int maiorValor)
        {

            for (int i = 0; i < valores.Length; i++)
            {

                if (i == 0)
                {
                    maiorValor = valores[i];
                }
                else if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }

            }

            return maiorValor;

        }


    }
}
