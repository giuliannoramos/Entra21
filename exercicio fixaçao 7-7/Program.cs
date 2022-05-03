using System;

namespace exercicio_fixaçao_7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dab;
            decimal xa;
            decimal xb;
            decimal ya;
            decimal yb;
            decimal x;
            decimal y;
            decimal quadradoX;
            decimal quadradoY;
            decimal resultado;

            //aqui escreve na tela
            Console.WriteLine("Insira a coordenada Xa: ");
            xa = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira a coordenada Xb: ");
            xb = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira a coordenada ya: ");
            ya = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira a coordenada yb: ");
            yb = Convert.ToDecimal(Console.ReadLine());

            x = xa - xb;
            y = ya - yb;

            quadradoX = x * x;
            quadradoY = y * y;

            dab = (quadradoX + quadradoY) / 2;

            resultado = dab;


            Console.WriteLine("o resultado é: " + resultado);



        }
    }
}
