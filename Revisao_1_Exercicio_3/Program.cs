using System;

namespace Revisao_1_Exercicio_3
{
    // Escreva um programa que receba o ano de nascimento de uma pessoa e mostre a idade dela;

    class Program
    {
        static void Main(string[] args)
        {
            decimal AnoNascimento;
            decimal Idade;

            Console.WriteLine("insira seu ano de nascimento, para que o programa mostre sua idade: ");
            AnoNascimento = Convert.ToDecimal(Console.ReadLine());

            Idade = 2022 - AnoNascimento;
            Console.WriteLine($"Sua idade atual em 2022 é: {Idade} ");

            //DateTime.Now.Year - AnoNascimento

        }
    }
}
