using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Api.Controllers
{
    public class SalvarPessoaViewModel
    {
        public Pessoa Pessoa { get; set; }
        public Endereco Endereco { get; set; }
        public List<Telefones> Telefones { get; set; }
    }
}
