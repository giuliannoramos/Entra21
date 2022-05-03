using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal primeiro;
            decimal segundo;
            decimal terceiro;


            Console.WriteLine("Insira três números para que o programa os mostre em ordem crescente: ");

            Console.WriteLine("Insira seu primeiro número: ");
            primeiro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira seu segundo número: ");
            segundo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira seu terceiro número: ");
            terceiro = Convert.ToDecimal(Console.ReadLine());



            if (primeiro < segundo & primeiro < terceiro & segundo < terceiro)
            {
                Console.WriteLine(" a ordem crescente é :" + primeiro + " " + segundo + " " + terceiro);
            }

            else if (primeiro < segundo & primeiro < terceiro & segundo > terceiro)
            {
                Console.WriteLine(" a ordem crescente é :" + primeiro + " " + terceiro + " " + segundo);
            }

            else if (segundo < primeiro & segundo < terceiro & primeiro < terceiro)
            {
                Console.WriteLine(" a ordem crescente é :" + segundo + " " + primeiro + " " + terceiro);
            }

            else if (segundo < primeiro & segundo < terceiro & primeiro > terceiro)
            {
                Console.WriteLine(" a ordem crescente é :" + segundo + " " + terceiro + " " + primeiro);
            }

            else if (terceiro < primeiro & terceiro < segundo & primeiro < segundo)
            {
                Console.WriteLine(" a ordem crescente é :" + terceiro + " " + primeiro + " " + segundo);
            }

            else if (terceiro < primeiro & terceiro < segundo & primeiro > segundo)
            {
                Console.WriteLine(" a ordem crescente é :" + terceiro + " " + segundo + " " + primeiro);
            }

        }
    }
}
