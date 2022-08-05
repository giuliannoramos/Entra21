using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private static readonly List<Pessoa> pessoas = new List<Pessoa>();
        private static readonly List<Telefone> telefones = new List<Telefone>();
        private static readonly List<Endereco> enderecos = new List<Endereco>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new JsonResult(new
            {
                sucesso = true,
                resultado = pessoas
            }));
            //https://localhost:44365/pessoas/getall?
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

            return (new JsonResult(new
            {
                sucesso = false,
                mensagem = "Pessoa cadastrada"
            }));
            //https://localhost:44365/pessoas/SavePessoa?validar=false
            /*{
                "pessoa" : 
    {
                    "nome": "Giulianno Ramos",        
        "idade": 22
    },
    "endereco": 
    [
        {
                    "rua" : "Rua 1000",
            "NumeroCasa" : "123"
        }       
    ],
    "telefone": 
    [
        {
                    "ddd" : "47",
                 "numero" : "988888888"
              },
              {
                    "ddd" : "47",
            "numero" : "977777777"
               }
              ]
          }*/
        }
    }
}
