using System;

namespace Revisao_3_Exercicio_1
{
    // Faça um programa usando função, que RECEBA dois números e retorne a soma dos mesmos;    

    class Program
    {
        static void Main(string[] args)
        {
            double primeiro;
            double segundo;
            double resultado;

            Console.WriteLine("insira dois numeros para que o programa faça a soma entre eles: ");

            Console.WriteLine("insira o primeiro e aperte ENTER: ");
            primeiro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("insira o segundo e aperte ENTER: ");
            segundo = Convert.ToDouble(Console.ReadLine());

            resultado = Soma(primeiro, segundo);
            Console.WriteLine($"Seu resultado: {primeiro} + {segundo} = {resultado}");

        }

        static double Soma ( double primeiro, double segundo)
        {
            double Soma = primeiro + segundo;            

            return Soma;
        }
    }
}
