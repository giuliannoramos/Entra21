using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Api.Controllers
{
    public class Pessoa
    {  
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }

    }
}
