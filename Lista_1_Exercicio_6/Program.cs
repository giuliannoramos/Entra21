using System;

namespace Lista_1_Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;


            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Seu resultado: {nome} {sobrenome}");
        }
    }
}
