using System;

namespace Lista_2_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string vogal;


            Console.WriteLine("Insira uma letra e aperte ENTER para que o programa diga se é vogal ou consoante: ");
            vogal = Convert.ToString(Console.ReadLine());



            if (vogal == "a" || vogal == "e" || vogal == "i" || vogal == "o" || vogal == "u" || vogal == "A" || vogal == "E" || vogal == "I" || vogal == "O" || vogal == "U")
            {
                Console.WriteLine(" É uma vogal.");
            }


            else
            {
                Console.WriteLine(" É uma consoante.");
            }
        }
    }
}
