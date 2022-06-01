using System;

namespace Revisao_1_Exercicio_2
{
    // Escreva um programa que receba 2 valores e mostre o maior entre eles;

    class Program
    {
        static void Main(string[] args)
        {

            decimal primeiro;
            decimal segundo;
            decimal resultado;

            Console.WriteLine("insira 2 valores para que o programa diga qual é o maior: ");

            Console.WriteLine("insira o primeiro e aperte ENTER: ");
            primeiro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira o segundo e aperte ENTER: ");
            segundo = Convert.ToDecimal(Console.ReadLine());

            if (primeiro > segundo)
            {
                resultado = primeiro;
                Console.WriteLine($"O maior valor entre: {primeiro} e {segundo}, É {resultado}");
            }
            else if (segundo > primeiro)
            {
                resultado = segundo;
                Console.WriteLine($"O maior valor entre: {primeiro} e {segundo}, É {resultado}");
            }
            else 
            {
                Console.WriteLine(" Os valores são iguais");
            }            

        }
    }
}
