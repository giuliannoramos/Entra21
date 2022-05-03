using System;

namespace exercicios_fixaçao_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal primeira;
            decimal segunda;
            decimal terceira;
            decimal media;

            Console.WriteLine("Insira sua primeira nota: ");
            primeira = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira a segunda nota: ");
            segunda = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira a terceira nota: ");
            terceira = Convert.ToDecimal(Console.ReadLine());

            if (primeira > segunda & primeira > terceira)
            {

                Console.WriteLine("Sua maior nota é:  = " + primeira);

            }

            else if (segunda > primeira & segunda > terceira)
            {

                Console.WriteLine("Sua maior nota é:  = " + segunda);

            }

            else if (terceira > primeira & terceira > segunda)
            {

                Console.WriteLine("Sua melhor nota é:  = " + terceira);

            }



            if (primeira < segunda & primeira < terceira)
            {

                Console.WriteLine("Sua pior nota é:  = " + primeira);

            }

            else if (segunda < primeira & segunda < terceira)
            {

                Console.WriteLine("Sua pior nota é:  = " + segunda);

            }

            else if (terceira < primeira & terceira < segunda)
            {

                Console.WriteLine("Sua pior nota é:  = " + terceira);

            }


            media = (primeira + segunda + terceira) / 3;

            Console.WriteLine("A média de suas notas é:" + media);




        }
    }
}
