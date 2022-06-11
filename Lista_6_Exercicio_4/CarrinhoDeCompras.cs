using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class CarrinhoDeCompras
    {
        public string ListaDeProdutos { get; set; }

        public CarrinhoDeCompras(string ListaDeProdutos)
        {
            this.ListaDeProdutos = ListaDeProdutos;
        }
    }
}
