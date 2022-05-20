using System;

namespace Lista_4_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] retorno;

            Console.WriteLine(" Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            retorno = AcharDivisores(numero);
            MostrarDivisores(retorno);
        }       



        static void MostrarDivisores(int[] divisores)
        {
            Console.WriteLine(" Os divisores são: ");
            for (int i = 0; i < divisores.Length; i++)
            {
                if (divisores[i] > 0)
                {
                    Console.WriteLine(divisores[i]);
                }
            }
        }



        static int[] AcharDivisores(int numero)
        {            
            int[] divisores = new int[numero + 1];

            for (int i = 1; i < divisores.Length; i++)
            {                
                if (numero % i == 0)
                {
                    divisores[i] = i;
                }
            }           
            return divisores;
        }

    }
}
