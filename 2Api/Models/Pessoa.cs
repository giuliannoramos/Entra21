using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Api.Controllers
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public List<Telefones> Telefones { get; set; }
    }
}
