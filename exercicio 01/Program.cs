using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double percentual;
            double aumento;
            double salarioAjustado;


            double dolar;
            dolar = 4.70;

            double euro;
            euro = 5.20;


            double conversaoDolar;
            double conversaoEuro;


            Console.WriteLine("Insira o salário do colaborador: ");
            salario = Convert.ToDouble(Console.ReadLine());



            if (salario <= 1200)
            {
                aumento = 20;
                percentual = (salario * aumento) / 100;
                salarioAjustado = salario + percentual;

                Console.WriteLine("O salário atual é: " + salario);
                Console.WriteLine("O percentual é de: " + aumento);
                Console.WriteLine("O aumento do salario é de: " + percentual);
                Console.WriteLine("O salario rejustado é: " + salarioAjustado);


                conversaoDolar = salario / dolar;
                conversaoEuro = salario / euro;

                Console.WriteLine("O salário convertido para dólar é: " + conversaoDolar);
                Console.WriteLine("O salário convertido para euro  é: " + conversaoEuro);

            }

            else if (salario <= 2000)
            {
                aumento = 13;
                percentual = (salario * aumento) / 100;
                salarioAjustado = salario + percentual;

                Console.WriteLine("O salário atual é: " + salario);
                Console.WriteLine("O percentual é de: " + aumento);
                Console.WriteLine("O aumento do salario é de: " + percentual);
                Console.WriteLine("O salario rejustado é: " + salarioAjustado);

                conversaoDolar = salario / dolar;
                conversaoEuro = salario / euro;

                Console.WriteLine("O salário convertido para dólar é: " + conversaoDolar);
                Console.WriteLine("O salário convertido para euro  é: " + conversaoEuro);
            }

            else if (salario <= 2500)
            {
                aumento = 10;
                percentual = (salario * aumento) / 100;
                salarioAjustado = salario + percentual;

                Console.WriteLine("O salário atual é: " + salario);
                Console.WriteLine("O percentual é de: " + aumento);
                Console.WriteLine("O aumento do salario é de: " + percentual);
                Console.WriteLine("O salario rejustado é: " + salarioAjustado);

                conversaoDolar = salario / dolar;
                conversaoEuro = salario / euro;

                Console.WriteLine("O salário convertido para dólar é: " + conversaoDolar);
                Console.WriteLine("O salário convertido para euro  é: " + conversaoEuro);
            }

            else if (salario > 2500)
            {
                aumento = 5;
                percentual = (salario * aumento) / 100;
                salarioAjustado = salario + percentual;

                Console.WriteLine("O salário atual é: " + salario);
                Console.WriteLine("O percentual é de: " + aumento);
                Console.WriteLine("O aumento do salario é de: " + percentual);
                Console.WriteLine("O salario rejustado é: " + salarioAjustado);

                conversaoDolar = salario / dolar;
                conversaoEuro = salario / euro;

                Console.WriteLine("O salário convertido para dólar é: " + conversaoDolar);
                Console.WriteLine("O salário convertido para euro  é: " + conversaoEuro);
            }

        }
    }
}