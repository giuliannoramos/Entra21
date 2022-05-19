using System;

namespace Lista_4_Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;

            // essa função solicita a operação que o usuario deseja fazer.
            Console.WriteLine(" Informe a operação desejada:");
            Console.WriteLine(" 1 - Adição");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Multiplicação");
            Console.WriteLine(" 4 - Divisão");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());


            while (opcao != (int)Operacao.Sair)
            {

                Console.WriteLine(" Insira o primeiro numero:");
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Insira o segundo numero:");
                n2 = Convert.ToDouble(Console.ReadLine());


                if (opcao == (int)Operacao.Adição)
                {
                    SomarDoisNumeros(n1, n2);
                }

                else if (opcao == (int)Operacao.Subtração)
                {
                    SubtrairDoisNumeros(n1, n2);
                }

                else if (opcao == (int)Operacao.Multiplicação)
                {
                    MultiplicarDoisNumeros(n1, n2);
                }

                else if (opcao == (int)Operacao.Divisão)
                {
                    DividirDoisNumeros(n1, n2);
                }

                Console.WriteLine(" Informe a operação desejada:");
                Console.WriteLine(" 1 - Adição");
                Console.WriteLine(" 2 - Subtração");
                Console.WriteLine(" 3 - Multiplicação");
                Console.WriteLine(" 4 - Divisão");
                Console.WriteLine(" 0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

            }
        }


        static void SomarDoisNumeros(double n1, double n2)
        {
            double res = n1 + n2;
            Console.WriteLine("A soma é " + res);
        }

        static void SubtrairDoisNumeros(double n1, double n2)
        {
            double res = n1 - n2;
            Console.WriteLine("A subtração é " + res);
        }

        static void MultiplicarDoisNumeros(double n1, double n2)
        {
            double res = n1 * n2;
            Console.WriteLine("A multiplicação é " + res);
        }

        static void DividirDoisNumeros(double n1, double n2)
        {
            double res = n1 / n2;
            Console.WriteLine("A divisão é " + res);
        }


        enum Operacao
        {
            Adição = 1,
            Subtração = 2,
            Multiplicação = 3,
            Divisão = 4,
            Sair = 0
        }


    }
}
