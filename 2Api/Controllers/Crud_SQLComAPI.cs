using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _2Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Crud_SQLComAPI : ControllerBase
    {
        private static readonly List<Pessoa> pessoas = new List<Pessoa>();
        
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                string connection = @"Data Source=ITELABD12\SQLEXPRESS.Api; Initial Catalog=Api; Integrated Security=True;";
                SqlDataReader resultado;
                var query = @"SELECT * FROM Pessoa p 
                            INNER JOIN Endereco e ON p.Id = e.IdPessoaEndereco
                            INNER JOIN Telefones t ON t.Id = t.IdPessoaTelefone
                            WHERE p.Nome LIKE CONCAT'%',@nome,'%'";
                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    resultado = command.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            return Ok(new JsonResult(new
            {
                sucesso = true,
                resultado = pessoas
            }));
            //https://localhost:44319/crud_sqlcomapi/getall?          

        }

        [HttpPost]
        public IActionResult SavePessoa(Pessoa pessoa, bool validar)
        {       
            if (validar)
            {     
                return Ok(new JsonResult(new
                {
                    sucesso = false,
                    mensagem = "Pessoa informada está vazia"
                }));
            }
            pessoas.Add(pessoa);

            try
            {
                int IdPessoaCriada = -1;
                
                string connection = @"Data Source=ITELABD12\SQLEXPRESS.Api; Initial Catalog=Api; Integrated Security=True;";
                var query = @"INSERT INTO Pessoa 
                           (Nome, Cpf, Bairro, Rua, NumeroCasa, Ddd, Numero)
                           OUTPUT Inserted.Id
                           values (@nome, @cpf, @bairro, @rua, @numeroCasa, @ddd, @numero)";
                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@nome", pessoa.Nome);
                    command.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                    command.Parameters.AddWithValue("@bairro", pessoa.Endereco);
                    command.Parameters.AddWithValue("@rua", pessoa.Endereco);
                    command.Parameters.AddWithValue("@numeroCasa", pessoa.Endereco);
                    command.Parameters.AddWithValue("@ddd", pessoa.Telefones);
                    command.Parameters.AddWithValue("@numero", pessoa.Telefones);
                    command.Connection.Open();
                    IdPessoaCriada = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            return (new JsonResult(new
            {
                sucesso = false,
                mensagem = "Pessoa cadastrada"

            }));

            //https://localhost:44319/crud_sqlcomapi/savepessoa?validar=false
            /*{
                 "nome": "Giulianno Ramos",
                 "cpf": "00000000000",
                 "endereco":
                {
                 "bairro": "Centro",
                 "rua": "1100",
                 "numerocasa": "132"
                },
                "telefones":
                [
                   {
                   "ddd": "47",
                   "numero": "988887777"
                   },
                   {
                   "ddd": "46",
                   "numero": "988887777"
                   }
                ]
               }*/

        }
    }
}
