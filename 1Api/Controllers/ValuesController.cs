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
    public class ValuesController : ControllerBase
    {        

        [HttpGet]
        public decimal Adicao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 + n2);          

            return resultado;
        }

        [HttpGet]
        public decimal Subtracao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 - n2);            

            return resultado;
        }

        [HttpGet]
        public decimal Multiplicacao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 * n2);            

            return resultado;
        }

        [HttpGet]
        public decimal Divisao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 / n2);           

            return resultado;
        }
    }   
}
