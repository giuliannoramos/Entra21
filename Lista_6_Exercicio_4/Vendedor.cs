using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class Vendedor
    {
        public string NomeVendedor { get; set; }
        public int CodigoCracha { get; set; }

        //public Vendedor(string NomeVendedor, int CodigoCracha)
        //{
        //    this.NomeVendedor = NomeVendedor;

        //    this.CodigoCracha = CodigoCracha;
        //}

        public Vendedor()
        { 
        }

        public void PreencherDadosVendedor()
        {
            Console.WriteLine("Insira o nome do vendedor: ");
            NomeVendedor = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o código do crachá: ");
            CodigoCracha = Convert.ToInt32(Console.ReadLine());
        }
    }
}
