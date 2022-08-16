using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace _2Api.Controllers
{
    public class PessoaRepository
    {
        private readonly string connection = @"Data Source=ITELABD12\SQLEXPRESS.Api; Initial Catalog=Api; Integrated Security=True;";
        public bool SalvarPessoa(Pessoa pessoa, Endereco endereco, List<Telefones> telefones)
        {
            int IdPessoaCriada = -1;
            try
            {
                var query = @"INSERT INTO Pessoa 
                              (Nome, Cpf) 
                              OUTPUT Inserted.Id
                              VALUES (@nome,@cpf)";
                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@nome", pessoa.Nome);
                    command.Parameters.AddWithValue("@cpf", pessoa.Cpf);                    
                    command.Connection.Open();
                    IdPessoaCriada = (int)command.ExecuteScalar();
                }

                SalvarEndereco(endereco, IdPessoaCriada);

                SalvarTelefone(telefones, IdPessoaCriada);

                Console.WriteLine("Pessoa cadastrada com sucesso.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return false;
            }
        }
        private void SalvarTelefone(List<Telefones> telefones, int IdPessoa)
        {
            try
            {
                foreach (var telefone in telefones)
                {
                    var query = @"INSERT INTO Telefone 
                              (DDD, Numero, IdPessoa)                               
                              VALUES (@ddd,@numero,@idPessoa)";
                    using (var sql = new SqlConnection(connection))
                    {
                        SqlCommand command = new SqlCommand(query, sql);
                        command.Parameters.AddWithValue("@ddd", telefone.Ddd);
                        command.Parameters.AddWithValue("@numero", telefone.Numero);
                        command.Parameters.AddWithValue("@idPessoa", IdPessoa);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Telefone cadastrado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
        private void SalvarEndereco(Endereco endereco, int IdPessoa)
        {
            try
            {
                var query = @"INSERT INTO Endereco 
                              (Bairro, Rua, NumeroCasa, IdPessoa)                               
                              VALUES (@bairro,@rua,@numeroCasa, @idPessoa)";
                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    command.Parameters.AddWithValue("@rua", endereco.Rua);
                    command.Parameters.AddWithValue("@numeroCasa", endereco.NumeroCasa);
                    command.Parameters.AddWithValue("@idPessoa", IdPessoa);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                Console.WriteLine("Endereço cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
