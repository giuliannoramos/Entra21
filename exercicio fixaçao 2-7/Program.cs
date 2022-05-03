using System;

namespace exercicio_fixaçao_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal peso;
            decimal altura;
            decimal IMC;

            Console.WriteLine("insira sua altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira seu peso: ");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("sua altura é:" + altura);

            Console.WriteLine("sua idade é:" + peso);

            IMC = (peso / altura * 2);
            Console.WriteLine("seu IMC é:" + IMC);
        }
    }
}
