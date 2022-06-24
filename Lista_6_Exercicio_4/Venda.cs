using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lista_6_Exercicio_4
{
    public class Venda
    {
        public CarrinhoDeCompras CarrinhoDeCompras { get; set; }
        public double ValorTotalVenda 
        { 
            get
            {
                double total = 0;
                if (Produtos != null && Produtos.Any())
                {
                    foreach (Produto p in Produtos)
                    {
                        total += p.Preco;
                    }
                }
                return total;
            }            
        }

        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public bool Finalizada { get; set; }

        public Venda(CarrinhoDeCompras CarrinhoDeCompras, Vendedor Vendedor, Cliente Cliente)
        {
            this.CarrinhoDeCompras = CarrinhoDeCompras;            
            this.Vendedor = Vendedor;
            this.Cliente = Cliente;
        }

        public Venda()
        {

        }

    }
}
