using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Api.Controllers
{
    public class CadastrarPessoaViewModel
    {
        public Pessoa Pessoa { get; set; }
        public List<Endereco> Endereco { get; set; }
        public List<Telefone> Telefone { get; set; }
    }
}
