using System;

namespace Lista_3_Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usuario = new string[] { "maria", "joana", "lucas", "pedro", "paulo" };
            double[] saldo = new double[] { 1000, 1000, 1000, 1000, 1000 };


            //int posicao = 0;
            //int posicao2 = 0;
            double saque;
            double deposito;
            double transferencia;

            //for (int i = 0; i < usuario.length; i++)
            //{
            //    posicao++;
            //    console.writeline(posicao + " - insira o nome da conta: ");
            //    usuario[i] = convert.tostring(console.readline());
            //}

            //for (int i = 0; i < saldo.Length; i++)
            //{
            //    posicao2++;
            //    Console.WriteLine($"{posicao2} - insira o saldo da conta de {usuario[i]}: ");
            //    saldo[i] = Convert.ToDouble(Console.ReadLine());
            //}



            //mostra as contas existentes;
            Console.WriteLine(" Contas existentes:");
            for (int i = 0; i < usuario.Length; i++)
            {
                //mostra os nomes e o saldo de cada conta existente;
                Console.WriteLine($"{usuario[i]} tem R$ {saldo[i]}");
            }

            // essa função solicita a operação que o usuario deseja fazer.
            Console.WriteLine(" Informe a operação desejada:");
            Console.WriteLine("\t1 - Sacar");
            Console.WriteLine("\t2 - Depositar");
            Console.WriteLine("\t3 - Transferir");
            Console.WriteLine("\t0 - Finalizar a execução do programa");
            int opcao = Convert.ToInt32(Console.ReadLine());


            while (opcao != 0)
            {
                switch (opcao)
                {
                    case 1:
                        {

                            Console.WriteLine("Deseja sacar de qual conta?:");
                            string opcaoUsuario = Console.ReadLine();

                            // encontrar a conta;                            
                            for (int i = 0; i < usuario.Length; i++)
                            {
                                // verifica se a conta digitada é igual a existente;
                                if (usuario[i] == opcaoUsuario)
                                {
                                    Console.WriteLine($"Conta encontrada.");
                                    Console.WriteLine($"Qual a quantia do saque?:");
                                    saque = Convert.ToInt32(Console.ReadLine());

                                    // verifica se a conta tem saldo suficiente para o saque;
                                    if (saldo[i] >= saque)
                                    {
                                        // caso a conta tenha saldo suficiente, efetua o saque;
                                        saldo[i] = saldo[i] - saque;
                                        Console.WriteLine("Saque efetuado.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficente na conta informada.");
                                    }
                                }
                                else;



                            }
                        }
                        break;


                    case 2:
                        {

                            Console.WriteLine("Deseja depositar em qual conta?:");
                            string opcaoUsuario = Console.ReadLine();

                            // encontrar a conta;                            
                            for (int i = 0; i < usuario.Length; i++)
                            {
                                if (usuario[i] == opcaoUsuario)
                                {
                                    Console.WriteLine($"Qual a quantia do depósito?:");
                                    deposito = Convert.ToInt32(Console.ReadLine());

                                    saldo[i] = saldo[i] + deposito;
                                    Console.WriteLine("Depósito efetuado.");
                                }
                                else;

                            }
                        }

                        break;


                    case 3:
                        {

                            Console.WriteLine("Deseja transferir de qual conta?:");
                            string opcaoUsuario1 = Console.ReadLine();

                            // encontrar a conta;                            
                            for (int i = 0; i < usuario.Length; i++)
                            {
                                // verifica se a conta digitada é igual a existente;
                                if (usuario[i] == opcaoUsuario1)
                                {
                                    Console.WriteLine($"Conta encontrada.");
                                    Console.WriteLine($"Qual a quantia da transferência?:");
                                    transferencia = Convert.ToInt32(Console.ReadLine());

                                    // verifica se a conta tem saldo suficiente para o saque;
                                    if (saldo[i] >= transferencia)
                                    {
                                        // caso a conta tenha saldo suficiente, efetua o saque;
                                        saldo[i] -= transferencia;

                                        Console.WriteLine("Qual a conta destino para a transferência?:");
                                        string opcaoUsuario2 = Console.ReadLine();

                                        // encontrar a conta;                            
                                        for (int j = 0; j < usuario.Length; j++)
                                        {
                                            if (usuario[j] == opcaoUsuario2)
                                            {
                                                saldo[j] += transferencia;
                                                Console.WriteLine("transferência realizada.");

                                            }
                                            else;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficente na conta informada, para realizar a transferência.");
                                    }

                                }

                            }
                            break;

                        }

                }

                //mostra as contas existentes;
                Console.WriteLine(" Contas existentes:");
                for (int i = 0; i < usuario.Length; i++)
                {
                    //mostra os nomes e o saldo de cada conta existente;
                    Console.WriteLine($"{usuario[i]} tem R$ {saldo[i]}");
                }

                Console.WriteLine(" Informe a operação desejada:");
                Console.WriteLine("\t1 - Sacar");
                Console.WriteLine("\t2 - Depositar");
                Console.WriteLine("\t3 - Transferir");
                Console.WriteLine("\t0 - Finalizar a execução do programa");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
