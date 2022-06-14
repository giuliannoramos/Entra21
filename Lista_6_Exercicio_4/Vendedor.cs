using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class Vendedor
    {
        public string NomeVendedor { get; set; }
        public int CodigoCracha { get; set; }

        public Vendedor(string NomeVendedor, int CodigoCracha)
        {
            this.NomeVendedor = NomeVendedor;

            this.CodigoCracha = CodigoCracha;
        }

        //public void PreencherDados()
        //{
        //    Console.WriteLine("Insira o nome do vendedor: ");
        //    this.NomeVendedor = Convert.ToString(Console.ReadLine());
        //    Console.WriteLine("Informe o nome do vendedor:");
        //    this.NomeVendedor = Console.ReadLine();
        //    Console.WriteLine("Nome do vendedor:" + this.NomeVendedor);
        //}
    }
}
