using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class Venda
    {
        public CarrinhoDeCompras CarrinhoDeCompras { get; set; }
        public double ValorTotalVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public Venda(CarrinhoDeCompras CarrinhoDeCompras, double ValorTotalVenda, Vendedor Vendedor, Cliente Cliente)
        {
            this.CarrinhoDeCompras = CarrinhoDeCompras;
            this.ValorTotalVenda = ValorTotalVenda;
            this.Vendedor = Vendedor;
            this.Cliente = Cliente;
        }

    }
}
