using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Api
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }        
        public EnderecoDto Endereco { get; set; }
        public List<TelefonesDto> Telefones { get; set; }
    }
}
