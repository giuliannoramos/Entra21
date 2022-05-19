using System;

namespace Lista_3_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int tamanhoArray;


            Console.WriteLine("Defina o numero de entradas : ");
            tamanhoArray = Convert.ToInt32(Console.ReadLine());




            if (tamanhoArray > 0)
            {
                int[] numero = new int[tamanhoArray];
                int[] numeroRepetido = new int[tamanhoArray];
                int[] numeroDeRepeticoes = new int[tamanhoArray];


                for (int i = 0; i < numero.Length; i++)
                {
                    Console.WriteLine(" Digite um número : ");
                    numero[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < numero.Length; i++)
                {
                    Console.WriteLine(" O número digitado foi : " + numero[i]);
                }

                for (int i = 0; i <= numero.Length; i++)
                {

                    for (int u = i + 1; u < numero.Length; u++)
                    {

                        if (numero[i] == numero[u])
                        {
                            numeroRepetido[i] = numero[u];
                            numeroDeRepeticoes[i]++;
                        }

                    }


                }

                for (int i = 0; i < numeroDeRepeticoes.Length; i++)
                {
                    if (numeroDeRepeticoes[i] > 0)
                    {
                        Console.WriteLine(" O número : " + numeroRepetido[i] + " se repete por " + numeroDeRepeticoes[i] + " vezes ");
                    }
                }

            }

        }
    }
}
