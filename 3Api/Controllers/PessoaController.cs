using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private static readonly List<Pessoa> pessoas = new List<Pessoa>();

        [HttpPost]
        public IActionResult Salvar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            return Ok(pessoa);

            //https://localhost:44369/Pessoa/salvar?
            //{
            //   "nome": "Giulianno",
            //   "cpf": "00000000000",
            //   "idade": 23
            //}
        }

        [HttpPut]
        public IActionResult Atualizar(Pessoa pessoa, string nome)
        {
            Pessoa pEncontrada;            
            pEncontrada = EncontrarPessoa(nome);

            if (pEncontrada != null)
            {
                pEncontrada.Nome = pessoa.Nome;
                pEncontrada.Cpf = pessoa.Cpf;
                pEncontrada.Idade = pessoa.Idade;
            }
            else { }
            
            return Ok(pEncontrada);

            //https://localhost:44369/Pessoa/Atualizar?nome=Giulianno
            //{
            //  "nome": "Giulianno Lechinski Ramos",
            //  "cpf": "00000000000",
            //  "idade": 23
            //}
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Ok(new JsonResult(new
            {
                sucesso = true,
                resultado = pessoas
            }));

            //https://localhost:44369/Pessoa/BuscarTodos?
        }

        [HttpDelete]
        public IActionResult Remover(string nome)
        {
            bool delete;
            Pessoa pEncontrada;
            pEncontrada = EncontrarPessoa(nome);
            if (pEncontrada != null)
            {
                pessoas.Remove(pEncontrada);
                delete = true;
            }
            else delete = false;
            return Ok(delete);

            //https://localhost:44369/Pessoa/Remover?nome=Giulianno
        }

        static Pessoa EncontrarPessoa(string nome)
        {
            return pessoas.SingleOrDefault(x => x.Nome == nome);
        }        
    }
}
