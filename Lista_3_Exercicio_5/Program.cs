using System;

namespace Lista_3_Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetorTexto = new string[10];
            int posicao = 0;

            for (int i = 0; i < vetorTexto.Length; i++)
            {
                posicao++;
                Console.WriteLine(posicao + " - insira um texto: ");
                vetorTexto[i] = Convert.ToString(Console.ReadLine());

            }

            for (int i = 0; i < vetorTexto.Length; i++)
            {
                Console.Write($"{vetorTexto[i]}__OU__");
            }


        }
    }
}
