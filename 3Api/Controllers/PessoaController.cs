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
        }

        [HttpPut]
        public IActionResult Atualizar(List<Pessoa> pessoa, string nome)
        {
            Pessoa pEncontrada;            
            pEncontrada = EncontrarPessoa(pessoa, nome);

            return Ok(pEncontrada);
        }        

        [HttpGet]
        public List<Pessoa> BuscarTodos(List<Pessoa> pessoas, string nome)
        {            
            var pessoasEncontradas = pessoas.Where(x => x.Nome == (nome)).ToList();
            return pessoasEncontradas;
        }

        [HttpDelete]
        public IActionResult Remover(List<Pessoa> pessoa, string nome)
        {
            Pessoa pEncontrada;
            pEncontrada = EncontrarPessoa(pessoa, nome);
            
            return Ok(pEncontrada);
        }

        static Pessoa EncontrarPessoa(List<Pessoa> pessoas, string nome)
        {
            return pessoas.SingleOrDefault(x => x.Nome == nome);
        }

        //https://localhost:44369/
    }
}
