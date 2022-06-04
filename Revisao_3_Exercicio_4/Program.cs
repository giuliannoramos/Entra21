using System;

namespace Revisao_3_Exercicio_4
{
    // Faça um programa que receba uma string em uma função e retorne um array de char desse texto;

    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine($" Insira um texto para que o programa os separe e diga quantos caracteres foram utilizados no total.");
            texto = Console.ReadLine();

            RetornoArray(texto);
        }


        static char[] RetornoArray(string texto)
        {
            char[] chars = new char[texto.Length];

            int posicao = 1;

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = texto[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine($"{posicao++} - {chars[i]}");
            }

            Console.WriteLine($" São {posicao - 1} espaços de textos utilizados no total.");

            return chars;
        }
    }
}
