using System;

namespace Lista_3_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetorNota = new int[10];
            int posicao = 1;

            int maior = 0;
            int menor = 0;
            int somatoria = 0;
            int media;



            for (int i = 0; i < vetorNota.Length; i++)
            {

                Console.WriteLine("insira a nota: " + posicao++);
                vetorNota[i] = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    maior = vetorNota[i];
                    menor = vetorNota[i];
                }


                else if (vetorNota[i] > maior)
                {
                    maior = vetorNota[i];
                }


                else if (vetorNota[i] < menor)
                {
                    menor = vetorNota[i];
                }


                somatoria += vetorNota[i];

            }

            media = somatoria / posicao;

            Console.WriteLine("A maior nota é: " + maior);
            Console.WriteLine("A menor nota é: " + menor);
            Console.WriteLine("A média das notas é: " + media);

        }
    }
}
