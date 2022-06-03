using System;

namespace Revisao_2_Exercicio_4
{
    //(com vetor) Faca um programa que receba um texto e a partir deste texto, jogue os valores em um novo vetor e mostre cada posição linha a linha;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($" Insira um texto para que o programa os separe e diga quantos caracteres foram utilizados no total.");
            string texto = Console.ReadLine();

            char[] chars = new char[texto.Length];

            int posicao = 1;            

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = texto[i];
            }

            for(int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine($"{posicao++} - {chars[i]}");
            }

            Console.WriteLine($" São {posicao - 1} espaços de textos utilizados no total.");

        }
    }
}
           