using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class Produto
    {
        public int Codigo;
        public string DescricaoProduto;
        public string Marca;
        public double Preco;

        public Produto(int Codigo, string DescricaoProduto, string Marca, double Preco)
        {
            this.Codigo = Codigo;
            this.DescricaoProduto = DescricaoProduto;
            this.Marca = Marca;
            this.Preco = Preco;
        }

    }
}
