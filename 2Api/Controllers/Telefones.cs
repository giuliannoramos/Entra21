using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Api.Controllers
{
    public class Telefones
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }

        public Telefones(string ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
        }
    }
}
