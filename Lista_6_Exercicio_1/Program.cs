using System;

namespace Revisao_1_Exercicio_1
{
    //Faça um programa que receba dois números que o usuario digitou, faça a soma e mostre na tela;

    class Program
    {
        static void Main(string[] args)
        {
            decimal primeiro;
            decimal segundo;
            decimal resultado;

            Console.WriteLine("insira dois numeros para que o programa faça a soma entre eles: ");

            Console.WriteLine("insira o primeiro e aperte ENTER: ");
            primeiro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira o segundo e aperte ENTER: ");
            segundo = Convert.ToDecimal(Console.ReadLine());

            resultado = primeiro + segundo; 

            Console.WriteLine($"Seu resultado: {primeiro} + {segundo} = {resultado}");
        }
    }
}
