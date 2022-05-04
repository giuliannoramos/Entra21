using System;

namespace exercicio_fixaçao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("seu nome é:" + nome);

            Console.WriteLine("sua idade é:" + idade);

            if (idade < 18)
            {
                Console.WriteLine("voce é menor de idade:");
            }

            else
            {
                Console.WriteLine("voce é maior de idade:");
            }

        }
    }
}