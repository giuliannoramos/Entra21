using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Api.Controllers
{
    //nome da controller / action que deseja (no caso Values/Adicao) 
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
            //https://localhost:44365/Values/Adicao?n1=10&n2=2
        }

        [HttpGet]
        public decimal Subtracao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 - n2);            

            return resultado;
            //https://localhost:44365/Values/Subtracao?n1=10&n2=2
        }

        [HttpGet]
        public decimal Multiplicacao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 * n2);            

            return resultado;
            //https://localhost:44365/Values/Multiplicacao?n1=10&n2=2
        }

        [HttpGet]
        public decimal Divisao(decimal n1, decimal n2)
        {
            decimal resultado;
            resultado = (n1 / n2);           

            return resultado;
            //https://localhost:44365/Values/Divisao?n1=10&n2=2
        }
    }   
}
