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
                                  "(Nome, Cpf, Rg, Telefone, Endereco, DataDeNascimento, Naturalidade) " +
                                  "values (@nome,@cpf,@rg,@telefone,@endereco,@dataDeNascimento,@naturalidade)";
                        using (var sql = new SqlConnection(connection))
                        {
                            SqlCommand command = new SqlCommand(query, sql);
                            command.Parameters.AddWithValue("@nome", pessoa.Nome);
                            command.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                            command.Parameters.AddWithValue("@rg", pessoa.Rg);
                            command.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                            command.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                            command.Parameters.AddWithValue("@dataDeNascimento", pessoa.DataDeNascimento);
                            command.Parameters.AddWithValue("@naturalidade", pessoa.Naturalidade);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Pessoa cadastrada com sucesso.");
                        Console.ForegroundColor = ConsoleColor.White;
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
                        var query = @"SELECT Id, Nome, Cpf, Rg, Telefone, Endereco, DataDeNascimento, Naturalidade FROM Pessoa";
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
                                                       resultado.GetString(resultado.GetOrdinal("Telefone")),
                                                       resultado.GetString(resultado.GetOrdinal("Endereco")),
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
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n========Inicio========");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Id: " + p.Id);
                            Console.WriteLine("Nome: " + p.Nome);
                            Console.WriteLine("CPF: " + p.Cpf);
                            Console.WriteLine("Rg: " + p.Rg);
                            Console.WriteLine("Telefone: " + p.Telefone);
                            Console.WriteLine("Endereço: " + p.Endereco);
                            Console.WriteLine("Idade: " + p.Idade);
                            Console.WriteLine("Data de Nascimento: " + p.DataDeNascimento);
                            Console.WriteLine("Naturalidade: " + p.Naturalidade);
                            Console.ForegroundColor = ConsoleColor.Cyan;
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
                    try
                    {     
                        Console.WriteLine("\n Insira o ID da pessoa que deseja alterar");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Pessoa pSelecionada = EncontrarPessoa(pessoas, Id);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{pSelecionada.Nome} localizado ");
                        Console.ForegroundColor = ConsoleColor.White;

                        var query = "UPDATE Pessoa SET" +
                                  "(Id, Nome, Cpf, Rg, Telefone, Endereco, DataDeNascimento, Naturalidade) " +
                                  "values (@id,@nome,@cpf,@rg,@telefone,@endereco,@dataDeNascimento,@naturalidade)";
                        using (var sql = new SqlConnection(connection))
                        {
                            SqlCommand command = new SqlCommand(query, sql);
                            command.Parameters.AddWithValue("@id", pSelecionada.Id);
                            command.Parameters.AddWithValue("@nome", pSelecionada.Nome);
                            command.Parameters.AddWithValue("@cpf", pSelecionada.Cpf);
                            command.Parameters.AddWithValue("@rg", pSelecionada.Rg);
                            command.Parameters.AddWithValue("@dataNascimento", pSelecionada.DataDeNascimento);
                            command.Parameters.AddWithValue("@naturalidade", pSelecionada.Naturalidade);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                        }

                        Console.WriteLine("\n\n Informe a opção que deseja alterar:");
                        Console.WriteLine(" 1 - Alterar id.");
                        Console.WriteLine(" 2 - Alterar nome.");
                        Console.WriteLine(" 3 - Alterar cpf.");
                        Console.WriteLine(" 4 - Alterar rg.");
                        Console.WriteLine(" 5 - Alterar telefone.");
                        Console.WriteLine(" 6 - Alterar endereço.");
                        Console.WriteLine(" 7 - Alterar naturalidade.");
                        Console.WriteLine(" 8 - Alterar data de nascimento.");
                        Console.WriteLine(" 0 - Voltar ao menu principal.");
                        int opcao2 = Convert.ToInt32(Console.ReadLine());

                        while (opcao2 != 0)
                        {
                            if (opcao2 == 1)
                            {
                                Console.WriteLine($"\n Insira um novo id para {pSelecionada} ");
                                pSelecionada.Id = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Id alterado para {pSelecionada.Id} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;

                            }

                            else if (opcao2 == 2)
                            {
                                Console.WriteLine($"\n Insira um novo nome para {pSelecionada} ");
                                pSelecionada.Nome = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Nome alterado para {pSelecionada.Nome} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (opcao2 == 3)
                            {
                                Console.WriteLine($"\n Insira um novo cpf para {pSelecionada} ");
                                pSelecionada.Cpf = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Cpf alterado para {pSelecionada.Cpf} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (opcao2 == 4)
                            {
                                Console.WriteLine($"\n Insira um novo rg para {pSelecionada} ");
                                pSelecionada.Rg = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Rg alterado para {pSelecionada.Rg} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (opcao2 == 5)
                            {
                                Console.WriteLine($"\n Insira um novo número de telefone para {pSelecionada} ");
                                pSelecionada.Telefone = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Telefone alterado para {pSelecionada.Telefone} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (opcao2 == 6)
                            {
                                Console.WriteLine($"\n Insira um novo endereço para {pSelecionada} ");
                                pSelecionada.Endereco = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Endereço alterado para {pSelecionada.Endereco} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (opcao2 == 7)
                            {
                                Console.WriteLine($"\n Insira uma nova naturalidade para {pSelecionada} ");
                                pSelecionada.Naturalidade = Convert.ToString(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Naturalidade alterado para {pSelecionada.Naturalidade} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (opcao2 == 8)
                            {
                                Console.WriteLine($"\n Insira uma nova data de nascimento para {pSelecionada} ");
                                pSelecionada.DataDeNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"\n Data de nascimento alterado para {pSelecionada.DataDeNascimento} com sucesso.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }                            
                        }

                        Console.WriteLine("\n\n Informe a opção que deseja alterar:");
                        Console.WriteLine(" 1 - Alterar id.");
                        Console.WriteLine(" 2 - Alterar nome.");
                        Console.WriteLine(" 3 - Alterar cpf.");
                        Console.WriteLine(" 4 - Alterar rg.");
                        Console.WriteLine(" 5 - Alterar telefone.");
                        Console.WriteLine(" 6 - Alterar endereço.");
                        Console.WriteLine(" 7 - Alterar naturalidade.");
                        Console.WriteLine(" 8 - Alterar data de nascimento.");
                        Console.WriteLine(" 0 - Voltar ao menu principal.");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                        
                    }


                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro: " + ex.Message);
                    }
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
        static Pessoa EncontrarPessoa(List<Pessoa> pessoas, int Id)
        {
            Pessoa pessoa = null;
            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Id == Id)
                {
                    pessoa = pessoas[i];
                }
            }
            return pessoa;
        }
    }
}
