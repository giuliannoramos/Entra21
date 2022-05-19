using System;

namespace Lista_3_Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetorNomes = new string[10];


            //aqui solicita as incerções
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("insira um nome: ");
                vetorNomes[contador] = Convert.ToString(Console.ReadLine());
            }

            //aqui cadeia para mostrar os valores registrados em um vetor
            int posicao = 1;
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Nome registrado na posição " + posicao + " é " + vetorNomes[contador]);
                posicao++;
            }

        }
    }
}
