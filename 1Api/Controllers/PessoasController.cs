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

        [HttpGet]
        public IActionResult GetByName(string nome)
        {
            var resultado = pessoas.Where(x => x.Nome.Contains(nome));
            if (resultado == null || !resultado.Any())
            {
                return NotFound(new { mensage = $"nao foram encontrado nomes" });
            }
            return Ok(new { resultado });
            //https://localhost:44365/pessoas/getbyname?resultado=GiuliannoRamos
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
        }

        //https://localhost:44365/pessoas/savepessoa?validar=false
       /*{
            "nome": "Giulianno Ramos",
            "idade": 22,
            "endereco":
           {
            "rua": "1100",
            "numerocasa": "132"
           },
           "telefone":
           [
              {
              "ddd": "47",
              "numerotelefone": "988887777"
              },
              {
              "ddd": "46",
              "numerotelefone": "988887777"
              }
           ]
          }*/



    }
}
