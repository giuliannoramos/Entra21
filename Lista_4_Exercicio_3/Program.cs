using System;

namespace Lista_4_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            

            Console.WriteLine("Defina o valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            int tamanhoArray = Convert.ToInt32(valor);
            int[] divisiveis = new int[tamanhoArray]; 

            for (int i = 1; i < tamanhoArray; i++)
            {
                int valorDividido = valor / i;

                if (valorDividido % 2 == 0)
                {
                    divisiveis[i] = i;
                    Console.WriteLine($" {divisiveis[i]} ");
                }
                
            }

        }

        



        //static int VerificarDivisiveis(int[] tamanhoArray, int[] divisiveis, int divisor)
        //{

        //    for (int i = 1; i < tamanhoArray.Length; i++)
        //    {
        //        Console.WriteLine(" Digite um número : ");
        //        tamanhoArray[i] = Convert.ToInt32(Console.ReadLine());
        //    }

        //    return divisor;

        //}


    }
}
