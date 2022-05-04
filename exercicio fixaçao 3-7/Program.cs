using System;

namespace exercicio_fixaçao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal primeiro;
            decimal segundo;

            Console.WriteLine("insira um número e aperte ENTER: ");
            primeiro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira um número e aperte ENTER: ");
            segundo = Convert.ToDecimal(Console.ReadLine());

            // essa função solicita a operação.
            Console.WriteLine("escolha uma das opções abaixo e aperte ENTER:");
            Console.WriteLine("\ta - Adição");
            Console.WriteLine("\tb - Subtracão");
            Console.WriteLine("\tc - Multiplicação");
            Console.WriteLine("\td - Divisão");
            Console.Write("Qual sua opção? ");


            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Seu resultado: {primeiro} + {segundo} = " + (primeiro + segundo));
                    break;
                case "b":
                    Console.WriteLine($"Seu resultado: {primeiro} - {segundo} = " + (primeiro - segundo));
                    break;
                case "c":
                    Console.WriteLine($"Seu resultado: {primeiro} * {segundo} = " + (primeiro * segundo));
                    break;
                case "d":
                    Console.WriteLine($"Seu resultado: {primeiro} / {segundo} = " + (primeiro / segundo));
                    break;
            }

        }
    }
}