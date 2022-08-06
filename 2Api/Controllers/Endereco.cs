using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Api.Controllers
{
    public class Endereco
    {
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }

        public Endereco(string bairro, string rua, string numeroCasa)
        {
            Bairro = bairro;
            Rua = rua;
            NumeroCasa = numeroCasa;           
        }
    }
}
