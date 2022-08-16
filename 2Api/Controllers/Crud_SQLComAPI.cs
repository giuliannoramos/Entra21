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
        private readonly PessoaRepository _pessoaRepository;
        private static readonly List<Pessoa> pessoas = new List<Pessoa>();        
        public Crud_SQLComAPI()
        {
            _pessoaRepository = new PessoaRepository();
        }

        [HttpPost]
        public IActionResult Salvar(SalvarPessoaViewModel salvarPessoaViewModel)
        {
            if (salvarPessoaViewModel == null)
                return Ok("Não foram informados dados");

            if (salvarPessoaViewModel.Pessoa == null)
                return Ok("Dados da pessoa não informados.");

            if (salvarPessoaViewModel.Endereco == null)
                throw new ArgumentNullException($"campo {nameof(salvarPessoaViewModel.Endereco)} vazio ou nulo.");

            if (salvarPessoaViewModel.Telefones == null || !salvarPessoaViewModel.Telefones.Any())
                throw new ArgumentNullException($"campo {nameof(salvarPessoaViewModel.Telefones)} vazio ou nulo.");

            var resultado = _pessoaRepository.SalvarPessoa(salvarPessoaViewModel.Pessoa,
                                                           salvarPessoaViewModel.Endereco,
                                                           salvarPessoaViewModel.Telefones);

            if (resultado) return Ok("Pessoa cadastrada com sucesso.");

            return Ok("Houve um problema ao salvar. Pessoa não cadastrada.");
        }

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
                           (Nome, Cpf)
                           OUTPUT Inserted.Id
                           values (@nome, @cpf)";
                using (var sql = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@nome", pessoa.Nome);
                    command.Parameters.AddWithValue("@cpf", pessoa.Cpf);                    
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
                sucesso = true,
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
