using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class Vendedor
    {
        public string NomeVendedor { get; set; }
        public string CodigoCracha { get; set; }

        public Vendedor(string NomeVendedor, string CodigoCracha)
        {
            this.NomeVendedor = NomeVendedor;

            this.CodigoCracha = CodigoCracha;
        }
    }
}
