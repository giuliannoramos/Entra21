using System;

namespace Lista_2_Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.WriteLine("Insira um ano para que o programa analise e diga se ele é bissexto: ");
            ano = Convert.ToInt32(Console.ReadLine());

            bool verificar1;
            bool verificar2;
            bool verificar3;

            verificar1 = (ano % 4) == 0;
            verificar2 = (ano % 100) > 0;
            verificar3 = (ano % 400) == 0;


            if (verificar1)
            {

                Console.WriteLine("O ano : " + ano + " é bissexto");

            }


            else if (verificar2)
            {
                if (verificar3)
                {
                    Console.WriteLine("O ano : " + ano + " é bissexto");
                }

                else
                {
                    Console.WriteLine("O ano : " + ano + " não é bissexto");
                }
            }


        }
    }
}
