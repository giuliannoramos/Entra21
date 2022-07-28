using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQL_1J
{
    class Program
    {

        static void Main(string[] args)
        {
            string connection = @"Data Source=ITELABD12\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True;";
            List<Pessoa> pessoas = new List<Pessoa>();


            Console.WriteLine("\n\n Informe a operação desejada:");
            Console.WriteLine(" 1 - Inserir uma pessoa na tabela.");
            Console.WriteLine(" 2 - Consultar cadastros de pessoas.");
            Console.WriteLine(" 3 - Atualizar cadastro de pessoa.");
            Console.WriteLine(" 4 - Deletar um cadastro de pessoa.");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != 0)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Insira o Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Insira o CPF:");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("Insira o Rg:");
                    string rg = Console.ReadLine();
                    Console.WriteLine("Insira o Telefone:");
                    string telefone = Console.ReadLine();
                    Console.WriteLine("Insira o Endereço:");
                    string endereco = Console.ReadLine();
                    Console.WriteLine("Insira a Data de nascimento:");
                    DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Insira a Naturalidade:");
                    string naturalidade = Console.ReadLine();

                    Pessoa pessoa = new Pessoa(nome, cpf, rg, telefone, endereco, dataDeNascimento, naturalidade);

                    try
                    {
                        var query = "insert into Pessoa " +
                                  "(Nome, Cpf, Rg, DataDeNascimento, Naturalidade) " +
                                  "values (@nome,@cpf,@rg,@dataNascimento,@naturalidade)";
                        using (var sql = new SqlConnection(connection))
                        {
                            SqlCommand command = new SqlCommand(query, sql);
                            command.Parameters.AddWithValue("@nome", pessoa.Nome);
                            command.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                            command.Parameters.AddWithValue("@rg", pessoa.Rg);
                            command.Parameters.AddWithValue("@dataNascimento", pessoa.DataNascimento);
                            command.Parameters.AddWithValue("@naturalidade", pessoa.Naturalidade);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                        }
                        Console.WriteLine("Pessoa cadastrada com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro: " + ex.Message);
                    }
                }

                if (opcao == 2)
                {
                    try
                    {
                        SqlDataReader resultado;
                        var query = @"SELECT Id, Nome, Cpf, Rg, DataDeNascimento, Naturalidade FROM Pessoa";
                        using (var sql = new SqlConnection(connection))
                        {
                            SqlCommand command = new SqlCommand(query, sql);
                            command.Connection.Open();
                            resultado = command.ExecuteReader();

                            while (resultado.Read())
                            {
                                pessoas.Add(new Pessoa(resultado.GetInt32(resultado.GetOrdinal("Id")),
                                                       resultado.GetString(resultado.GetOrdinal("Nome")),
                                                       resultado.GetString(resultado.GetOrdinal("Cpf")),
                                                       resultado.GetString(resultado.GetOrdinal("Rg")),
                                                       resultado.GetString(resultado.GetOrdinal("Naturalidade")),
                                                       resultado.GetDateTime(resultado.GetOrdinal("DataDeNascimento"))));
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n¦==============================================================¦");
                        Console.WriteLine("¦======================  LISTA DE PESSOAS  ====================¦");
                        Console.WriteLine("¦==============================================================¦");
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (Pessoa p in pessoas)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n========Inicio========");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Nome: " + p.Nome);
                            Console.WriteLine("CPF: " + p.Cpf);
                            Console.WriteLine("Rg: " + p.Rg);
                            Console.WriteLine("Telefone: " + p.Telefone);
                            Console.WriteLine("Endereço: " + p.Endereco);
                            Console.WriteLine("Idade: " + p.Idade);
                            Console.WriteLine("Naturalidade: " + p.Naturalidade);
                            Console.WriteLine("Data de Nascimento: " + p.DataNascimento);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("==========Fim=========");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro: " + ex.Message);
                    }
                }

                if (opcao == 3)
                {
                    Console.WriteLine("\n\n Digite o nome da pessoa deseja alterar");                    
                    string pSelecionada = Convert.ToString(Console.ReadLine());

                    
                }

                Console.WriteLine("\n\n Informe a operação desejada:");
                Console.WriteLine(" 1 - Inserir uma pessoa na tabela.");
                Console.WriteLine(" 2 - Consultar cadastros de pessoas.");
                Console.WriteLine(" 3 - Atualizar cadastro de pessoa.");
                Console.WriteLine(" 4 - Deletar um cadastro de pessoa.");
                Console.WriteLine(" 0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }                      
        }
    }
}
