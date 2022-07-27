using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_0707
{
    public class Armazem
    {
        public List<Produto> Produtos = new List<Produto>();
        public int CodigoArmazem;
        public string DescricaoArmazem;

        public Armazem(int CodigoArmazem, string DescricaoArmazem)
        {
            this.CodigoArmazem = CodigoArmazem;
            this.DescricaoArmazem = DescricaoArmazem;
        }      
        
    }

}
