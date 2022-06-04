using System;

namespace Revisao_3_Exercicio_3
{
    // Faça um programa que receba dois valores, coloque em uma função e retorne o menor deles;

    class Program
    {
        static void Main(string[] args)
        {
            double primeiro;
            double segundo;
            double resultado;

            Console.WriteLine("insira dois numeros para que o programa diga qual é o menor: ");

            Console.WriteLine("insira o primeiro e aperte ENTER: ");
            primeiro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("insira o segundo e aperte ENTER: ");
            segundo = Convert.ToDouble(Console.ReadLine());

            resultado = MenorNumero(primeiro, segundo);
            Console.WriteLine($" O menor valor informado é = {resultado}");

        }

        static double MenorNumero(double primeiro, double segundo)
        {
            double Menor = 0;

            if (primeiro > segundo)
            {
                Menor = segundo;
            }
            else if (primeiro < segundo)
            {
                Menor = primeiro;
            }
            else
            {
                Console.WriteLine($" Os valores são iguais");
            }


            return Menor;
        }
    }
}
