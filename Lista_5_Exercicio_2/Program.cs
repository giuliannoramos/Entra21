using System;

namespace Lista_5_Exercicio_2
{
    //Escreva um jogo, usando funções, em que o usuário informa um
    //valor e o programa gerará um valor aleatório.O usuário deve ir
    //digitando até acertar, e assim, o programa finaliza.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Random random = new Random();
            int[] numero = new int [];

            for (int i = 0; i < 10; i++)
            {
                numero[i] = random.NextDouble() * 10;
                Console.WriteLine($"{aluno[i]} tirou {nota1[i]}");
            }

        }
    }
}
