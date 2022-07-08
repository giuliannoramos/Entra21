using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_0707
{
    public class Produto
    {
        public int CodigoProduto;
        public string DescricaoProduto;        

        public Produto(int CodigoProduto, string DescricaoProduto)
        {
            this.CodigoProduto = CodigoProduto;
            this.DescricaoProduto = DescricaoProduto;           
        }

    }
}
