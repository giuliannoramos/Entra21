using System;

namespace Lista_2_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal primeira;
            decimal segunda;
            decimal terceira;


            Console.WriteLine("Insira 3 medidas para que o programa informe se os valores podem ser um triângulo: ");
            Console.WriteLine("Insira a primeira medida e aperte ENTER: ");
            primeira = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira a segunda medida e aperte ENTER: ");
            segunda = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira a terceira medida e aperte ENTER: ");
            terceira = Convert.ToDecimal(Console.ReadLine());





            // Três lados formam um triângulo quando a soma de quaisquer dois lados for maior que o terceiro;
            if (primeira + segunda > terceira & primeira + terceira > segunda & segunda + terceira > primeira)
            {

                Console.WriteLine("O triângulo existe");

                //Triângulo Equilátero: três lados iguais;
                if (primeira == segunda & segunda == terceira)
                {

                    Console.WriteLine("Por serem os três lados iguais, são um triângulo Equilátero");

                }


                //Triângulo Isósceles: quaisquer dois lados iguais;
                else if (primeira == segunda)
                {

                    Console.WriteLine("Por ter dois lados iguais é um triângulo Isósceles");

                }

                else if (primeira == terceira)
                {

                    Console.WriteLine("Por ter dois lados iguais é um triângulo Isósceles");

                }

                else if (segunda == terceira)
                {

                    Console.WriteLine("Por ter dois lados iguais é um triângulo Isósceles");

                }

                //Triângulo Escaleno: três lados diferentes;
                else if (primeira != segunda & primeira != terceira)
                {

                    Console.WriteLine("Por ter os três lados diferentes são um triângulo Escaleno");

                }

                else if (segunda != terceira)
                {

                    Console.WriteLine("Por ter os três lados diferentes são um triângulo Escaleno");

                }

            }

            else
            {

                Console.WriteLine("O triângulo não existe");

            }



        }
    }
}
