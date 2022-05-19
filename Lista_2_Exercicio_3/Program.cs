using System;

namespace Lista_2_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Escreva uma equação do segundo grau no seguinte formato aX2 + bx + c para que o programa determine sua raiz");

            Console.WriteLine("Determine um valor para A e aperte ENTER: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Determine um valor para B e aperte ENTER: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Determine um valor para C e aperte ENTER: ");
            c = Convert.ToInt32(Console.ReadLine());

            double delta;
            delta = (b * b) - (4 * a * c);

            //Se o valor de delta for menor que zero, a equação não possui raízes reais.
            if (delta < 0)
            {
                Console.WriteLine(": A equação não possui raízes reais, pois o valor de delta é menor que zero.");
            }

            //Se o valor de delta for igual a zero, a equação apresentará uma raiz real.
            else if (delta == 0)
            {
                Console.WriteLine(": A equação possui uma raíz real, pois o valor de delta é igual a zero.");
                double raiz;
                raiz = Math.Sqrt(delta);
                Console.WriteLine(" A raíz é: " + raiz);
            }

            //Se o valor de delta for maior que zero, a equação terá duas raízes reais e distintas.
            else if (delta > 0)
            {
                Console.WriteLine(": A equação possui duas raízes reais distintas, pois o valor de delta é maior que zero.");

                double xLinha;
                double xGalinha;
                double raiz;

                raiz = Math.Sqrt(delta);

                xLinha = (-b + raiz) / (2 * a);

                xGalinha = (-b - raiz) / (2 * a);

                if (xLinha > xGalinha)
                {
                    Console.WriteLine(": A solução é: " + xGalinha + " " + xLinha);
                }

                else if (xLinha < xGalinha)
                {
                    Console.WriteLine(": A solução é: " + xLinha + " " + xGalinha);
                }

            }

        }
    }
}
