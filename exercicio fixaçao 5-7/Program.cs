using System;

namespace exercicio_fixaçao_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor;
            decimal desconto;
            decimal percentual;
            decimal valorDescontado;
            int verificar;
            decimal imposto;

            Console.WriteLine("Insira o valor do produto: ");
            valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira o percentual de desconto: ");
            desconto = Convert.ToDecimal(Console.ReadLine());

            if (valor <= 100)
            {
                verificar = 5;
                imposto = (valor * verificar) / 100;

                Console.WriteLine("O imposto a ser pago é:  = " + imposto);
                valor = valor + imposto;
            }

            else if (valor > 100 & valor <= 300)
            {
                verificar = 15;
                imposto = (valor * verificar) / 100;

                Console.WriteLine("O imposto a ser pago é:  = " + imposto);
                valor = valor + imposto;
            }

            else if (valor > 301 & valor <= 1000)
            {
                verificar = 25;
                imposto = (valor * verificar) / 100;

                Console.WriteLine("O imposto a ser pago é:  = " + imposto);
                valor = valor + imposto;
            }



            Console.WriteLine("o valor é:" + valor);

            Console.WriteLine("o desconto é:" + desconto);

            percentual = (valor * desconto) / 100;

            Console.WriteLine("o percentual a ser descontado é:" + percentual);

            valorDescontado = valor - desconto;
            Console.WriteLine("o valor a ser pago é:" + valorDescontado);


        }
    }
}
