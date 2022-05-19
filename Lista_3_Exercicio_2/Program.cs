using System;

namespace Lista_3_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero;
            decimal media = 0;
            decimal somatorio = 0;
            decimal contador = 0;

            do
            {
                Console.WriteLine("Insira um número e aperte ENTER: ");
                numero = Convert.ToDecimal(Console.ReadLine());
                somatorio = somatorio + numero;
                contador++;
            }

            while (numero >= 0);

            Console.WriteLine("O somatorio dos números é: " + somatorio);

            Console.WriteLine("O total de valores inseridos é: " + contador);



            media = somatorio / contador;
            Console.WriteLine("A média dos números é: " + media);
        }
    }
}
